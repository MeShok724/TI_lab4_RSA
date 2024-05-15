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
            this.tbQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbD = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbR = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lKey1
            // 
            this.lKey1.Location = new System.Drawing.Point(70, 41);
            this.lKey1.Name = "lKey1";
            this.lKey1.Size = new System.Drawing.Size(64, 33);
            this.lKey1.TabIndex = 2;
            this.lKey1.Text = "p:";
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(150, 34);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(420, 40);
            this.tbP.TabIndex = 3;
            this.tbP.Text = "17";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(54, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(703, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите файл для подписи или проверки:";
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
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(150, 93);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(420, 40);
            this.tbQ.TabIndex = 3;
            this.tbQ.Text = "19";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(70, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "d:";
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(150, 148);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(420, 40);
            this.tbD.TabIndex = 3;
            this.tbD.Text = "67";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(452, 733);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(305, 65);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(645, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Хэш:";
            // 
            // tbHash
            // 
            this.tbHash.Location = new System.Drawing.Point(772, 152);
            this.tbHash.Name = "tbHash";
            this.tbHash.ReadOnly = true;
            this.tbHash.Size = new System.Drawing.Size(262, 40);
            this.tbHash.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(688, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 33);
            this.label7.TabIndex = 2;
            this.label7.Text = "e:";
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(772, 34);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(262, 40);
            this.tbE.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(688, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 33);
            this.label8.TabIndex = 2;
            this.label8.Text = "r:";
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(772, 96);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(262, 40);
            this.tbR.TabIndex = 3;
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(54, 733);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(305, 65);
            this.btnSign.TabIndex = 9;
            this.btnSign.Text = "Подписать";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(70, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "q:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 831);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChoseFile);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.tbHash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbQ);
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

        private System.Windows.Forms.Button btnCheck;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbR;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbE;

        private System.Windows.Forms.Button btnSign;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbD;

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