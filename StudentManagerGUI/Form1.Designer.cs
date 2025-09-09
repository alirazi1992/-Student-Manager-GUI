namespace StudentManagerGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblMajor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();

            // Labels
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Text = "Name:";

            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(20, 50);
            this.lblAge.Text = "Age:";

            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(20, 80);
            this.lblMajor.Text = "Major:";

            // Inputs
            this.txtName.Location = new System.Drawing.Point(80, 17);
            this.txtName.Size = new System.Drawing.Size(180, 20);

            this.txtAge.Location = new System.Drawing.Point(80, 47);
            this.txtAge.Size = new System.Drawing.Size(60, 20);

            this.txtMajor.Location = new System.Drawing.Point(80, 77);
            this.txtMajor.Size = new System.Drawing.Size(180, 20);

            // Buttons
            this.btnAdd.Location = new System.Drawing.Point(280, 15);
            this.btnAdd.Size = new System.Drawing.Size(80, 25);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(280, 45);
            this.btnUpdate.Size = new System.Drawing.Size(80, 25);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(280, 75);
            this.btnDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // DataGrid
            this.dgvStudents.Location = new System.Drawing.Point(20, 120);
            this.dgvStudents.Size = new System.Drawing.Size(500, 250);
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);

            // Form
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvStudents);
            this.Text = "Student Manager (Day 20)";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
