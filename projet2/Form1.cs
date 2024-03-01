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
namespace projet_Garage2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "Data Source=OLFAMHEDHBI\\SQLEXPRESS;Initial Catalog=Garage;Integrated Security=True;Encrypt=False";
                SqlConnection cn = new SqlConnection(connectionstring);
                cn.Open();
                if (cn.State != ConnectionState.Open)
                    MessageBox.Show("Connection echoué");
                else
                    MessageBox.Show("connection réssui");
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
