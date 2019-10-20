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
    public partial class Form_addproduct : Form
    {
        static SqlConnection cnx = new SqlConnection("Data Source=ADMIN;Initial Catalog=stock_management;Integrated Security=True");
        static DataSet ds = new DataSet();
        static SqlDataAdapter da = new SqlDataAdapter("select * from products ", cnx);
        public Form_addproduct()
        {
            InitializeComponent();
        }

        private void Form_addproduct_Load(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            da.Fill(ds, "products");
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DataRow ligne = ds.Tables["products"].NewRow();
            ligne[1] = textBox1.Text;
            ligne[2] = textBox2.Text;
            ligne[3] = textBox3.Text;
            ligne[4] = textBox4.Text;
            ds.Tables["products"].Rows.Add(ligne);
            MessageBox.Show("Product is added");
            button1.PerformClick();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder b1 = new SqlCommandBuilder(da);
            da.Update(ds, "products");
            //Form_allproduct.bunifuCustomDataGrid1.DataSource = ds.Tables["products"];
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
