
namespace Tour_Management_System
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.labelName = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfPersonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(237, 8);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Red;
            this.logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout.Location = new System.Drawing.Point(696, 8);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(94, 29);
            this.logout.TabIndex = 1;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.LocationColumn,
            this.StartingDateColumn,
            this.DurationColumn,
            this.NoOfPersonColumn});
            this.dataGridView1.Location = new System.Drawing.Point(3, 174);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(795, 273);
            this.dataGridView1.TabIndex = 25;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "id";
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Width = 50;
            // 
            // LocationColumn
            // 
            this.LocationColumn.DataPropertyName = "location";
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.MinimumWidth = 6;
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.Width = 150;
            // 
            // StartingDateColumn
            // 
            this.StartingDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StartingDateColumn.DataPropertyName = "startingdate";
            this.StartingDateColumn.HeaderText = "Starting Date";
            this.StartingDateColumn.MinimumWidth = 6;
            this.StartingDateColumn.Name = "StartingDateColumn";
            this.StartingDateColumn.Width = 200;
            // 
            // DurationColumn
            // 
            this.DurationColumn.DataPropertyName = "duration";
            this.DurationColumn.HeaderText = "Duration";
            this.DurationColumn.MinimumWidth = 6;
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.Width = 170;
            // 
            // NoOfPersonColumn
            // 
            this.NoOfPersonColumn.DataPropertyName = "noofperson";
            this.NoOfPersonColumn.HeaderText = "No. of Persons";
            this.NoOfPersonColumn.MinimumWidth = 6;
            this.NoOfPersonColumn.Name = "NoOfPersonColumn";
            this.NoOfPersonColumn.Width = 200;
            // 
            // adminn
            // 
            this.adminn.AutoSize = true;
            this.adminn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.adminn.Location = new System.Drawing.Point(528, 155);
            this.adminn.Name = "adminn";
            this.adminn.Size = new System.Drawing.Size(260, 15);
            this.adminn.TabIndex = 26;
            this.adminn.Text = "Contact admin to book tour admin@gmail.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.labelName);
            this.Name = "UserDashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartingDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfPersonColumn;
        private System.Windows.Forms.Label adminn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}