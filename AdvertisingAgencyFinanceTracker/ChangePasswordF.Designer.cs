namespace AdvertisingAgencyFinanceTracker
{
    partial class ChangePasswordF
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
            this.changePassB = new System.Windows.Forms.Button();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.oldPassTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newPassTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // changePassB
            // 
            this.changePassB.Location = new System.Drawing.Point(100, 163);
            this.changePassB.Name = "changePassB";
            this.changePassB.Size = new System.Drawing.Size(75, 23);
            this.changePassB.TabIndex = 1;
            this.changePassB.Text = "Изменить";
            this.changePassB.UseVisualStyleBackColor = true;
            this.changePassB.Click += new System.EventHandler(this.changePassB_Click);
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(138, 41);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(100, 20);
            this.loginTB.TabIndex = 2;
            // 
            // oldPassTB
            // 
            this.oldPassTB.Location = new System.Drawing.Point(138, 82);
            this.oldPassTB.Name = "oldPassTB";
            this.oldPassTB.Size = new System.Drawing.Size(100, 20);
            this.oldPassTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Старый пароль";
            // 
            // newPassTB
            // 
            this.newPassTB.Location = new System.Drawing.Point(138, 116);
            this.newPassTB.Name = "newPassTB";
            this.newPassTB.Size = new System.Drawing.Size(100, 20);
            this.newPassTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Новый пароль";
            // 
            // ChangePasswordF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.newPassTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oldPassTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.changePassB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangePasswordF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changePassB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox oldPassTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPassTB;
        private System.Windows.Forms.Label label3;
    }
}