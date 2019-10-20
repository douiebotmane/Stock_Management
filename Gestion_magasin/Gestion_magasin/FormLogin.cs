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

namespace Gestion_magasin
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        static SqlConnection cnx = new SqlConnection("Data Source=ADMIN;Initial Catalog=stock_management;Integrated Security=True");
        static DataSet ds = new DataSet();
        static DataSet ds2 = new DataSet();
        static SqlDataAdapter da = new SqlDataAdapter("select * from connexion ", cnx);
        static SqlDataAdapter da2 = new SqlDataAdapter("select * from connexion_admin ", cnx);
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            da.Fill(ds, "connexion");

            ds2.Tables.Clear();
            da2.Fill(ds, "connexion_admin");
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Equals(ds.Tables["connexion"].Rows[0][0])) && (textBox2.Text.Equals(ds.Tables["connexion"].Rows[0][1])))
            {
                Form_menu objForm_menu = new Form_menu();
                this.Hide();
                objForm_menu.Show();
            }
            else if ((textBox1.Text.Equals(ds.Tables["connexion_admin"].Rows[0][0])) && (textBox2.Text.Equals(ds.Tables["connexion_admin"].Rows[0][1])))
            {
                Form_allproduct_superviseur objForm_allproduct_superviseur = new Form_allproduct_superviseur();
                this.Hide();
                objForm_allproduct_superviseur.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Otmane DOUIEB");
        }

        private void TextBox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
