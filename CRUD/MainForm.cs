using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            
            dataGrid.AutoGenerateColumns = false;
            this.RefreshGrid();


            

        }
        public void RefreshGrid(string selectCmd)
        {            
            DataTable dt = new DataTable();            

            //Executado um comando no banco de dados e retorna os dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectCmd, Db.connection);


            //Coloca os dados dentro da DataTable dt
            dataAdapter.Fill(dt);
          
            dataGrid.DataSource = dt;
        }
        public void RefreshGrid()
        {
            string cmd = "select * from people limit 10;";
            DataTable dt = new DataTable();            

            //Executado um comando no banco de dados e retorna os dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd, Db.connection);

            //Coloca os dados dentro da DataTable dt
            dataAdapter.Fill(dt);

            dataGrid.DataSource = dt;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            RegisterEditForm registerEditForm = new RegisterEditForm(this);
            registerEditForm.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string selectCmd = $"select * from people where person_name like '{ searchBox.Text }%'";
            RefreshGrid(selectCmd);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Int32 rowID = (Int32)dataGrid.Rows[e.RowIndex].Cells[0].Value;

                if (senderGrid.Columns[e.ColumnIndex] == EditBtn)
                {
                    RegisterEditForm regef = new RegisterEditForm(this, rowID);

                    regef.Show();
                    this.RefreshGrid();


                }
                else if(senderGrid.Columns[e.ColumnIndex] == RemoveBtn)
                {                    
                    DialogResult dialogResult = MessageBox.Show("This will delete the seleted row permanently, are you sure?", "Warning", MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        try {
                            MySqlCommand cmd = new MySqlCommand();
                            cmd.CommandText = $"DELETE FROM people WHERE person_id = { rowID }";
                            cmd.Connection = Db.connection;

                            cmd.ExecuteNonQuery();
                            this.RefreshGrid();

                        } catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }                       
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }            
        }
    }
}
