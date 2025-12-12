namespace C_Sharp_Assignment_6.Forms
{
    partial class AddPerson
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private TextBox txtPhone;
        private Button btnOK;
        private Button btnCancel;
        private Label lblName;
        private Label lblPhone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtPhone = new TextBox();
            this.btnOK = new Button();
            this.btnCancel = new Button();
            this.lblName = new Label();
            this.lblPhone = new Label();

            this.SuspendLayout();

            // lblName
            lblName.Text = "&Name:";
            lblName.Location = new Point(10, 10);

            // txtName
            txtName.Location = new Point(80, 10);
            txtName.Width = 200;

            // lblPhone
            lblPhone.Text = "&Phone:";
            lblPhone.Location = new Point(10, 40);

            // txtPhone
            txtPhone.Location = new Point(80, 40);
            txtPhone.Width = 200;

            // btnOK
            btnOK.Text = "OK";
            btnOK.Location = new Point(80, 80);
            btnOK.Click += btnOK_Click;

            // btnCancel
            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(160, 80);
            btnCancel.Click += btnCancel_Click;

            // Form setup
            this.ClientSize = new Size(300, 130);
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.Controls.Add(lblPhone);
            this.Controls.Add(txtPhone);
            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);
            this.Text = "Add Person";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.ResumeLayout(false);
        }
    }
}