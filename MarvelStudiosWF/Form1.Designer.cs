
namespace MarvelStudiosWF
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.textBox_director = new System.Windows.Forms.TextBox();
            this.textBox_budget = new System.Windows.Forms.TextBox();
            this.dateTimePicker_released = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.createMsg = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.genre,
            this.releasedDate,
            this.director,
            this.budget,
            this.Id});
            this.dataGridView1.Location = new System.Drawing.Point(35, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(878, 378);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Title";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(166, 25);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(237, 22);
            this.textBox_title.TabIndex = 2;
            // 
            // textBox_genre
            // 
            this.textBox_genre.Location = new System.Drawing.Point(166, 54);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(237, 22);
            this.textBox_genre.TabIndex = 3;
            // 
            // textBox_director
            // 
            this.textBox_director.Location = new System.Drawing.Point(521, 24);
            this.textBox_director.Name = "textBox_director";
            this.textBox_director.Size = new System.Drawing.Size(237, 22);
            this.textBox_director.TabIndex = 4;
            // 
            // textBox_budget
            // 
            this.textBox_budget.Location = new System.Drawing.Point(521, 51);
            this.textBox_budget.Name = "textBox_budget";
            this.textBox_budget.Size = new System.Drawing.Size(237, 22);
            this.textBox_budget.TabIndex = 5;
            // 
            // dateTimePicker_released
            // 
            this.dateTimePicker_released.Location = new System.Drawing.Point(166, 82);
            this.dateTimePicker_released.Name = "dateTimePicker_released";
            this.dateTimePicker_released.Size = new System.Drawing.Size(237, 22);
            this.dateTimePicker_released.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Released Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Director";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Budget";
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(460, 83);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(112, 38);
            this.button_Submit.TabIndex = 11;
            this.button_Submit.Text = "Save";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(326, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // createMsg
            // 
            this.createMsg.AutoSize = true;
            this.createMsg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMsg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createMsg.Location = new System.Drawing.Point(56, 151);
            this.createMsg.Name = "createMsg";
            this.createMsg.Size = new System.Drawing.Size(0, 29);
            this.createMsg.TabIndex = 13;
            // 
            // button_Update
            // 
            this.button_Update.Enabled = false;
            this.button_Update.Location = new System.Drawing.Point(578, 84);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(101, 37);
            this.button_Update.TabIndex = 14;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Enabled = false;
            this.button_Delete.Location = new System.Drawing.Point(685, 84);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(101, 37);
            this.button_Delete.TabIndex = 15;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // title
            // 
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 125;
            // 
            // genre
            // 
            this.genre.DataPropertyName = "Genre";
            this.genre.HeaderText = "Genre";
            this.genre.MinimumWidth = 6;
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            this.genre.Width = 125;
            // 
            // releasedDate
            // 
            this.releasedDate.DataPropertyName = "ReleasedDate";
            this.releasedDate.HeaderText = "Release Date";
            this.releasedDate.MinimumWidth = 6;
            this.releasedDate.Name = "releasedDate";
            this.releasedDate.ReadOnly = true;
            this.releasedDate.Width = 125;
            // 
            // director
            // 
            this.director.DataPropertyName = "Director";
            this.director.HeaderText = "Director";
            this.director.MinimumWidth = 6;
            this.director.Name = "director";
            this.director.ReadOnly = true;
            this.director.Width = 125;
            // 
            // budget
            // 
            this.budget.DataPropertyName = "Budget";
            this.budget.HeaderText = "Budget";
            this.budget.MinimumWidth = 6;
            this.budget.Name = "budget";
            this.budget.ReadOnly = true;
            this.budget.Width = 125;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 716);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.createMsg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_released);
            this.Controls.Add(this.textBox_budget);
            this.Controls.Add(this.textBox_director);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_genre;
        private System.Windows.Forms.TextBox textBox_director;
        private System.Windows.Forms.TextBox textBox_budget;
        private System.Windows.Forms.DateTimePicker dateTimePicker_released;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label createMsg;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn director;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

