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
    public partial class Form_deleteproduct : Form
    {
        static SqlConnection cnx = new SqlConnection("Data Source=ADMIN;Initial Catalog=stock_management;Integrated Security=True");
        static DataSet ds = new DataSet();
        static SqlDataAdapter da = new SqlDataAdapter("select * from products ", cnx);
        public Form_deleteproduct()
        {
            InitializeComponent();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables["products"].Rows.Count; i++)
            {
                if ((dataGridView1.Rows[i].Selected == true))
                {
                    ds.Tables["products"].Rows[i].Delete();
                    MessageBox.Show("Product is deleted");
                    button1.PerformClick();
                }
            }
        }

        private void Form_deleteproduct_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stock_managementDataSet2.products'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.productsTableAdapter.Fill(this.stock_managementDataSet2.products);

            ds.Tables.Clear();
            da.Fill(ds, "products");
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder b1 = new SqlCommandBuilder(da);
            da.Update(ds, "products");
            dataGridView1.DataSource = ds.Tables["products"];
        }
    }
}
