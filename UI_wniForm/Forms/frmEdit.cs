using BLL.Dto;
using BLL.Services;

namespace UI_winForm.Forms
{
    public partial class frmEdit : Form
    {
        private readonly ContactService contactService;
        private readonly int contactId;
        public frmEdit(int contactId)
        {
            InitializeComponent();
            contactService = new ContactService();
            this.contactId = contactId;
        }

        private void editContactDto_Load(object sender, EventArgs e)
        {
            var contact = contactService.GetContactDetatil(contactId);

            if (contact.IsSuccess == false)
            {
                MessageBox.Show(contact.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtName.Text = contact.Data.Name;
                txtLastName.Text = contact.Data.LastName;
                txtCompany.Text = contact.Data.Company;
                txtDescription.Text = contact.Data.Description;
                txtPhoneNumber.Text = contact.Data.PhoneNumber;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
           var result= contactService.EditContact(new EditContactDto
            {
                Company= txtCompany.Text,
                Description = txtDescription.Text,
                Id = contactId,
                LastName = txtLastName.Text,
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
            });
            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
