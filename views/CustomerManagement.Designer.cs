namespace UserManagement
{
    partial class CustomerManagement
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
            listCustomers = new ListBox();
            btnSave = new Button();
            labelName = new Label();
            txtName = new TextBox();
            btnDelete = new Button();
            txtLastname = new TextBox();
            label1 = new Label();
            txtCelphone = new TextBox();
            label2 = new Label();
            txtCreditCard = new TextBox();
            label3 = new Label();
            btn_edit = new Button();
            lblStateActionCustomer = new Label();
            SuspendLayout();
            // 
            // listCustomers
            // 
            listCustomers.FormattingEnabled = true;
            listCustomers.Location = new Point(12, 12);
            listCustomers.Name = "listCustomers";
            listCustomers.Size = new Size(161, 214);
            listCustomers.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(293, 164);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(185, 38);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(268, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(144, 23);
            txtName.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(98, 232);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(268, 64);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(144, 23);
            txtLastname.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 67);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 5;
            label1.Text = "Lastname:";
            // 
            // txtCelphone
            // 
            txtCelphone.Location = new Point(268, 93);
            txtCelphone.Name = "txtCelphone";
            txtCelphone.Size = new Size(144, 23);
            txtCelphone.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 97);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Celphone:";
            // 
            // txtCreditCard
            // 
            txtCreditCard.Location = new Point(268, 122);
            txtCreditCard.Name = "txtCreditCard";
            txtCreditCard.Size = new Size(144, 23);
            txtCreditCard.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 126);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 9;
            label3.Text = "Credit card:";
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(12, 232);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 11;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // lblStateActionCustomer
            // 
            lblStateActionCustomer.AutoSize = true;
            lblStateActionCustomer.Location = new Point(293, 9);
            lblStateActionCustomer.Name = "lblStateActionCustomer";
            lblStateActionCustomer.Size = new Size(84, 15);
            lblStateActionCustomer.TabIndex = 12;
            lblStateActionCustomer.Text = "Add Customer";
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 315);
            Controls.Add(lblStateActionCustomer);
            Controls.Add(btn_edit);
            Controls.Add(txtCreditCard);
            Controls.Add(label3);
            Controls.Add(txtCelphone);
            Controls.Add(label2);
            Controls.Add(txtLastname);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(txtName);
            Controls.Add(labelName);
            Controls.Add(btnSave);
            Controls.Add(listCustomers);
            Name = "CustomerManagement";
            Text = "Form2";
            Load += CustomerManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listCustomers;
        private Button btnSave;
        private Label labelName;
        private TextBox txtName;
        private Button btnDelete;
        private TextBox txtLastname;
        private Label label1;
        private TextBox txtCelphone;
        private Label label2;
        private TextBox txtCreditCard;
        private Label label3;
        private Button btn_edit;
        private Label lblStateActionCustomer;
    }
}