namespace ArtSchoolApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Text = "Художественная школа v0.1";

            // lblName & txtName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 50);
            this.lblName.Text = "ФИО ученика:";
            this.txtName.Location = new System.Drawing.Point(120, 47);
            this.txtName.Size = new System.Drawing.Size(250, 20);

            // lblAge & txtAge
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 80);
            this.lblAge.Text = "Возраст:";
            this.txtAge.Location = new System.Drawing.Point(120, 77);
            this.txtAge.Size = new System.Drawing.Size(100, 20);

            // lblCourse & txtCourse
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(12, 110);
            this.lblCourse.Text = "Название курса:";
            this.txtCourse.Location = new System.Drawing.Point(120, 107);
            this.txtCourse.Size = new System.Drawing.Size(250, 20);

            // Buttons
            this.btnAdd.Location = new System.Drawing.Point(12, 145);
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Text = "Добавить";

            this.btnDelete.Location = new System.Drawing.Point(120, 145);
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.Text = "Удалить";

            this.btnShowAll.Location = new System.Drawing.Point(280, 145);
            this.btnShowAll.Size = new System.Drawing.Size(90, 30);
            this.btnShowAll.Text = "Показать всех";

            // Search
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 190);
            this.lblSearch.Text = "Поиск по ФИО:";
            this.txtSearch.Location = new System.Drawing.Point(120, 187);
            this.txtSearch.Size = new System.Drawing.Size(150, 20);

            this.btnSearch.Location = new System.Drawing.Point(280, 185);
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.Text = "Найти";

            // ListBox
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(12, 225);
            this.lstStudents.Size = new System.Drawing.Size(358, 180);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 421);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstStudents);
            this.Name = "Form1";
            this.Text = "Художественная школа";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstStudents;
    }
}