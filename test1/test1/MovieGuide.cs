using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace test1
{
    public partial class MovieGuide : Form
    {
        SqlConnection connection;
        string connectionstring;
        public MovieGuide()
        {
            connectionstring = ConfigurationManager.ConnectionStrings["test1.Properties.Settings.DataConnectionString1"].ConnectionString;
            InitializeComponent();
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {

           populatemovies();

        }
        public void populatemovies()
        {
            using (connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from movies", connection))
            {

                DataTable movies = new DataTable();
                adapter.Fill(movies);
                moviesh.DisplayMember = "Name";
                moviesh.ValueMember = "id";
                moviesh.DataSource = movies;
            }
        }


        public void populatecast()
        {
            string query = "SELECT a.Name FROM MovieCast a " +
                           "INNER JOIN MoviesMovieCast b ON a.Id = b.CastID " +
                          "WHERE b.MovieID = @movieid";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@movieid", moviesh.SelectedValue);
                DataTable starst = new DataTable();
                adapter.Fill(starst);
                starslb.DisplayMember = "Name";
                starslb.ValueMember = "id";
                starslb.DataSource = starst;
            }
        }
        public void populate()
        {
            string query = "SELECT a.Year FROM movies a " +
                " where a.Id = @movieid";
            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@movieid", moviesh.SelectedValue);
                DataTable starst = new DataTable();
                adapter.Fill(starst);
                listBox1.DisplayMember = "Year";
                listBox1.ValueMember = "id";
                listBox1.DataSource = starst;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          populatecast();
            starslb.Visible = true;
            populate();
            listBox1.Visible = true;
            label1.Visible = true;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addmovief add = new addmovief();
            add.ShowDialog();
        }
    }
}
