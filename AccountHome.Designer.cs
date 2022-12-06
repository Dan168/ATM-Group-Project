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
            this.BtnWithdraw.Location = new System.Drawing.Point(19, 331);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(360, 41);
            this.BtnWithdraw.TabIndex = 6;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = true;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.Location = new System.Drawing.Point(19, 393);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(360, 41);
            this.BtnDeposit.TabIndex = 7;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.UseVisualStyleBackColor = true;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // BtnTrasnfer
            // 
            this.BtnTrasnfer.Location = new System.Drawing.Point(19, 458);
            this.BtnTrasnfer.Name = "BtnTrasnfer";
            this.BtnTrasnfer.Size = new System.Drawing.Size(360, 41);
            this.BtnTrasnfer.TabIndex = 8;
            this.BtnTrasnfer.Text = "Transfer";
            this.BtnTrasnfer.UseVisualStyleBackColor = true;
            this.BtnTrasnfer.Click += new System.EventHandler(this.BtnTrasnfer_Click);
            // 
            // AccountHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 547);
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
    }
}