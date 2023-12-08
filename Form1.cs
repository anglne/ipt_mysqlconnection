using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using adr.myclass;


namespace adr
{
    public partial class Form1 : Form
    {
        connection_class con = new connection_class();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                con.connectdb.Open();
                label1.Text = "Connected.";
                label1.ForeColor = Color.Green;
                con.connectdb.Close();
            }
            catch (Exception)
            {
                label1.Text = "Failed to Connect Database.";
            }
        }
    }
}