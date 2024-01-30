using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite_Database_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public partial class AdressBokPerson
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckIfDsataExists();
        }

        private void CheckIfDsataExists()
        {
            if (!File.Exists("test.db"))
            {
                SQLiteConnection.CreateFile("Test.db");

                using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
                {
                    string commandstring = "CREATE TABLE Contacts(Name NVARCHAR(250), Email NVARCHAR(250), Phone NVARCHAR(250))";
                    using (SQLiteCommand cmd = new SQLiteCommand(commandstring, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                LoadContactDataGridView();
            }
        }

        private void LoadContactDataGridView()
        {
            ContactsDataGridView1.DataSource = GetDataFromDatabase();
            //ContactsDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ContactsDataGridView1.MultiSelect = false;
            ContactsDataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private DataTable GetDataFromDatabase()
        {
            DataTable dtContacts = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
            {
                string commandstring = "SELECT * FROM Contacts";
                using (SQLiteCommand cmd = new SQLiteCommand(commandstring, conn))
                {
                    conn.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    dtContacts.Load(reader);
                }
            }

            return dtContacts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
            {
                string commandstring = "INSERT INTO Contacts ([Name],[Email],[Phone]) VALUES (@Name,@Email,@Phone)";
                using (SQLiteCommand cmd = new SQLiteCommand(commandstring, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Name", Name_Text.Text);
                    cmd.Parameters.AddWithValue("@Email", Email_Text.Text);
                    cmd.Parameters.AddWithValue("@Phone", Phone_Text.Text);

                    cmd.ExecuteNonQuery();

                }

            }
            LoadContactDataGridView();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(Name_Text.Text == string.Empty && Email_Text.Text == string.Empty && Phone_Text.Text == string.Empty)
            {
                MessageBox.Show("Please fill out a field you would like to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(ContactsDataGridView1.SelectedRows.Count != 0)//ContactsDataGridView1.SelectedRows == null && ContactsDataGridView1.SelectedRows.Count == 0)
            {

                MessageBox.Show("Please select the cell (not row) you would like to update. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DataGridViewSelectedCellCollection selected_cell = ContactsDataGridView1.SelectedCells;
                //int selectedCellColumn = ContactsDataGridView1.SelectedCells[0].ColumnIndex;
                int row_selected = selected_cell[0].RowIndex;
                string columnheader = ContactsDataGridView1.Columns[selected_cell[0].ColumnIndex].HeaderText;
                using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
                {
                    string query = string.Empty;
                    if(Name_Text.Text != string.Empty  && columnheader == "Name")
                    {
                        query = "UPDATE Contacts SET Name = '" + Name_Text.Text.Trim() + "' WHERE Name = '" + selected_cell[0].Value +
                            "' and Email = '" + ContactsDataGridView1.Rows[row_selected].Cells[1].Value + "' and Phone = '"+ ContactsDataGridView1.Rows[row_selected].Cells[2].Value + "' ";
                        Name_Text.Text = "";
                    }
                    else if (Email_Text.Text != string.Empty && columnheader == "Email")
                    {
                        query = "UPDATE Contacts SET Email = '" + Email_Text.Text.Trim() + "' WHERE Name = '" + ContactsDataGridView1.Rows[row_selected].Cells[0].Value +
                            "' and Email = '" + selected_cell[0].Value + "' and Phone = '" + ContactsDataGridView1.Rows[row_selected].Cells[2].Value + "' ";
                        Email_Text.Text = "";

                        //query = "UPDATE Contacts SET '" + columnheader + "' = '" + Email_Text.Text.Trim() + "' ";//Do where clause for te other 2 columns
                    }
                    else if (Phone_Text.Text != string.Empty && columnheader == "Phone")
                    {
                        query = "UPDATE Contacts SET Phone = '" + Phone_Text.Text.Trim() + "' WHERE Name = '" + ContactsDataGridView1.Rows[row_selected].Cells[0].Value +
                            "' and Email = '" + ContactsDataGridView1.Rows[row_selected].Cells[1].Value + "' and Phone = '" + selected_cell[0].Value + "' ";
                        Phone_Text.Text = "";
                        //query = "UPDATE Contacts SET '" + columnheader + "' = '" + Phone_Text.Text.Trim() + "' ";
                    }
                    else
                    {
                        MessageBox.Show("Please fill in the correct field selected that you would like to update. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    //string query = "UPDATE Contacts SET Name = '" + Name_Text.Text.Trim() + "', Email = '" + Email_Text.Text.Trim() + "',Phone = '" + Phone_Text.Text.Trim() + "' WHERE Name = '" + row_table[0].Cells[0].Value + "' and Email = '" + row_table[0].Cells[1].Value + "' and Phone = '" + row_table[0].Cells[2].Value + "' ";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadContactDataGridView();
                    }
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(ContactsDataGridView1.SelectedRows.Count == 0) //ContactsDataGridView1.SelectedRows == null && ContactsDataGridView1.SelectedRows.Count ==0)//Name_Text.Text == string.Empty)
            {
                MessageBox.Show("Please select the row you would like to delete. ", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //string row_table = ContactsDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DataGridViewSelectedRowCollection row_table = ContactsDataGridView1.SelectedRows;
                using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
                {
                    string query = "DELETE FROM Contacts where Name = '" + row_table[0].Cells[0].Value + "' and Email = '" + row_table[0].Cells[1].Value + "' and Phone = '" + row_table[0].Cells[2].Value + "' ";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Deleted", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadContactDataGridView();
                    }
                }
            }
        }

        private void DeleteAllBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection conn = new SQLiteConnection(AppSetting.ConnectionString()))
                {
                    string query = "DELETE FROM Contacts";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("All data deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadContactDataGridView();
                    }
                }
            }
        }
    }
}
