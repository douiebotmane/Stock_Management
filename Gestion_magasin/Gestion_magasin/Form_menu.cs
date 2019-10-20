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
    public partial class Form_menu : MetroFramework.Forms.MetroForm
    {
        public Form_menu()
        {
            InitializeComponent();
        }

        private void Form_menu_Load(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Form_acceuil obj_acceuil = new Form_acceuil();
            obj_acceuil.TopLevel = false;
            panel.Controls.Add(obj_acceuil);
            obj_acceuil.Show();
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel.Controls.Clear();
            Form_acceuil obj_acceuil = new Form_acceuil();
            obj_acceuil.TopLevel = false;
            panel.Controls.Add(obj_acceuil);
            obj_acceuil.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Form_about obj_about = new Form_about();
            obj_about.TopLevel = false;
            panel.Controls.Add(obj_about);
            obj_about.Show();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Form_acceuil obj_acceuil = new Form_acceuil();
            obj_acceuil.TopLevel = false;
            panel.Controls.Add(obj_acceuil);
            obj_acceuil.Show();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Button_circuit_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Form_allproduct obj_allproduct = new Form_allproduct();
            obj_allproduct.TopLevel = false;
            panel.Controls.Add(obj_allproduct);
            obj_allproduct.Show();
        }

        private void Button_ville_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Form_addproduct obj_addproduct = new Form_addproduct();
            obj_addproduct.TopLevel = false;
            panel.Controls.Add(obj_addproduct);
            obj_addproduct.Show();
        }

        private void Button_restaurant_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Form_deleteproduct obj_deleteproduct = new Form_deleteproduct();
            obj_deleteproduct.TopLevel = false;
            panel.Controls.Add(obj_deleteproduct);
            obj_deleteproduct.Show();
        }

        private void Button_hotel_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Form_editproduct obj_editproduct = new Form_editproduct();
            obj_editproduct.TopLevel = false;
            panel.Controls.Add(obj_editproduct);
            obj_editproduct.Show();
        }

        private void Button_accompagnateur_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Form_enterproduct obj_enterproduct = new Form_enterproduct();
            obj_enterproduct.TopLevel = false;
            panel.Controls.Add(obj_enterproduct);
            obj_enterproduct.Show();
        }

        private void Button_client_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Form_takeoutproduct obj_takeoutproduct = new Form_takeoutproduct();
            obj_takeoutproduct.TopLevel = false;
            panel.Controls.Add(obj_takeoutproduct);
            obj_takeoutproduct.Show();
        }

        private void Button_reservation_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Form_saveproduct obj_saveproduct = new Form_saveproduct();
            obj_saveproduct.TopLevel = false;
            panel.Controls.Add(obj_saveproduct);
            obj_saveproduct.Show();
        }
    }
}
