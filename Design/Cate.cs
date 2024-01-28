using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Shop.Design
{
    public partial class Cate : UserControl
    {
        public Cate()
        {
            InitializeComponent();
            fetchCat();
            panelcontrols.Hide();
        }

        private void catname_TextChanged(object sender, EventArgs e)
        {

        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void fetchCat()
        {
            Con.Open();
            string query = "select * from CatTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            catList.DataSource = data.Tables[0];
            Con.Close();
        }

        SqlConnection Con = new SqlConnection("server=ABDIFATH\\SQLEXPRESS;database=inventry ;integrated security=true");
        private void cataddbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (catname.Text == "" || description.Text == "")
                {
                    MessageBox.Show("Can't Add !\t\n Missing Info");
                }
                else
                {
                    Con.Open();
                    String query = "insert into CatTable (CatName, Description) values ('" + catname.Text + "','" + description.Text + "')";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully");
                    Con.Close();
                    catid.Text = "";
                    catname.Text = "";
                    description.Text = "";
                    fetchCat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void cateditbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (catid.Text == "")
                {
                    MessageBox.Show("Category Not Selected \nPlease select the category to edit");
                }
                else
                {
                    Con.Open();
                    String query = "update CatTable set CatName='" + catname.Text + "', Description='" + description.Text + "'where CatID=" + catid.Text + ";";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Edited Successfully");
                    Con.Close();
                    catid.Text = "";
                    catname.Text = "";
                    description.Text = "";
                    fetchCat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void catdelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (catid.Text == "")
                {
                    MessageBox.Show("Product Not Selected \nPlease select the product to delete");
                }
                else
                {
                    Con.Open();
                    String query = "delete from CatTable where CatID=" + catid.Text + "";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    catid.Text = "";
                    catname.Text = "";
                    description.Text = "";
                    fetchCat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void catList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catid.Text = catList.SelectedRows[0].Cells[0].Value.ToString();
            catname.Text = catList.SelectedRows[0].Cells[1].Value.ToString();
            description.Text = catList.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        public FormWindowState WindowState { get; set; }

        private void button4_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            lg.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void catid_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           

        }
        public void AddUserControls(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            panelcontrols.Controls.Clear();
            panelcontrols.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
      

      /*  private void button1_Click(object sender, EventArgs e)
        {
            panelcontrols.Show();
            Design.popUp popBtn = new Design.popUp();
            AddUserControls(popBtn);
            //popBtn.Show();
          // popBtn.BringToFront();
            frmMain main = new frmMain();

          //  main.AddUserControl(popBtn);
        }*/

        private void panelcontrols_Paint(object sender, PaintEventArgs e)
        {
            // Design.popUp popBtn = new Design.popUp();
             //    if(popBtn.)
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (catname.Text == "" || description.Text == "")
                {
                    MessageBox.Show("Can't Add !\t\n Missing Info");
                }
                else
                {
                    Con.Open();
                    String query = "insert into CatTable (CatName, Description) values ('" + catname.Text + "','" + description.Text + "')";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully");
                    Con.Close();
                    catid.Text = "";
                    catname.Text = "";
                    description.Text = "";
                    fetchCat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelcontrols.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelcontrols.Show();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void catList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            catid.Text = catList.SelectedRows[0].Cells[0].Value.ToString();
            catname.Text = catList.SelectedRows[0].Cells[1].Value.ToString();
            description.Text = catList.SelectedRows[0].Cells[2].Value.ToString();
            panelcontrols.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           // panelcontrols.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          //  panelcontrols.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                if (catname.Text == "" || description.Text == "")
                {
                    MessageBox.Show("Can't Add !\t\n Missing Info");
                }
                else
                {
                    Con.Open();
                    String query = "insert into CatTable (CatName, Description) values ('" + catname.Text + "','" + description.Text + "')";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully");
                    Con.Close();
                    catid.Text = "";
                    catname.Text = "";
                    description.Text = "";
                    fetchCat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (catname.Text == "" || description.Text == "")
                {
                    MessageBox.Show("Can't Add !\t\n Missing Info");
                }
                else
                {
                    Con.Open();
                    String query = "insert into CatTable (CatName, Description) values ('" + catname.Text + "','" + description.Text + "')";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully");
                    Con.Close();
                    catid.Text = "";
                    catname.Text = "";
                    description.Text = "";
                    fetchCat();
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
                if (catid.Text == "")
                {
                    MessageBox.Show("Category Not Selected \nPlease select the category to edit");
                }
                else
                {
                    Con.Open();
                    String query = "update CatTable set CatName='" + catname.Text + "', Description='" + description.Text + "'where CatID=" + catid.Text + ";";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Edited Successfully");
                    Con.Close();
                    catid.Text = "";
                    catname.Text = "";
                    description.Text = "";
                    fetchCat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            panelcontrols.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                if (catid.Text == "")
                {
                    MessageBox.Show("Product Not Selected \nPlease select the product to delete");
                }
                else
                {
                    Con.Open();
                    String query = "delete from CatTable where CatID=" + catid.Text + "";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    catid.Text = "";
                    catname.Text = "";
                    description.Text = "";
                    fetchCat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            panelcontrols.Show();
            

            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
