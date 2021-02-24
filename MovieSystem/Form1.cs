using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= "+Application.StartupPath+"\\MovieSystem.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand comm;
        private SqlDataAdapter adapt;

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerInsert_Click(object sender, EventArgs e)
        {
            
                con.Open();
                comm = new SqlCommand("insert into Customer values('" + CustomerID.Text + "','" + CustomerName.Text + "','" + CustomerLastName.Text + "','" + CustomerAddress.Text + "','" + CustomerPhone.Text + "')", con);
                try
                {
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Customer Saved");
                    con.Close();
                    ShowcustRecord();
                    CustomerID.Clear();
                    CustomerName.Clear();
                    CustomerLastName.Clear();
                    CustomerAddress.Clear();
                    CustomerPhone.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Customer Not Saved");
                }
                finally
                {
                    con.Close();
                } 
        }


        private void Form1_Load(object sender, EventArgs e)
        {
             ShowcustRecord();
             ShowMoviesRecord();
            ShowRentalMoviesRecord();
        }
        public void ShowcustRecord()
        {
            try { 
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Customer", con);
            adapt.Fill(dt);
            datagridviewCustomer.DataSource = dt;
            con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void ShowMoviesRecord()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Movies", con);
            adapt.Fill(dt);
            dataGridViewMovie.DataSource = dt;
            con.Close();
        }

        public void ShowRentalMoviesRecord()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from RentalMovies", con);
            adapt.Fill(dt);
            dataGridViewRetalRecord.DataSource = dt;
            con.Close();
        }
       

        private void dataGridViewMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            comm = new SqlCommand("delete from Customer where CId = " + CustomerID.Text + " ", con);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted");
                con.Close();
                ShowcustRecord();
                CustomerID.Clear();
                CustomerName.Clear();
                CustomerLastName.Clear();
                CustomerAddress.Clear();
                CustomerPhone.Clear();
                CustomerID.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("Customer Not Deleted" + x.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            con.Open();
            comm = new SqlCommand("update Customer set CId= '" + CustomerID.Text + "', FName= '" + CustomerName.Text + "', LName='" + CustomerLastName.Text + "', CAddress='" + CustomerAddress.Text + "', CPhoneNo='" + CustomerPhone.Text + "' where CId = '" + CustomerID.Text+"'", con);  
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Customer Updated");
                con.Close();
                ShowcustRecord();
                CustomerID.Clear();
                CustomerName.Clear();
                CustomerLastName.Clear();
                CustomerAddress.Clear();
                CustomerPhone.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Customer Not Updated");
            }
            finally
            {
                con.Close();
            }
        }

        private void ShowAllMovies_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select RentalMoviesId, FName, LName, CAddress, MTitle, MCost, RentalDate, ReturnDate from RentalMovies JOIN Customer ON RentalMovies.CId = Customer.CId JOIN Movies ON Movies.MoviesId=RentalMovies.MoviesId", con);
            adapt.Fill(dt);
            dataGridViewRetalRecord.DataSource = dt;
            con.Close();
        }

        private void ShowRentalMovies_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select RentalMoviesId, FName, LName, CAddress, MTitle, MCost, RentalDate, ReturnDate from RentalMovies JOIN Customer ON RentalMovies.CId = Customer.CId JOIN Movies ON Movies.MoviesId=RentalMovies.MoviesId where RentalMovies.ReturnDate=''", con);
            adapt.Fill(dt);
            dataGridViewRetalRecord.DataSource = dt;
            con.Close();
        }

       

        private void IssueMovies_Click(object sender, EventArgs e)
        {
            con.Open();
            comm = new SqlCommand("insert into RentalMovies values('" + RentalMovieID.Text + "','" + RentalsMovieID.Text + "','" + RentalCustomerID.Text + "','" + RentalIssueDate.Text + "','" + RentalReturnDate.Text + "')", con);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Rental Movie Saved");
                con.Close();
                ShowRentalMoviesRecord();
                RentalMovieID.Clear();
                RentalCustomerID.Clear();
                RentalsMovieID.Clear();
                RentalIssueDate.Clear();
                RentalReturnDate.Clear();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Rental Movie Not Saved");
            }
            finally
            {
                con.Close();
            }
        }


        private void InsertMovie_Click(object sender, EventArgs e)
        {
            con.Open();
            comm = new SqlCommand("insert into Movies values('" + MoviesID.Text + "','" + MovieTitle.Text + "','" + MovieRating.Text + "','" + MovieCopies.Text + "','" + MovieGenre.Text + "', '" + MoviePlot.Text + "', '" + MovieCost.Text + "', '" + MovieReleaseDate.Text + "')", con);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Movie Saved");
                con.Close();
                ShowMoviesRecord();
                MoviesID.Clear();
                MovieTitle.Clear();
                MovieRating.Clear();
                MovieCopies.Clear();
                MovieGenre.Clear();
                MoviePlot.Clear();
                MovieCost.Clear();
                MovieReleaseDate.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Movie Not Saved");
            }
            finally
            {
                con.Close();
            }
        }

        private void UpdateMovie_Click(object sender, EventArgs e)
        {

            con.Open();
            comm = new SqlCommand("update Movies set MoviesId= '" + MoviesID.Text + "', MTitle= '" + MovieTitle.Text + "', MRating='" + MovieRating.Text + "', Mcopies='" + MovieCopies.Text + "', Mgenre='" + MovieGenre.Text + "', Mplot='" + MoviePlot.Text + "', MCost='" + MovieCost.Text + "', MRelaseDate='" + MovieReleaseDate.Text + "' where MoviesId = '" + MoviesID.Text + "'", con);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Movie Updated");
                con.Close();
                ShowMoviesRecord();
                MoviesID.Clear();
                MovieTitle.Clear();
                MovieRating.Clear();
                MovieCopies.Clear();
                MovieGenre.Clear();
                MoviePlot.Clear();
                MovieCost.Clear();
                MovieReleaseDate.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Movie Not Updated");
            }
            finally
            {
                con.Close();
            }

        }

        private void DeleteMovie_Click(object sender, EventArgs e)
        {
            con.Open();
            comm = new SqlCommand("delete from Movies where MoviesId = " + MoviesID.Text + " ", con);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Movie Deleted");
                con.Close();
                ShowMoviesRecord();
                MoviesID.Clear();
                MovieTitle.Clear();
                MovieRating.Clear();
                MovieCopies.Clear();
                MovieGenre.Clear();
                MoviePlot.Clear();
                MovieCost.Clear();
                MovieReleaseDate.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show("Movie Not Deleted" + x.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ReturnMovies_Click(object sender, EventArgs e)
        {
            con.Open();
            comm = new SqlCommand("update RentalMovies set ReturnDate= '" + RentalReturnDate.Text + "' where RentalMoviesId = '" + RentalMovieID.Text + "' ", con);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Movie Return");
                con.Close();
                ShowRentalMoviesRecord();
                RentalMovieID.Clear();
                RentalCustomerID.Clear();
                RentalsMovieID.Clear();
                RentalIssueDate.Clear();
                RentalReturnDate.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Movie Not Return");
            }
            finally
            {
                con.Close();
            }
        }

        private void ShowMostPopular_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Movies where MRating =(select max(MRating) from Movies)", con);
            adapt.Fill(dt);
            dataGridViewMovie.DataSource = dt;
            con.Close();
        }
    }
}
