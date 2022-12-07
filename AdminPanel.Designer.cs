namespace ATMForm
{
    partial class AdminPanel
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
            this.btnViewCust = new System.Windows.Forms.Button();
            this.btnChangeOD = new System.Windows.Forms.Button();
            this.btnUnlockCard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewCust
            // 
            this.btnViewCust.Location = new System.Drawing.Point(12, 12);
            this.btnViewCust.Name = "btnViewCust";
            this.btnViewCust.Size = new System.Drawing.Size(142, 23);
            this.btnViewCust.TabIndex = 0;
            this.btnViewCust.Text = "Look-up customer";
            this.btnViewCust.UseVisualStyleBackColor = true;
            this.btnViewCust.Click += new System.EventHandler(this.btnViewCust_Click);
            // 
            // btnChangeOD
            // 
            this.btnChangeOD.Location = new System.Drawing.Point(12, 41);
            this.btnChangeOD.Name = "btnChangeOD";
            this.btnChangeOD.Size = new System.Drawing.Size(142, 23);
            this.btnChangeOD.TabIndex = 1;
            this.btnChangeOD.Text = "Change overdraft limit";
            this.btnChangeOD.UseVisualStyleBackColor = true;
            this.btnChangeOD.Click += new System.EventHandler(this.btnChangeOD_Click);
            // 
            // btnUnlockCard
            // 
            this.btnUnlockCard.Location = new System.Drawing.Point(12, 70);
            this.btnUnlockCard.Name = "btnUnlockCard";
            this.btnUnlockCard.Size = new System.Drawing.Size(142, 23);
            this.btnUnlockCard.TabIndex = 2;
            this.btnUnlockCard.Text = "Unlock card";
            this.btnUnlockCard.UseVisualStyleBackColor = true;
            this.btnUnlockCard.Click += new System.EventHandler(this.btnUnlockCard_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create new account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 149);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUnlockCard);
            this.Controls.Add(this.btnChangeOD);
            this.Controls.Add(this.btnViewCust);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewCust;
        private System.Windows.Forms.Button btnChangeOD;
        private System.Windows.Forms.Button btnUnlockCard;
        private System.Windows.Forms.Button button1;
    }
}