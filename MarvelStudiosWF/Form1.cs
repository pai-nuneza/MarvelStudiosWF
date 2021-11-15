using MarvelStudiosWF.Models;
using MarvelStudiosWF.Repository;
using System;
using System.Windows.Forms;

namespace MarvelStudiosWF
{
    public partial class Form1 : Form
    {
        MoviesRepository movieRepo = new MoviesRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FetchMovie();
        }

        private void FetchMovie()
        {
            dataGridView1.DataSource = new BindingSource()
                .DataSource = movieRepo.GetMovies();
        }

        private void CreateMovie(Movie movie)
        {
            if (movieRepo.UpdateMovie(movie)) {
                createMsg.Text = "Created successfully.";
                FetchMovie();
            }
                
        }

        private void UpdateMovie(Movie movie)
        {
            if (movieRepo.UpdateMovie(movie)) {
                createMsg.Text = "Updated successfully.";
                FetchMovie();
            }
                
        }

        private void DeleteMovie(int Id)
        {
            if (movieRepo.DeleteMovie(Id)) {
                createMsg.Text = "Deleted successfully.";
                FetchMovie();
            }
           
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie()
            {
                Title = textBox_title.Text,
                Genre = textBox_genre.Text,
                ReleasedDate = dateTimePicker_released.Value,
                Director = textBox_director.Text,
                Budget = Convert.ToDecimal(textBox_budget.Text),
            };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_title.Text = string.Empty;
            textBox_genre.Text = string.Empty;
            dateTimePicker_released.Text = string.Empty;
            textBox_director.Text = string.Empty;
            textBox_budget.Text = string.Empty;
            createMsg.Text = string.Empty;

            button_Submit.Enabled = true;
            button_Update.Enabled = false;
            button_Delete.Enabled = false;
        }

        int selectedId = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                textBox_title.Text = row.Cells["Title"].Value.ToString();
                textBox_genre.Text = row.Cells["Genre"].Value.ToString();
                dateTimePicker_released.Value = Convert.ToDateTime(row.Cells["ReleasedDate"].Value);
                textBox_director.Text = row.Cells["Director"].Value.ToString();
                textBox_budget.Text = row.Cells["Budget"].Value.ToString();

                button_Submit.Enabled = false;
                button_Update.Enabled = true;
                button_Delete.Enabled = true;
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie()
            {
                Id = selectedId,
                Title = textBox_title.Text,
                Genre = textBox_genre.Text,
                ReleasedDate = dateTimePicker_released.Value,
                Director = textBox_director.Text,
                Budget = Convert.ToDecimal(textBox_budget.Text),
            };

            UpdateMovie(movie);
           
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DeleteMovie(selectedId);
        }
    }
}
