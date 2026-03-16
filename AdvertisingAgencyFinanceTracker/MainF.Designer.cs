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
            this.invoicesWithClentsDGV = new System.Windows.Forms.DataGridView();
            this.company_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsB = new System.Windows.Forms.Button();
            this.rollUpB = new System.Windows.Forms.Button();
            this.paymentsDGV = new System.Windows.Forms.DataGridView();
            this.playmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playmentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesDGV = new System.Windows.Forms.DataGridView();
            this.expenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.proposalsWithClientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesWithClentsDGV)).BeginInit();
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
            // invoicesWithClentsDGV
            // 
            this.invoicesWithClentsDGV.AllowUserToAddRows = false;
            this.invoicesWithClentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesWithClentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.company_name,
            this.contact_person,
            this.invoiceDate,
            this.invoiceAmount,
            this.invoiceStatus});
            this.invoicesWithClentsDGV.Location = new System.Drawing.Point(12, 144);
            this.invoicesWithClentsDGV.Name = "invoicesWithClentsDGV";
            this.invoicesWithClentsDGV.Size = new System.Drawing.Size(561, 126);
            this.invoicesWithClentsDGV.TabIndex = 3;
            // 
            // company_name
            // 
            this.company_name.HeaderText = "Название компании";
            this.company_name.Name = "company_name";
            // 
            // contact_person
            // 
            this.contact_person.HeaderText = "Контактное лицо";
            this.contact_person.Name = "contact_person";
            // 
            // invoiceDate
            // 
            this.invoiceDate.HeaderText = "Дата";
            this.invoiceDate.Name = "invoiceDate";
            // 
            // invoiceAmount
            // 
            this.invoiceAmount.HeaderText = "Сумма";
            this.invoiceAmount.Name = "invoiceAmount";
            // 
            // invoiceStatus
            // 
            this.invoiceStatus.HeaderText = "Статус";
            this.invoiceStatus.Name = "invoiceStatus";
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
            this.Controls.Add(this.invoicesWithClentsDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountInInvoice);
            this.Controls.Add(this.proposalsWithClientsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proposalsWithClientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesWithClentsDGV)).EndInit();
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
        private System.Windows.Forms.DataGridView invoicesWithClentsDGV;
        private System.Windows.Forms.Button paymentsB;
        private System.Windows.Forms.Button rollUpB;
        private System.Windows.Forms.DataGridView paymentsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn playmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn playmentAmount;
        private System.Windows.Forms.DataGridView expensesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_person;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceStatus;
    }
}