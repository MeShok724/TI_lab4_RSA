using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TI_lab_3_v_2
{
    public partial class FormMain : Form
    {
        private int _p;
        private int _q;
        private int _d;
        private int _e;
        private int _r;
        private int _fR;
        private int _hash;
        // private byte[] _messageBytes;
        private int[] _messageIntArray;
        private string _messageText;
        private int _signature;
        private Logic.JsonDataClass _jsonDataClass;
        
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            
            tbInput.Text = "";
            tbResult.Text = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Выберите файл для шифрования";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = fileDialog.FileName;
            // string filename = "C:\\BSUIR\\TI\\lab2\\message.txt";
            // _messageBytes = System.IO.File.ReadAllBytes(filename);
            _messageText = System.IO.File.ReadAllText(filename);
            _messageIntArray = Logic.StringToIntArray(_messageText);
            tbInput.Text = _messageText;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbResult.Text.Length == 0)
            {
                MessageBox.Show("Результат еще не получен");
                return;
            }
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Выберите файл для сохранения";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = fileDialog.FileName;
            string result = JsonConvert.SerializeObject(_jsonDataClass);
            System.IO.File.WriteAllText(filename, result);
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            tbHash.Text = "";
            tbE.Text = "";
            tbR.Text = "";
            _p = Logic.CheckPrime(tbP.Text);
            if (_p == -1)
            {
                MessageBox.Show("p не является простым числом");
                return;
            }
            if (_p >= Logic.topLimit || _p <= Logic.botLimit)
            {
                MessageBox.Show($"Не соблюдается условие {Logic.botLimit} <= p <= {Logic.topLimit}");
                return;
            }
            _q = Logic.CheckPrime(tbQ.Text);
            if (_q == -1)
            {
                MessageBox.Show("Выбранный q не является простым числом");
                return;
            }
            if (_q >= Logic.topLimit || _q <= Logic.botLimit)
            {
                MessageBox.Show($"Не соблюдается условие {Logic.botLimit} <= q <= {Logic.topLimit}");
                return;
            }
            if (!int.TryParse(tbD.Text, out _d))
            {
                MessageBox.Show($"d не является числом");
                return;
            }
            if (_d <= 0 || _d >= Logic.topLimit)
            {
                MessageBox.Show($"d меньше 1 либо слишком большое");
                return;
            }
            _r = _p * _q;
            _fR = (_q - 1) * (_p - 1);
            _e = Logic.GetE(_fR, _d);
            if (!Logic.CheckE(_e, _fR))
            {
                MessageBox.Show($"Полученный e не удовлетворяет условию");
                return;
            }
            if (_messageText == null || _messageText.Length == 0)
            {
                MessageBox.Show("Файл для подписи не выбран");
                return;
            }

            _hash = Logic.GetHash(Logic.H0, _messageIntArray, _r);
            _signature = Logic.GetSignature(_hash, _d, _r);
            _jsonDataClass = new Logic.JsonDataClass();
            _jsonDataClass.text = _messageText;
            _jsonDataClass.S = _signature;
            outputResult();
        }

        private void outputResult()
        {
            tbE.Text = _e.ToString();
            tbR.Text = _r.ToString();
            tbHash.Text = _hash.ToString();
            tbResult.Text = $"text: {_jsonDataClass.text}, S: {_jsonDataClass.S}";
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (_messageText == null || _messageText.Length == 0)
            {
                MessageBox.Show("Файл для проверки не выбран");
                return;
            }
            if (!int.TryParse(tbE.Text, out _e))
            {
                MessageBox.Show($"e не является числом");
                return;
            }
            if (_e <= 0 || _e >= Logic.topLimit)
            {
                MessageBox.Show($"e меньше 1 либо слишком большое");
                return;
            }
            if (!int.TryParse(tbR.Text, out _r))
            {
                MessageBox.Show($"r не является числом");
                return;
            }
            if (_r <= Logic.botLimit || _r >= Logic.topLimit)
            {
                MessageBox.Show($"Не соблюдается условие {Logic.botLimit} <= r <= {Logic.topLimit}");
                return;
            }
            _jsonDataClass = JsonConvert.DeserializeObject<Logic.JsonDataClass>(_messageText);
            tbHash.Text = Logic.GetHash(Logic.H0, Logic.StringToIntArray(_jsonDataClass.text), _r).ToString();
            bool result = Logic.CheckSignature(_jsonDataClass, _e, _r);
            if (result)
                MessageBox.Show($"Содержимое файла не изменено");
            else
                MessageBox.Show($"Содержимое файла было изменено");
        }
    }
}