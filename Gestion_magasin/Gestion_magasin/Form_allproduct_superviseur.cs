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
    public partial class Form_allproduct_superviseur : MetroFramework.Forms.MetroForm
    {
        public Form_allproduct_superviseur()
        {
            InitializeComponent();
        }

        private void Form_allproduct_superviseur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stock_managementDataSet1.products'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.productsTableAdapter.Fill(this.stock_managementDataSet1.products);

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Feuil1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Liste Of Products";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            workbook.SaveAs("output.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
