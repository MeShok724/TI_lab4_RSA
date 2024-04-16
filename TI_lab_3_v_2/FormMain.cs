using System;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TI_lab_3_v_2
{
    public partial class FormMain : Form
    {
        
        private byte[] _message;
        private byte[] _cipher;
        private short[] _message_short;
        private short[] _cipher_short;
        private bool is_cipher_short;
        private bool _isGDefine = false;
        private int _p;
        private int _g;
        private int _x;
        private int _k;
        private int _a;
        private int _b;
        private int _y;
        private int[] _primitiveFactors;
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnFindPrimitime_Click(object sender, EventArgs e)
        {
            int p = Logic.CheckPrime(tbP.Text);
            if (p == -1)
            {
                MessageBox.Show("P не является простым числом");
                return;
            }
            if (p < 255 || p > 65535)
            {
                MessageBox.Show("P должно быть > 255 и < 65535");
                return;
            }
            _p = p;
            _primitiveFactors = Logic.GetPrimitiveArray(_p);
            if (_primitiveFactors.Length < 1)
            {
                MessageBox.Show("Не удалось найти первообразные корни для p");
                return;
            }
            _isGDefine = true;
            cbG.Items.Clear();
            foreach (var i in _primitiveFactors)
            {
                cbG.Items.Add(i);
                cbG.SelectedIndex = 0;
            }

            lRootCount.Text = _primitiveFactors.Length.ToString();
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
            _message = System.IO.File.ReadAllBytes(filename);
            tbInput.Text = string.Join(", ", _message);
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
            if (is_cipher_short)
            {
                _cipher = Logic.ShortToByte(_cipher_short);
                System.IO.File.WriteAllBytes(filename, _cipher);
            }
            else
            {
                System.IO.File.WriteAllBytes(filename, _cipher);
            }
        }

        private void btnEncript_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            tbA.Text = "";
            tbB.Text = "";
            tbY.Text = "";
            if (!_isGDefine)
            {
                MessageBox.Show("Вы не выбрали первообразные корни для p");
                return;
            }
            if (!Logic.CheckX(tbX.Text, _p))
            {
                MessageBox.Show("Выбранный x не удовлетворяет условиям");
                return;
            }
            
            if (!Logic.CheckK(tbK.Text, _p))
            {
                MessageBox.Show("Выбранный k не удовлетворяет условиям");
                return;
            }

            if (_message == null || _message.Length == 0)
            {
                MessageBox.Show("Исходный файл не выбран");
                return;
            }
            _g = _primitiveFactors[cbG.SelectedIndex];
            _x = int.Parse(tbX.Text);
            _k = int.Parse(tbK.Text);
            _y = Logic.modPow(_g, _x, _p);
            tbY.Text = _y.ToString();
            
            
            _a = Logic.modPow(_g, _k,_p);
            byte currByte = _message[0];
            long curr1 = Logic.modPow(_y, _k, _p);
            long curr2 = curr1 * currByte;
            short b = (short)(curr2 % _p);
            _b = b;
            tbA.Text = _a.ToString();
            tbB.Text = _b.ToString();

            
            _cipher_short = Logic.EncryptData(_message, _p, _x, _k, _g, _y);
            is_cipher_short = true;
            
            tbResult.Text = $"{_cipher_short[0] + _cipher_short[1]}, ";
            tbResult.Text += string.Join(", ", _cipher_short);
            byte[] messageNew = Logic.DecryptData(_cipher_short, _p, _x);
            int a = messageNew.Length;
            // for (int i = 2; i < _cipher_short.Length; i += 2)
            // {
            //     tbResult.Text += $", {_cipher_short[i] + _cipher_short[i + 1]}";
            // }
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            int p = Logic.CheckPrime(tbP.Text);
            if (p == -1)
            {
                MessageBox.Show("P не является простым числом");
                return;
            }
            if (!Logic.CheckX(tbX.Text, p))
            {
                MessageBox.Show("Выбранный x не удовлетворяет условиям");
                return;
            }
            if (_message == null || _message.Length == 0)
            {
                MessageBox.Show("Исходный файл не выбран");
                return;
            }
            _p = p;
            _x = int.Parse(tbX.Text);
            _message_short = Logic.ByteToShort(_message);
            
            _cipher = Logic.DecryptData(_message_short, _p, _x);
            is_cipher_short = false;
            tbResult.Text = string.Join(", ", _cipher);
        }
        private void tbP_TextChanged(object sender, EventArgs e)
        {
            cbG.Items.Clear();
            lRootCount.Text = "";
            _isGDefine = false;
        }
    }
}