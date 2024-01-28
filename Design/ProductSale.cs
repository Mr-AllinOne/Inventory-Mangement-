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
using System.Runtime.InteropServices;

namespace Shop.Design
{
    public partial class ProductSale : UserControl
    {
        public ProductSale()
        {
            InitializeComponent();
        }

        private void ProductSale_Load(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        SqlConnection Con = new SqlConnection("Data Source=AHmed;Initial Catalog=inventry;Integrated Security=True");

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
        private void History_Load(object sender, EventArgs e)
        {
            fetchDataHistory();
            fetchDataAllSales();
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

        private void searchA_TextChanged(object sender, EventArgs e)
        {
            fetchDataSpecificText2();
        }

        private void refreshA_Click(object sender, EventArgs e)
        {
            fetchDataAllSales();
            searchA.Text = "";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Forms f = new Forms();
            f.Show();
            await Task.Delay(500);
            this.Hide();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Attendants a = new Attendants();
            a.Show();
            await Task.Delay(500);
            this.Hide();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void History_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }




        private void AStable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AStable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fetchDataAllSales();
            fetchDataHistory();
            //fetchDataAllSales();
        }

        private void searchA_TextChanged_1(object sender, EventArgs e)
        {
            fetchDataSpecificText2();
        }

        private void refreshA_Click_1(object sender, EventArgs e)
        {
            fetchDataAllSales();
            searchA.Text = "";
        }
    }
}
