using BLL.Dto;
using BLL.Services;
using System.Windows.Forms;

namespace UI_winForm.Forms
{
    public partial class frmMain : Form
    {
        private readonly ContactService contactService;
        public frmMain()
        {
            InitializeComponent();
            contactService = new ContactService();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            var listContact = contactService.GetContactLists();
            SettingGridView(listContact);

            this.Cursor = Cursors.Default;

        }

        private void SettingGridView(List<ContactListDto> listContact)
        {
            dgvContacts.DataSource = listContact;
            dgvContacts.Columns[0].HeaderText = "ردیف";
            dgvContacts.Columns[1].HeaderText = "نام";
            dgvContacts.Columns[2].HeaderText = "شماره تلفن";
            dgvContacts.Columns[3].HeaderText = "شرکت";

            dgvContacts.Columns[0].Width = 50;
            dgvContacts.Columns[1].Width = 150;
            dgvContacts.Columns[2].Width = 150;
        }

        private void ShowDetailes()
        {
            var Id = int.Parse(dgvContacts.CurrentRow.Cells[0].Value.ToString());
            frmDetailContact frmDetailContact = new frmDetailContact(Id);
            frmDetailContact.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            var listContacts = contactService.SearchContact(txtSearchKey.Text);
            SettingGridView(listContacts);
            this.Cursor = Cursors.Default;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(dgvContacts.CurrentRow.Cells[0].Value.ToString());
            var result = contactService.DeleteContact(Id);

            if (result.IsSuccess == true)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain_Load(null, null);
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            ShowDetailes();
        }

        private void dgvContacts_DoubleClick(object sender, EventArgs e)
        {
            ShowDetailes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddContact frmAddContact = new frmAddContact();
            frmAddContact.ShowDialog();
            frmMain_Load(null, null);
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(dgvContacts.CurrentRow.Cells[0].Value.ToString());

            frmEdit frmEdit = new frmEdit(Id);
            frmEdit.ShowDialog();
            frmMain_Load(null, null);
        }
    }
}
