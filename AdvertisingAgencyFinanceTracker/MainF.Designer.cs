namespace AdvertisingAgencyFinanceTracker
{
    partial class MainF
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
            this.proposalsWithClientsDGV = new System.Windows.Forms.DataGridView();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amoun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountInInvoice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsB = new System.Windows.Forms.Button();
            this.rollUpB = new System.Windows.Forms.Button();
            this.paymentsDGV = new System.Windows.Forms.DataGridView();
            this.playmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playmentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesDGV = new System.Windows.Forms.DataGridView();
            this.expenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.proposalsWithClientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // proposalsWithClientsDGV
            // 
            this.proposalsWithClientsDGV.AllowUserToAddRows = false;
            this.proposalsWithClientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proposalsWithClientsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyName,
            this.contactPerson,
            this.phoneNumber,
            this.date,
            this.amoun});
            this.proposalsWithClientsDGV.Location = new System.Drawing.Point(12, 12);
            this.proposalsWithClientsDGV.Name = "proposalsWithClientsDGV";
            this.proposalsWithClientsDGV.Size = new System.Drawing.Size(561, 126);
            this.proposalsWithClientsDGV.TabIndex = 0;
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Название компании";
            this.companyName.Name = "companyName";
            // 
            // contactPerson
            // 
            this.contactPerson.HeaderText = "Контактное лицо";
            this.contactPerson.Name = "contactPerson";
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Номер телефона";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            // 
            // amoun
            // 
            this.amoun.HeaderText = "Сумма";
            this.amoun.Name = "amoun";
            // 
            // amountInInvoice
            // 
            this.amountInInvoice.AutoSize = true;
            this.amountInInvoice.ForeColor = System.Drawing.SystemColors.Control;
            this.amountInInvoice.Location = new System.Drawing.Point(115, 281);
            this.amountInInvoice.Name = "amountInInvoice";
            this.amountInInvoice.Size = new System.Drawing.Size(13, 13);
            this.amountInInvoice.TabIndex = 1;
            this.amountInInvoice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Деньги на счете: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 126);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название компании";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Контактное лицо";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // paymentsB
            // 
            this.paymentsB.Location = new System.Drawing.Point(459, 276);
            this.paymentsB.Name = "paymentsB";
            this.paymentsB.Size = new System.Drawing.Size(114, 23);
            this.paymentsB.TabIndex = 4;
            this.paymentsB.Text = "Платежи/Расходы";
            this.paymentsB.UseVisualStyleBackColor = true;
            this.paymentsB.Click += new System.EventHandler(this.paymentsB_Click);
            // 
            // rollUpB
            // 
            this.rollUpB.Location = new System.Drawing.Point(998, 276);
            this.rollUpB.Name = "rollUpB";
            this.rollUpB.Size = new System.Drawing.Size(114, 23);
            this.rollUpB.TabIndex = 5;
            this.rollUpB.Text = "Свернуть";
            this.rollUpB.UseVisualStyleBackColor = true;
            this.rollUpB.Visible = false;
            this.rollUpB.Click += new System.EventHandler(this.rollUpB_Click);
            // 
            // paymentsDGV
            // 
            this.paymentsDGV.AllowUserToAddRows = false;
            this.paymentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playmentDate,
            this.playmentAmount});
            this.paymentsDGV.Location = new System.Drawing.Point(591, 12);
            this.paymentsDGV.Name = "paymentsDGV";
            this.paymentsDGV.Size = new System.Drawing.Size(250, 258);
            this.paymentsDGV.TabIndex = 6;
            // 
            // playmentDate
            // 
            this.playmentDate.HeaderText = "Дата платежа";
            this.playmentDate.Name = "playmentDate";
            // 
            // playmentAmount
            // 
            this.playmentAmount.HeaderText = "Сумма платежа";
            this.playmentAmount.Name = "playmentAmount";
            // 
            // expensesDGV
            // 
            this.expensesDGV.AllowUserToAddRows = false;
            this.expensesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expenseDate,
            this.expenseAmount});
            this.expensesDGV.Location = new System.Drawing.Point(862, 12);
            this.expensesDGV.Name = "expensesDGV";
            this.expensesDGV.Size = new System.Drawing.Size(250, 258);
            this.expensesDGV.TabIndex = 7;
            // 
            // expenseDate
            // 
            this.expenseDate.HeaderText = "Дата затраты";
            this.expenseDate.Name = "expenseDate";
            // 
            // expenseAmount
            // 
            this.expenseAmount.HeaderText = "Сумма затраты";
            this.expenseAmount.Name = "expenseAmount";
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1124, 309);
            this.Controls.Add(this.expensesDGV);
            this.Controls.Add(this.paymentsDGV);
            this.Controls.Add(this.rollUpB);
            this.Controls.Add(this.paymentsB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountInInvoice);
            this.Controls.Add(this.proposalsWithClientsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proposalsWithClientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView proposalsWithClientsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn amoun;
        private System.Windows.Forms.Label amountInInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button paymentsB;
        private System.Windows.Forms.Button rollUpB;
        private System.Windows.Forms.DataGridView paymentsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn playmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn playmentAmount;
        private System.Windows.Forms.DataGridView expensesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseAmount;
    }
}