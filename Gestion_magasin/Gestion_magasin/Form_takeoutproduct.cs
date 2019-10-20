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
    public partial class Form_takeoutproduct : Form
    {
        static SqlConnection cnx = new SqlConnection("Data Source=ADMIN;Initial Catalog=stock_management;Integrated Security=True");
        static DataSet ds = new DataSet();
        static SqlDataAdapter da = new SqlDataAdapter("select * from products ", cnx);
        public Form_takeoutproduct()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_takeoutproduct_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da_com = new SqlDataAdapter("select products.name from products", cnx);
            DataTable dtt = new DataTable();
            da_com.Fill(dtt);
            for (int i = 0; i < dtt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dtt.Rows[i]["name"].ToString());
            }

            ds.Tables.Clear();
            da.Fill(ds, "products");
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da_qu = new SqlDataAdapter("select products.quantity_total from products", cnx);
            DataTable dtt = new DataTable();
            da_qu.Fill(dtt);

            if ((int) dtt.Rows[0]["quantity_total"] - int.Parse(textBox1.Text) > 0)
            {
                int index = comboBox1.FindString(comboBox1.Text);
                comboBox1.SelectedIndex = index;

                ds.Tables["products"].Rows[index][2] = (int)dtt.Rows[0]["quantity_total"] - int.Parse(textBox1.Text);
                MessageBox.Show("Quantity is decreased");
                button1.PerformClick();
                textBox1.Clear();
                comboBox1.Items.Clear();
                comboBox1.ResetText();
            }
            else
            {
                MessageBox.Show("The quantity available in the store for this product is " + (int)dtt.Rows[0]["quantity_total"]);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder b1 = new SqlCommandBuilder(da);
            da.Update(ds, "products");
        }
    }
}
