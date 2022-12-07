namespace ATMForm
{
    partial class AccountHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleBalance = new System.Windows.Forms.Label();
            this.currentBalance = new System.Windows.Forms.Label();
            this.longBalance = new System.Windows.Forms.Label();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.BtnTrasnfer = new System.Windows.Forms.Button();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple account balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current account balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Long account balance";
            // 
            // simpleBalance
            // 
            this.simpleBalance.AutoSize = true;
            this.simpleBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleBalance.Location = new System.Drawing.Point(14, 46);
            this.simpleBalance.Name = "simpleBalance";
            this.simpleBalance.Size = new System.Drawing.Size(90, 25);
            this.simpleBalance.TabIndex = 3;
            this.simpleBalance.Text = "Balance";
            this.simpleBalance.Click += new System.EventHandler(this.simpleBalance_Click);
            // 
            // currentBalance
            // 
            this.currentBalance.AutoSize = true;
            this.currentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalance.Location = new System.Drawing.Point(14, 137);
            this.currentBalance.Name = "currentBalance";
            this.currentBalance.Size = new System.Drawing.Size(90, 25);
            this.currentBalance.TabIndex = 4;
            this.currentBalance.Text = "Balance";
            this.currentBalance.Click += new System.EventHandler(this.currentBalance_Click);
            // 
            // longBalance
            // 
            this.longBalance.AutoSize = true;
            this.longBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longBalance.Location = new System.Drawing.Point(14, 240);
            this.longBalance.Name = "longBalance";
            this.longBalance.Size = new System.Drawing.Size(90, 25);
            this.longBalance.TabIndex = 5;
            this.longBalance.Text = "Balance";
            this.longBalance.Click += new System.EventHandler(this.longBalance_Click);
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.Location = new System.Drawing.Point(428, 30);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(360, 41);
            this.BtnWithdraw.TabIndex = 6;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = true;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.Location = new System.Drawing.Point(428, 92);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(360, 41);
            this.BtnDeposit.TabIndex = 7;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.UseVisualStyleBackColor = true;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // BtnTrasnfer
            // 
            this.BtnTrasnfer.Location = new System.Drawing.Point(428, 157);
            this.BtnTrasnfer.Name = "BtnTrasnfer";
            this.BtnTrasnfer.Size = new System.Drawing.Size(360, 41);
            this.BtnTrasnfer.TabIndex = 8;
            this.BtnTrasnfer.Text = "Transfer";
            this.BtnTrasnfer.UseVisualStyleBackColor = true;
            this.BtnTrasnfer.Click += new System.EventHandler(this.BtnTrasnfer_Click);
            // 
            // pinBox
            // 
            this.pinBox.Location = new System.Drawing.Point(489, 338);
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(121, 20);
            this.pinBox.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(489, 373);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.Green;
            this.BtnConfirm.Location = new System.Drawing.Point(489, 462);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(121, 56);
            this.BtnConfirm.TabIndex = 24;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Red;
            this.BtnClear.Location = new System.Drawing.Point(489, 400);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(121, 56);
            this.BtnClear.TabIndex = 23;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(390, 462);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(62, 56);
            this.Btn9.TabIndex = 22;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(307, 462);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(62, 56);
            this.Btn8.TabIndex = 21;
            this.Btn8.Tag = "";
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(222, 462);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(62, 56);
            this.Btn7.TabIndex = 20;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(390, 400);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(62, 56);
            this.Btn6.TabIndex = 19;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(307, 400);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(62, 56);
            this.Btn5.TabIndex = 18;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(222, 400);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(62, 56);
            this.Btn4.TabIndex = 17;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(390, 338);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(62, 56);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(307, 338);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(62, 56);
            this.Btn2.TabIndex = 15;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(222, 338);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(62, 56);
            this.Btn1.TabIndex = 14;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(428, 224);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(360, 41);
            this.btnQuit.TabIndex = 27;
            this.btnQuit.Text = "Stop using machine";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // AccountHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pinBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnTrasnfer);
            this.Controls.Add(this.BtnDeposit);
            this.Controls.Add(this.BtnWithdraw);
            this.Controls.Add(this.longBalance);
            this.Controls.Add(this.currentBalance);
            this.Controls.Add(this.simpleBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountHome";
            this.Text = "AccountHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label simpleBalance;
        private System.Windows.Forms.Label currentBalance;
        private System.Windows.Forms.Label longBalance;
        private System.Windows.Forms.Button BtnWithdraw;
        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.Button BtnTrasnfer;
        private System.Windows.Forms.TextBox pinBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button btnQuit;
    }
}