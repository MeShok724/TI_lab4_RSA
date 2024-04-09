using System.ComponentModel;

namespace TI_lab_3_v_2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lKey1 = new System.Windows.Forms.Label();
            this.tbP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.RichTextBox();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChoseFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbK = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbG = new System.Windows.Forms.ComboBox();
            this.btnFindPrimitime = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lKey1
            // 
            this.lKey1.Location = new System.Drawing.Point(79, 38);
            this.lKey1.Name = "lKey1";
            this.lKey1.Size = new System.Drawing.Size(205, 33);
            this.lKey1.TabIndex = 2;
            this.lKey1.Text = "Введите p:";
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(256, 38);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(420, 40);
            this.tbP.TabIndex = 3;
            this.tbP.TextChanged += new System.EventHandler(this.tbP_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(54, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(990, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите файл для шифровани/дешифрования:";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(54, 396);
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.Size = new System.Drawing.Size(703, 259);
            this.tbInput.TabIndex = 8;
            this.tbInput.Text = "";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(858, 396);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(703, 259);
            this.tbResult.TabIndex = 13;
            this.tbResult.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(858, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 45);
            this.label2.TabIndex = 12;
            this.label2.Text = "Результат:";
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.Location = new System.Drawing.Point(55, 306);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(387, 65);
            this.btnChoseFile.TabIndex = 14;
            this.btnChoseFile.Text = "Выбрать файл...";
            this.btnChoseFile.UseVisualStyleBackColor = true;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(858, 733);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(361, 65);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить в файл...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1313, 733);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(248, 65);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(79, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите x:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(256, 97);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(420, 40);
            this.tbX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(79, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите k:";
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(256, 152);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(420, 40);
            this.tbK.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(452, 733);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(305, 65);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Дешифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncript_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(695, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "Выберите g:";
            // 
            // cbG
            // 
            this.cbG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbG.FormattingEnabled = true;
            this.cbG.Location = new System.Drawing.Point(902, 150);
            this.cbG.Name = "cbG";
            this.cbG.Size = new System.Drawing.Size(273, 40);
            this.cbG.TabIndex = 17;
            // 
            // btnFindPrimitime
            // 
            this.btnFindPrimitime.Location = new System.Drawing.Point(736, 38);
            this.btnFindPrimitime.Name = "btnFindPrimitime";
            this.btnFindPrimitime.Size = new System.Drawing.Size(387, 65);
            this.btnFindPrimitime.TabIndex = 14;
            this.btnFindPrimitime.Text = "Рассчитать первообразные:";
            this.btnFindPrimitime.UseVisualStyleBackColor = true;
            this.btnFindPrimitime.Click += new System.EventHandler(this.btnFindPrimitime_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1235, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "a:";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(1287, 35);
            this.tbA.Name = "tbA";
            this.tbA.ReadOnly = true;
            this.tbA.Size = new System.Drawing.Size(262, 40);
            this.tbA.TabIndex = 3;
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRegister_KeyPress);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(1235, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 33);
            this.label7.TabIndex = 2;
            this.label7.Text = "b:";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(1287, 103);
            this.tbB.Name = "tbB";
            this.tbB.ReadOnly = true;
            this.tbB.Size = new System.Drawing.Size(262, 40);
            this.tbB.TabIndex = 3;
            this.tbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRegister_KeyPress);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(1235, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 33);
            this.label8.TabIndex = 2;
            this.label8.Text = "y:";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(1287, 175);
            this.tbY.Name = "tbY";
            this.tbY.ReadOnly = true;
            this.tbY.Size = new System.Drawing.Size(262, 40);
            this.tbY.TabIndex = 3;
            this.tbY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRegister_KeyPress);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(54, 733);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(305, 65);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Зашифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnEncript_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 831);
            this.Controls.Add(this.cbG);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFindPrimitime);
            this.Controls.Add(this.btnChoseFile);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.lKey1);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №3";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnDecrypt;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbY;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbB;

        private System.Windows.Forms.ComboBox cbG;
        private System.Windows.Forms.Button btnFindPrimitime;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button btnEncrypt;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbK;

        private System.Windows.Forms.TextBox tbP;

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Button btnChoseFile;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.RichTextBox tbResult;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.RichTextBox tbInput;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label lKey1;

        #endregion
    }
}