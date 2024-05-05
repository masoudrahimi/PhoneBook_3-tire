
namespace UI_winForm.Forms
{
    partial class frmDetailContact
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblId = new Label();
            lblName = new Label();
            lblLastName = new Label();
            lblCompany = new Label();
            lblPhoneNumber = new Label();
            lblCreatetAt = new Label();
            lblDescription = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 0;
            label1.Text = "شناسه :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(29, 71);
            label2.Name = "label2";
            label2.Size = new Size(29, 18);
            label2.TabIndex = 1;
            label2.Text = "نام :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(29, 114);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 2;
            label3.Text = "نام خانوادگی:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(29, 159);
            label4.Name = "label4";
            label4.Size = new Size(49, 18);
            label4.TabIndex = 3;
            label4.Text = "شرکت :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(29, 201);
            label5.Name = "label5";
            label5.Size = new Size(66, 18);
            label5.TabIndex = 4;
            label5.Text = "شماره تلفن:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(29, 257);
            label6.Name = "label6";
            label6.Size = new Size(62, 18);
            label6.TabIndex = 5;
            label6.Text = "تاریخ ثبت:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(29, 303);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 6;
            label7.Text = "توضیحات:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.ForeColor = SystemColors.ButtonFace;
            lblId.Location = new Point(96, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 18);
            lblId.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = SystemColors.ButtonFace;
            lblName.Location = new Point(85, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 18);
            lblName.TabIndex = 8;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.ForeColor = SystemColors.ButtonFace;
            lblLastName.Location = new Point(128, 114);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(0, 18);
            lblLastName.TabIndex = 9;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompany.ForeColor = SystemColors.ButtonFace;
            lblCompany.Location = new Point(119, 159);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(0, 18);
            lblCompany.TabIndex = 10;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = SystemColors.ButtonFace;
            lblPhoneNumber.Location = new Point(128, 201);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(0, 18);
            lblPhoneNumber.TabIndex = 11;
            // 
            // lblCreatetAt
            // 
            lblCreatetAt.AutoSize = true;
            lblCreatetAt.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblCreatetAt.ForeColor = SystemColors.ButtonFace;
            lblCreatetAt.Location = new Point(126, 257);
            lblCreatetAt.Name = "lblCreatetAt";
            lblCreatetAt.Size = new Size(0, 18);
            lblCreatetAt.TabIndex = 12;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.ButtonFace;
            lblDescription.Location = new Point(128, 303);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 18);
            lblDescription.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(29, 403);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(256, 40);
            btnClose.TabIndex = 14;
            btnClose.Text = "برگشت";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmDetailContact
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(337, 455);
            Controls.Add(btnClose);
            Controls.Add(lblDescription);
            Controls.Add(lblCreatetAt);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblCompany);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmDetailContact";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmDetailContact";
            Load += frmDetailContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCreatetAt;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnClose;
    }
}