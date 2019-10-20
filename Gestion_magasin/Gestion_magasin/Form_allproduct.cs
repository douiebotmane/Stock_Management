using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_magasin
{
    public partial class Form_allproduct : Form
    {
        public Form_allproduct()
        {
            InitializeComponent();
        }

        private void Form_allproduct_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stock_managementDataSet.products'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.productsTableAdapter1.Fill(this.stock_managementDataSet.products);

        }

        private void BunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
