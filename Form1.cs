using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace StudentDatabaseProject
{
    public partial class Form1 : Form
    {
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }
        public int Student_Age { get; set; }
        public string Student_ContactNo { get; set; }
        public string Student_Gender { get; set; }

        private const string selectQuery = "select * from Student_Details";
        private const string insertQuery = "insert into Student_Details(StudentID,StudentName,StudentAge,StudentContact,Gender)values(@StudentID,@StudentName,@StudentAge,@StudentContact,@Gender)";
        private const string deleteQuery = "delete from Student_Details where StudentId = @StudentId";
        private const string searchQuery = "select * from Student_Details where StudentID = @StudentID";
        private const string updateQuery = "update Student_Details set StudentName = @StudentName,StudentAge = @StudentAge,StudentContact = @StudentContact where StudentID = @StudentId";
        public Form1()
        {
            InitializeComponent();
            refreshDataGridView();
        }

        // Refresh/Display DataGridView method
        private void refreshDataGridView()
        {
            // Making a connection to database
            sqlConnection = new SqlConnection(StudentDatabaseProject.Properties.Settings.Default.Student_DataConnectionString);
            //Opening the Connection
            sqlConnection.Open();

            //Select command to display data in the database
            sqlCommand = new SqlCommand(selectQuery, sqlConnection);
            //Reading the data in the database
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (sqlDataReader.Read())
            {
                //Displays Data in DataGridView
                dataGridView1.Rows.Add(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetInt32(2), sqlDataReader.GetString(3), sqlDataReader.GetString(4));
            }
        }

        //Insert table method
        private void insert()
        {
            if (studentNameTextBox.Text.Equals("") | studentNameTextBox.Text.Equals("") | contactNoTextBox.Text.Equals("") | genderComboBox.Text.Equals(""))
            {
                MessageBox.Show("Some TextBoxes are Empty!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Student_Id = Convert.ToInt32(studentIdTextBox.Text);
                Student_Name = studentNameTextBox.Text;
                Student_Age = Convert.ToInt32(ageNumericUpDown.Value);
                Student_ContactNo = contactNoTextBox.Text;
                Student_Gender = genderComboBox.Text;

                // Making a connection to database
                sqlConnection = new SqlConnection(StudentDatabaseProject.Properties.Settings.Default.Student_DataConnectionString);
                //Opening the Connection
                sqlConnection.Open();

                //Select command to insert data in the database
                sqlCommand = new SqlCommand(insertQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@StudentName", Student_Name);
                sqlCommand.Parameters.AddWithValue("@StudentID", Student_Id);
                sqlCommand.Parameters.AddWithValue("@StudentAge", Student_Age);
                sqlCommand.Parameters.AddWithValue("@StudentContact", Student_ContactNo);
                sqlCommand.Parameters.AddWithValue("@Gender", Student_Gender);

                int rows = sqlCommand.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Insertion Successful");
                else
                    MessageBox.Show("Insertion UnSuccessful");

                refreshDataGridView();
            }
        }

        //Update table method
        private void update()
        {
            Student_Id = Convert.ToInt32(studentIdTextBox.Text);
            Student_Name = studentNameTextBox.Text;
            Student_Age = Convert.ToInt32(ageNumericUpDown.Value);
            Student_ContactNo = contactNoTextBox.Text;
            Student_Gender = genderComboBox.Text;
            // Making a connection to database
            sqlConnection = new SqlConnection(StudentDatabaseProject.Properties.Settings.Default.Student_DataConnectionString);
            //Opening the Connection
            sqlConnection.Open();

            //Update query to update data in the database
            sqlCommand = new SqlCommand(updateQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@StudentName", Student_Name);
            sqlCommand.Parameters.AddWithValue("@StudentID", Student_Id);
            sqlCommand.Parameters.AddWithValue("@StudentAge", Student_Age);
            sqlCommand.Parameters.AddWithValue("@StudentContact", Student_ContactNo);

            int rows = sqlCommand.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Update Successful");
            else
                MessageBox.Show("Update UnSuccessful");


            refreshDataGridView();
        }

        //Delete Table method
        private void delete()
        {
            // Making a connection to database
            sqlConnection = new SqlConnection(StudentDatabaseProject.Properties.Settings.Default.Student_DataConnectionString);
            //Opening the Connection
            sqlConnection.Open();

            Student_Id = Convert.ToInt32(studentIdTextBox.Text);
            //Delete query to delete data in the database
            sqlCommand = new SqlCommand(deleteQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@StudentID", Student_Id);
            int rows = sqlCommand.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Delete Successful");
            else
                MessageBox.Show("Delete UnSuccessful");

            refreshDataGridView();
        }
        private void search()
        {
            // Making a connection to database
            sqlConnection = new SqlConnection(StudentDatabaseProject.Properties.Settings.Default.Student_DataConnectionString);
            //Opening the Connection
            sqlConnection.Open();

            Student_Id = Convert.ToInt32(searchTextBox.Text);
            //Search
            sqlCommand = new SqlCommand(searchQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@StudentId", Student_Id);
            int rows = sqlCommand.ExecuteNonQuery();
            if(rows>0)
            {
                MessageBox.Show("Search Successful");
            }
            else
                MessageBox.Show("Search UnSuccessful");
        }


        private void InsertButton_Click(object sender, EventArgs e) { insert();}
        private void updateButton_Click(object sender, EventArgs e) { update(); }
        private void deleteButton_Click(object sender, EventArgs e) { delete(); }
        private void searchButton_Click(object sender, EventArgs e) { search(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_DataDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_DataDataSet2.Student_Details);

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            studentIdTextBox.Text = studentNameTextBox.Text = contactNoTextBox.Text = "";
            ageNumericUpDown.Value = ageNumericUpDown.Minimum;
            genderComboBox.Text = "";
        }
    }
}
