using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C_Sharp_Assignment_6.Forms
{
    public partial class AddPerson : Form
    {
        public string PersonName { get; set; }
        public string PersonPhone { get; set; }

        public AddPerson()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PersonName = txtName.Text;
            PersonPhone = txtPhone.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}