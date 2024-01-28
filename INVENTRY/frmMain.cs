using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //Detail.Home home = new Detail.Home();

            //home.Hide();

            //AddUserControl(home);
        }

        public void AddUserControl(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

          
            Design.Dashbord dash= new Design.Dashbord();
            AddUserControl(dash);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Design.Cate cat = new Design.Cate();
            AddUserControl(cat);

             //  cat= new categ();

           // AddUserControl(cat);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Design.userTable userTable = new Design.userTable();

            AddUserControl(userTable);

                

          
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (historyDropDwn.SelectedIndex == 0 )
            {
                Design.SalersEmp sale = new Design.SalersEmp();
                AddUserControl(sale);

            }
            else if (historyDropDwn.SelectedIndex == 1)
            {
                Design.ProductSale proSoled = new Design.ProductSale();

                AddUserControl(proSoled);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            lg.Show();
            this.Hide();
        }

        private void panelControl_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            Design.Product pr = new Design.Product();
            AddUserControl(pr);
        }
    }
}
