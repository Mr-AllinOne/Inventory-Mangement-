using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shop
{
    public partial class LOGIN : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public LOGIN()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=AHmed;Initial Catalog=inventry;Integrated Security=True;");

        private async void loginbtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("\tMissing Credentials\t");
            }
            else
            {
                if (role.SelectedIndex > -1)
                {
                    if (role.SelectedItem.ToString() == "Admin")
                    {
                        if (username.Text == "admin" && password.Text == "123")
                        {
                            //Attendants att = new Attendants();
                            Loading l = new Loading();
                           // l.Show();
                            await Task.Delay(2000);
                            //att.Show();
                            this.Hide();
                            frmMain Main = new frmMain();
                          
                            Main.Show();

                            
                        }
                        else
                        {
                            MessageBox.Show("\tAdmin Credentials Wrong\t");
                        }
                    }
                    else
                    {
                        SqlDataAdapter sqa = new SqlDataAdapter("select count(*) from AttTable where AttName='" + username.Text + "' and Password='" + password.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sqa.Fill(dt);

                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            Globals.Set(username.Text);
                            SellingForm sf = new SellingForm();
                            Loading l = new Loading();
                            l.Show();
                            await Task.Delay(2000);
                            sf.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username/Password is Incorrect. Please Try Again");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("\tSelect A Role\t");
                }
            }
        }

        private void formside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
      /*  private void username_Enter_1(object sender, EventArgs e)
        {
            if (username.Text == "UserName")
            {
                username.Text = "";
                username.ForeColor = Color.Green;
            }


        }*/

     /*   private void username_Leave_1(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "UserName";
                username.ForeColor = Color.Green;
            }

        }

        private void LOGIN_Enter(object sender, EventArgs e)
        {
            if (password.Text == "password")
            {
                password.Text = "";
                password.ForeColor = Color.Green;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "password";
                password.ForeColor = Color.Green;
            }
        }*/

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public static class Globals
    {
        static String NameOfUser;

        internal static string Get()
        {
            return NameOfUser;
        }

        internal static void Set(string text)
        {
            NameOfUser = text;
        }
    }
}
