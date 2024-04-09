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
            _message = System.IO.File.ReadAllBytes(filename);
            tbInput.Text = string.Join(", ", _message);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Выберите файл для сохранения";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = fileDialog.FileName;
            System.IO.File.WriteAllBytes(filename, _cipher);
        }

        private void btnEncript_Click(object sender, EventArgs e)
        {
            if (!_isGDefine)
            {
                MessageBox.Show("Вы не выбрали первообразные корни для p");
                return;
            }
            _g = _primitiveFactors[cbG.SelectedIndex];
            tbResult.Text = "";
            tbA.Text = "";
            tbB.Text = "";
            tbY.Text = "";
            if (_message.Length == 0)
                return;
            if (!Logic.CheckX(tbX.Text, _p))
            {
                MessageBox.Show("Выбранный x не удовлетворяет условиям");
                return;
            }
            _x = int.Parse(tbX.Text);
            if (!Logic.CheckK(tbK.Text, _p))
            {
                MessageBox.Show("Выбранный k не удовлетворяет условиям");
                return;
            }
            _k = int.Parse(tbK.Text);
            _y = (int)Math.Pow(_g, _x) % _p;
            tbY.Text = _y.ToString();
            _a = (int)Math.Pow(_g, _k) % _p;
            byte currByte = _message[0];
            _b = (int)Math.Pow(_y, _k) * currByte % _p;
            tbA.Text = _a.ToString();
            tbB.Text = _b.ToString();
        }
        private bool CheckKeyInput(String key)
        {
            return true;
        }
        static BitArray ByteArrayToBitArray(byte[] byteArray)
        {
            // Создание BitArray с размером равным размеру массива байтов умноженному на 8
            BitArray bitArray = new BitArray(byteArray.Length * 8);

            // Итерация по каждому байту в массиве байтов
            for (int i = 0; i < byteArray.Length; i++)
            {
                byte b = byteArray[i];

                // Итерация по каждому биту в текущем байте
                for (int j = 0; j < 8; j++)
                {
                    // Установка значения бита в BitArray в зависимости от текущего бита в байте
                    bitArray[i * 8 + j] = (b & (1 << (7 - j))) != 0;
                }
            }
            return bitArray;
        }
        static byte[] BitArrayToByteArray(BitArray bitArray)
        {
            // Определение размера массива байтов
            int byteLength = (bitArray.Length + 7) / 8;
            byte[] byteArray = new byte[byteLength];

            // Прямой перебор элементов BitArray и формирование байтов
            for (int i = 0; i < bitArray.Length; i++)
            {
                int byteIndex = i / 8;  // Индекс байта в массиве байтов
                int bitIndex = i % 8;   // Индекс бита внутри байта

                // Устанавливаем соответствующий бит в текущем байте
                if (bitArray[i])
                {
                    byteArray[byteIndex] |= (byte)(1 << (7 - bitIndex));
                }
            }

            return byteArray;
        }
        static BitArray StringToBitArray(string binaryString)
        {
            BitArray bitArray = new BitArray(binaryString.Length);

            for (int i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[i] == '1')
                {
                    bitArray[i] = true;
                }
                else if (binaryString[i] == '0')
                {
                    bitArray[i] = false;
                }
            }
            return bitArray;
        }
        
        private static bool ShiftRegister(BitArray bitArray)
        {
            bool result = bitArray[0];
            bool newBit = bitArray[0] ^ bitArray[32] ^ bitArray[33] ^ bitArray[37];
            // Сдвиг влево
            for (int j = 0; j < bitArray.Length - 1; j++)
            {
                bitArray[j] = bitArray[j + 1];
            }

            // Вставка нового бита в правую ячейку
            bitArray[bitArray.Length - 1] = newBit;

            return result;
        }

        private BitArray EncryptData(BitArray message, BitArray register)
        {
            BitArray registerCopy = new BitArray(register);
            BitArray result = new BitArray(message.Length);
            for (int i = 0; i < message.Length; i++)
            {
                bool curr = ShiftRegister(registerCopy);
                result[i] = message[i] ^ curr;
                
            }
            return result;
        }

        private void tbRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar == '0' || e.KeyChar == '1') && tbP.Text.Length < 1) || Char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }


        private void tbP_TextChanged(object sender, EventArgs e)
        {
            cbG.Items.Clear();
            _isGDefine = false;
        }
    }
}