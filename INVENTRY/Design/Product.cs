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
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        
        }

        SqlConnection Con = new SqlConnection("Data Source=AHmed;Initial Catalog=inventry;Integrated Security=True");



        private void FetchCat()
        {

            try{
            Con.Open();
            String query = "select CatName from CatTable";
            SqlCommand command = new SqlCommand(query, Con);
            SqlDataReader read;
            read = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Columns.Add("CatName", typeof(string));
            data.Load(read);
            categoryS.ValueMember = "catName";
            categoryS.DataSource = data;
            Con.Close();
             }
              catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void FetchCat2()
        {
            try
            {
                Con.Open();
                String query = "select CatName from CatTable";
                SqlCommand command = new SqlCommand(query, Con);
                SqlDataReader read;
                read = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Columns.Add("CatName", typeof(string));
                data.Load(read);
                category.ValueMember = "catName";
                category.DataSource = data;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void fetchDataSpecificText()
        {
            Con.Open();
            string query = "select * from ProdTable where ProdName like '" + "%" + search.Text + "%" + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            prodList.DataSource = data.Tables[0];
            Con.Close();
        }

        private void fetchData()
        {
            Con.Open();
            string query = "select * from ProdTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            prodList.DataSource = data.Tables[0];
            Con.Close();
        }

        private void fetchDataSpecific()
        {
            Con.Open();
            string query = "select * from ProdTable where Category='" + category.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            prodList.DataSource = data.Tables[0];
            Con.Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            fetchDataSpecificText();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            fetchData();
        }

        private void prodList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodid.Text = prodList.SelectedRows[0].Cells[0].Value.ToString();
            prodname.Text = prodList.SelectedRows[0].Cells[1].Value.ToString();
            quantity.Text = prodList.SelectedRows[0].Cells[2].Value.ToString();
            price.Text = prodList.SelectedRows[0].Cells[3].Value.ToString();
            category.Text = prodList.SelectedRows[0].Cells[4].Value.ToString();
            tid.Text = prodList.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodname.Text == "" || quantity.Text == "" || price.Text == "" || category.Text == "")
                {
                    MessageBox.Show("Can't Add !\t\n Missing Info");
                }
                else
                {
                    Con.Open();
                    String query = "insert into ProdTable (ProdName, Quantity, Price, Category) values ('" + prodname.Text + "'," + quantity.Text + "," + price.Text + ",'" + category.Text + "')";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Added Successfully");
                    Con.Close();
                    prodid.Text = "";
                    prodname.Text = "";
                    quantity.Text = "";
                    price.Text = "";
                    tid.Text = "";
                    tqty.Text = "";
                    fetchData();
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodid.Text == "")
                {
                    MessageBox.Show("Product Not Selected \nPlease select the product to edit");
                }
                else
                {
                    Con.Open();
                    String query = "update ProdTable set ProdName='" + prodname.Text + "', Quantity=" + quantity.Text + ", Price=" + price.Text + ", Category='" + category.Text + "'where ProdID=" + prodid.Text + ";";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Edited Successfully");
                    Con.Close();
                    prodid.Text = "";
                    prodname.Text = "";
                    quantity.Text = "";
                    price.Text = "";
                    tid.Text = "";
                    tqty.Text = "";
                    fetchData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodid.Text == "")
                {
                    MessageBox.Show("Product Not Selected \nPlease select the Product to delete");
                }
                else
                {
                    Con.Open();
                    String query = "delete from ProdTable where ProdID=" + prodid.Text + "";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    Con.Close();
                    prodid.Text = "";
                    prodname.Text = "";
                    quantity.Text = "";
                    price.Text = "";
                    tid.Text = "";
                    tqty.Text = "";
                    fetchData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void categorySS_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Product_Load(object sender, EventArgs e)
        {
          
        }

        private void Product_Load_1(object sender, EventArgs e)
        {
            
          
            FetchCat();
            FetchCat2();
            fetchData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (tqty.Text == "" || tid.Text == "")
                {
                    MessageBox.Show("Missing Info");
                }
                else
                {
                    Con.Open();
                    String query = "update ProdTable set Quantity = Quantity+" + Convert.ToInt32(tqty.Text) + " where ProdID=" + tid.Text + ";";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Quantity Increased Successfully");
                    Con.Close();
                    prodid.Text = "";
                    prodname.Text = "";
                    quantity.Text = "";
                    price.Text = "";
                    tid.Text = "";
                    tqty.Text = "";
                    fetchData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }
    }
}
