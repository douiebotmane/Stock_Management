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
    public partial class Form_editproduct : Form
    {
        static SqlConnection cnx = new SqlConnection("Data Source=ADMIN;Initial Catalog=stock_management;Integrated Security=True");
        static DataSet ds = new DataSet();
        static SqlDataAdapter da = new SqlDataAdapter("select * from products ", cnx);
        public Form_editproduct()
        {
            InitializeComponent();
        }

        int indexRow;

        private void Form_editproduct_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stock_managementDataSet3.products'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.productsTableAdapter.Fill(this.stock_managementDataSet3.products);
            ds.Tables.Clear();
            da.Fill(ds, "products");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder b1 = new SqlCommandBuilder(da);
            da.Update(ds, "products");
            dataGridView1.DataSource = ds.Tables["products"];
        }

        private void ProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.stock_managementDataSet);

        }

        

        private void ProductsDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
            textBox4.Text = row.Cells[4].Value.ToString();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            
            bool test = false;
            for (int i = 0; i < ds.Tables["products"].Rows.Count; i++)
            {
                test = true;
                ds.Tables["products"].Rows[i][1] = textBox1.Text;
                ds.Tables["products"].Rows[i][2] = textBox2.Text;
                ds.Tables["products"].Rows[i][3] = textBox3.Text;
                ds.Tables["products"].Rows[i][4] = textBox4.Text;
                MessageBox.Show("Product is edited");
                button1.PerformClick();
                break;
            }
            if (test == false)
            {
                MessageBox.Show("Error, Product is not edited");
            }
        }
    }
}
