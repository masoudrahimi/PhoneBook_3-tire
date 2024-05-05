namespace UI_winForm.Forms
{
    partial class frmMain
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
            dgvContacts = new DataGridView();
            txtSearchKey = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnDetail = new Button();
            btnAdd = new Button();
            btnEdite = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            SuspendLayout();
            // 
            // dgvContacts
            // 
            dgvContacts.AllowUserToAddRows = false;
            dgvContacts.AllowUserToDeleteRows = false;
            dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Dock = DockStyle.Bottom;
            dgvContacts.Location = new Point(0, 104);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.ReadOnly = true;
            dgvContacts.RowTemplate.Height = 25;
            dgvContacts.Size = new Size(582, 392);
            dgvContacts.TabIndex = 0;
            dgvContacts.DoubleClick += dgvContacts_DoubleClick;
            // 
            // txtSearchKey
            // 
            txtSearchKey.Location = new Point(15, 50);
            txtSearchKey.Name = "txtSearchKey";
            txtSearchKey.Size = new Size(555, 26);
            txtSearchKey.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(15, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 26);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(353, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 26);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "حذف مخاطب";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDetail
            // 
            btnDetail.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetail.Location = new Point(128, 12);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(105, 26);
            btnDetail.TabIndex = 4;
            btnDetail.Text = "نمایش جزئیات";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(242, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 26);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "افزودن مخاطب";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdite
            // 
            btnEdite.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdite.Location = new Point(463, 12);
            btnEdite.Name = "btnEdite";
            btnEdite.Size = new Size(107, 26);
            btnEdite.TabIndex = 6;
            btnEdite.Text = "ویرایش مخاطب";
            btnEdite.UseVisualStyleBackColor = true;
            btnEdite.Click += btnEdite_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 496);
            Controls.Add(btnEdite);
            Controls.Add(btnAdd);
            Controls.Add(btnDetail);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchKey);
            Controls.Add(dgvContacts);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "دفترچه تلفن";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Button btnSearch;
        private Button btnDelete;
        private Button btnDetail;
        private Button btnAdd;
        private Button btnEdite;
    }
}