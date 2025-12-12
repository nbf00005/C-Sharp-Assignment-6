using System;
using System.Windows.Forms;

namespace C_Sharp_Assignment_6
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.personBindingSource = new BindingSource(this.components);
            this.personDataGridView = new DataGridView();
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();

            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.btnSave = new Button();
            this.btnAdd = new Button();
            this.btnDelete = new Button();
            this.lblSearch = new Label();
            this.txtSearch = new TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();

            // personDataGridView
            this.personDataGridView.AutoGenerateColumns = false;
            this.personDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDataGridView.Columns.AddRange(new DataGridViewColumn[] {
                this.dataGridViewTextBoxColumn1,
                this.dataGridViewTextBoxColumn2,
                this.dataGridViewTextBoxColumn3
            });
            this.personDataGridView.DataSource = this.personBindingSource;
            this.personDataGridView.Location = new System.Drawing.Point(12, 40);
            this.personDataGridView.Name = "personDataGridView";
            this.personDataGridView.RowTemplate.Height = 24;
            this.personDataGridView.Size = new System.Drawing.Size(429, 220);

            // Columns
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;

            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";

            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone";

            // Labels and Textboxes
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 280);
            this.lblName.Text = "&Name";

            this.txtName.Location = new System.Drawing.Point(16, 300);
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.DataBindings.Add(new Binding("Text", this.personBindingSource, "Name", true));

            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(180, 280);
            this.lblPhone.Text = "&Phone";

            this.txtPhone.Location = new System.Drawing.Point(183, 300);
            this.txtPhone.Size = new System.Drawing.Size(150, 22);
            this.txtPhone.DataBindings.Add(new Binding("Text", this.personBindingSource, "Phone", true));

            // Buttons
            this.btnSave.Location = new System.Drawing.Point(360, 298);
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;

            this.btnAdd.Location = new System.Drawing.Point(450, 298);
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;

            this.btnDelete.Location = new System.Drawing.Point(540, 298);
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;

            // Search Label and TextBox
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 12);
            this.lblSearch.Text = "Search:";

            this.txtSearch.Location = new System.Drawing.Point(70, 10);
            this.txtSearch.Size = new System.Drawing.Size(150, 22);

            // Add controls
            this.Controls.Add(this.personDataGridView);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);

            // Form settings
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.Text = "Phone Book";
            this.Load += new EventHandler(this.MainForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private BindingSource personBindingSource;
        private DataGridView personDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Button btnSave;
        private Button btnAdd;
        private Button btnDelete;
        private Label lblSearch;
        private TextBox txtSearch;
    }
}
