namespace Gestion_magasin
{
    partial class Form_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.LinkLabel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_restaurant = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button_ville = new System.Windows.Forms.Button();
            this.button_reservation = new System.Windows.Forms.Button();
            this.button_circuit = new System.Windows.Forms.Button();
            this.button_client = new System.Windows.Forms.Button();
            this.button_hotel = new System.Windows.Forms.Button();
            this.button_accompagnateur = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(314, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Stock Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(69, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 22;
            this.label1.TabStop = true;
            this.label1.Text = "Home";
            this.label1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Label1_LinkClicked);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_exit.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(0, 448);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(251, 58);
            this.button_exit.TabIndex = 12;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // button_restaurant
            // 
            this.button_restaurant.BackColor = System.Drawing.Color.Teal;
            this.button_restaurant.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.button_restaurant.ForeColor = System.Drawing.Color.White;
            this.button_restaurant.Location = new System.Drawing.Point(0, 112);
            this.button_restaurant.Name = "button_restaurant";
            this.button_restaurant.Size = new System.Drawing.Size(251, 58);
            this.button_restaurant.TabIndex = 13;
            this.button_restaurant.Text = "Delete Product";
            this.button_restaurant.UseVisualStyleBackColor = false;
            this.button_restaurant.Click += new System.EventHandler(this.Button_restaurant_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // button_ville
            // 
            this.button_ville.BackColor = System.Drawing.Color.Teal;
            this.button_ville.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.button_ville.ForeColor = System.Drawing.Color.White;
            this.button_ville.Location = new System.Drawing.Point(0, 56);
            this.button_ville.Name = "button_ville";
            this.button_ville.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_ville.Size = new System.Drawing.Size(251, 58);
            this.button_ville.TabIndex = 11;
            this.button_ville.Text = "Add New Product";
            this.button_ville.UseVisualStyleBackColor = false;
            this.button_ville.Click += new System.EventHandler(this.Button_ville_Click);
            // 
            // button_reservation
            // 
            this.button_reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_reservation.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.button_reservation.ForeColor = System.Drawing.Color.White;
            this.button_reservation.Location = new System.Drawing.Point(0, 392);
            this.button_reservation.Name = "button_reservation";
            this.button_reservation.Size = new System.Drawing.Size(251, 58);
            this.button_reservation.TabIndex = 18;
            this.button_reservation.Text = "Save All Products";
            this.button_reservation.UseVisualStyleBackColor = false;
            this.button_reservation.Click += new System.EventHandler(this.Button_reservation_Click);
            // 
            // button_circuit
            // 
            this.button_circuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_circuit.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.button_circuit.ForeColor = System.Drawing.Color.White;
            this.button_circuit.Location = new System.Drawing.Point(0, 336);
            this.button_circuit.Name = "button_circuit";
            this.button_circuit.Size = new System.Drawing.Size(251, 58);
            this.button_circuit.TabIndex = 17;
            this.button_circuit.Text = "See All Products";
            this.button_circuit.UseVisualStyleBackColor = false;
            this.button_circuit.Click += new System.EventHandler(this.Button_circuit_Click);
            // 
            // button_client
            // 
            this.button_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_client.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.button_client.ForeColor = System.Drawing.Color.White;
            this.button_client.Location = new System.Drawing.Point(0, 280);
            this.button_client.Name = "button_client";
            this.button_client.Size = new System.Drawing.Size(251, 58);
            this.button_client.TabIndex = 16;
            this.button_client.Text = "Take Out A Product";
            this.button_client.UseVisualStyleBackColor = false;
            this.button_client.Click += new System.EventHandler(this.Button_client_Click);
            // 
            // button_hotel
            // 
            this.button_hotel.BackColor = System.Drawing.Color.Teal;
            this.button_hotel.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.button_hotel.ForeColor = System.Drawing.Color.White;
            this.button_hotel.Location = new System.Drawing.Point(0, 168);
            this.button_hotel.Name = "button_hotel";
            this.button_hotel.Size = new System.Drawing.Size(251, 58);
            this.button_hotel.TabIndex = 14;
            this.button_hotel.Text = "Edit Product";
            this.button_hotel.UseVisualStyleBackColor = false;
            this.button_hotel.Click += new System.EventHandler(this.Button_hotel_Click);
            // 
            // button_accompagnateur
            // 
            this.button_accompagnateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_accompagnateur.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.button_accompagnateur.ForeColor = System.Drawing.Color.White;
            this.button_accompagnateur.Location = new System.Drawing.Point(0, 224);
            this.button_accompagnateur.Name = "button_accompagnateur";
            this.button_accompagnateur.Size = new System.Drawing.Size(251, 58);
            this.button_accompagnateur.TabIndex = 15;
            this.button_accompagnateur.Text = "Enter A Product";
            this.button_accompagnateur.UseVisualStyleBackColor = false;
            this.button_accompagnateur.Click += new System.EventHandler(this.Button_accompagnateur_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(251, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(750, 450);
            this.panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panel.TabIndex = 23;
            this.panel.TabStop = false;
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 506);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_restaurant);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button_ville);
            this.Controls.Add(this.button_reservation);
            this.Controls.Add(this.button_circuit);
            this.Controls.Add(this.button_client);
            this.Controls.Add(this.button_hotel);
            this.Controls.Add(this.button_accompagnateur);
            this.Name = "Form_menu";
            this.Load += new System.EventHandler(this.Form_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel label1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_restaurant;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button_ville;
        private System.Windows.Forms.Button button_reservation;
        private System.Windows.Forms.Button button_circuit;
        private System.Windows.Forms.Button button_client;
        private System.Windows.Forms.Button button_hotel;
        private System.Windows.Forms.Button button_accompagnateur;
        public System.Windows.Forms.PictureBox panel;
    }
}