
namespace UI_winForm.Forms
{
    partial class frmAddContact
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            txtDescription = new TextBox();
            txtPhoneNumber = new TextBox();
            txtCompany = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            btnCancel = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 241);
            label5.Name = "label5";
            label5.Size = new Size(58, 18);
            label5.TabIndex = 22;
            label5.Text = "توضیحات";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 196);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 23;
            label4.Text = "شماره تلفن";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 144);
            label3.Name = "label3";
            label3.Size = new Size(41, 18);
            label3.TabIndex = 21;
            label3.Text = "شرکت";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 101);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 20;
            label2.Text = "نام خانوادگی";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(139, 9);
            label7.Name = "label7";
            label7.Size = new Size(152, 24);
            label7.TabIndex = 18;
            label7.Text = "افزودن مخاطب جدید";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 58);
            label1.Name = "label1";
            label1.Size = new Size(21, 18);
            label1.TabIndex = 19;
            label1.Text = "نام";
            // 
            // txtDescription
            // 
            txtDescription.AcceptsReturn = true;
            txtDescription.Location = new Point(125, 245);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(284, 99);
            txtDescription.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(125, 193);
            txtPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(284, 24);
            txtPhoneNumber.TabIndex = 16;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(125, 141);
            txtCompany.Margin = new Padding(4, 5, 4, 5);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(284, 24);
            txtCompany.TabIndex = 15;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(125, 98);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(284, 24);
            txtLastName.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.Location = new Point(125, 55);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 24);
            txtName.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(303, 357);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "برگشت";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(56, 357);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(230, 40);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "ثبت مخاطب جدید";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAddContact
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(436, 412);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCompany);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAddContact";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddContact";
            Load += frmAddContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}