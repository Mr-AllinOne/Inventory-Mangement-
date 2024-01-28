using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Input;

namespace Shop.Design
{
    public partial class SalersEmp : UserControl
    {
        public SalersEmp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalersEmp_Load(object sender, EventArgs e)
        {}
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection("Data Source=AHmed;Initial Catalog=inventry;Integrated Security=True");

        private void fetchDataHistory()
        {
            Con.Open();
            string query = "select * from HistoryTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            SPPtable.DataSource = data.Tables[0];
            Con.Close();
        }

        private void fetchDataAllSales()
        {
            Con.Open();
            string query = "select * from AllSalesTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            AStable.DataSource = data.Tables[0];
            Con.Close();
        }

        private void History_Load(object sender, EventArgs e)
        {
            fetchDataHistory();
            fetchDataAllSales();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void fetchDataSpecificText()
        {
            Con.Open();
            string query = "select * from HistoryTable where AttName like '" + "%" + searchH.Text + "%" + "'" + "or" + " date like '" + "%" + searchH.Text + "%" + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            SPPtable.DataSource = data.Tables[0];
            Con.Close();
        }

       private void fetchDataSpecificText2()
        {
            Con.Open();
            string query = "select * from AllSalesTable where Date like '" + "%" + searchA.Text + "%" + "'" + "or" + " Name like '" + "%" + searchA.Text + "%" + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            AStable.DataSource = data.Tables[0];
            Con.Close();
        }


        private void description_TextChanged(object sender, EventArgs e)
        {
            fetchDataSpecificText();
        }

        private void searchA_TextChanged(object sender, EventArgs e)
        {
            //fetchDataSpecificText2();
        }

        private void refreshH_Click(object sender, EventArgs e)
        {
            fetchDataHistory();
            searchH.Text = "";
        }

        private void refreshA_Click(object sender, EventArgs e)
        {
            //fetchDataAllSales();
            //searchA.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private async void button1_Click(object sender, EventArgs e)
        {
            Forms f = new Forms();
            f.Show();
            await Task.Delay(500);
            this.Hide();
        }

        private void searchH_TextChanged(object sender, EventArgs e)
        {
            ///
        }

        private void SPPtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fetchDataHistory();
            fetchDataAllSales();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void refreshH_Click_1(object sender, EventArgs e)
        {
            fetchDataHistory();
            searchH.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        }
    }



