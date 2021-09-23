
namespace WindowsFormsApp1.PL
{
	partial class FRM_Ajoute_Modifier_Client
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblTitre = new System.Windows.Forms.Label();
			this.txtNomClient = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txtPrenomClient = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.txtAdresseClient = new System.Windows.Forms.TextBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.textTelephoneClient = new System.Windows.Forms.TextBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.panel10 = new System.Windows.Forms.Panel();
			this.txtEmailClient = new System.Windows.Forms.TextBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.panel11 = new System.Windows.Forms.Panel();
			this.txtPaysClient = new System.Windows.Forms.TextBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.panel12 = new System.Windows.Forms.Panel();
			this.txtVilleClient = new System.Windows.Forms.TextBox();
			this.btnActualiser = new System.Windows.Forms.Button();
			this.btnEnregistrer = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(692, 3);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(689, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(3, 514);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(3, 514);
			this.panel3.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(3, 514);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(686, 3);
			this.panel4.TabIndex = 3;
			// 
			// lblTitre
			// 
			this.lblTitre.AutoSize = true;
			this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblTitre.Location = new System.Drawing.Point(174, 26);
			this.lblTitre.Name = "lblTitre";
			this.lblTitre.Size = new System.Drawing.Size(247, 33);
			this.lblTitre.TabIndex = 4;
			this.lblTitre.Text = "Ajouter un Client";
			// 
			// txtNomClient
			// 
			this.txtNomClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.txtNomClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtNomClient.Location = new System.Drawing.Point(63, 119);
			this.txtNomClient.Multiline = true;
			this.txtNomClient.Name = "txtNomClient";
			this.txtNomClient.Size = new System.Drawing.Size(230, 27);
			this.txtNomClient.TabIndex = 5;
			this.txtNomClient.Text = "Nom Client";
			this.txtNomClient.Enter += new System.EventHandler(this.txtNomClient_Enter);
			this.txtNomClient.Leave += new System.EventHandler(this.txtNomClient_Leave);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.White;
			this.panel5.Location = new System.Drawing.Point(63, 152);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(230, 1);
			this.panel5.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.login_32;
			this.pictureBox1.Location = new System.Drawing.Point(21, 119);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(36, 34);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.login_32;
			this.pictureBox2.Location = new System.Drawing.Point(343, 119);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(36, 34);
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.Location = new System.Drawing.Point(385, 152);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(230, 1);
			this.panel6.TabIndex = 9;
			// 
			// txtPrenomClient
			// 
			this.txtPrenomClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.txtPrenomClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPrenomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrenomClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtPrenomClient.Location = new System.Drawing.Point(385, 119);
			this.txtPrenomClient.Multiline = true;
			this.txtPrenomClient.Name = "txtPrenomClient";
			this.txtPrenomClient.Size = new System.Drawing.Size(230, 27);
			this.txtPrenomClient.TabIndex = 8;
			this.txtPrenomClient.Text = "Prenom Client";
			this.txtPrenomClient.Enter += new System.EventHandler(this.txtPrenomClient_Enter);
			this.txtPrenomClient.Leave += new System.EventHandler(this.txtPrenomClient_Leave);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.adresse;
			this.pictureBox3.Location = new System.Drawing.Point(21, 242);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(36, 34);
			this.pictureBox3.TabIndex = 13;
			this.pictureBox3.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.White;
			this.panel7.Location = new System.Drawing.Point(63, 275);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(230, 1);
			this.panel7.TabIndex = 12;
			// 
			// txtAdresseClient
			// 
			this.txtAdresseClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.txtAdresseClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtAdresseClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAdresseClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtAdresseClient.Location = new System.Drawing.Point(63, 242);
			this.txtAdresseClient.Multiline = true;
			this.txtAdresseClient.Name = "txtAdresseClient";
			this.txtAdresseClient.Size = new System.Drawing.Size(230, 27);
			this.txtAdresseClient.TabIndex = 11;
			this.txtAdresseClient.Text = "Adresse Client";
			this.txtAdresseClient.Enter += new System.EventHandler(this.txtAdresseClient_Enter);
			this.txtAdresseClient.Leave += new System.EventHandler(this.txtAdresseClient_Leave);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Phone_32;
			this.pictureBox4.Location = new System.Drawing.Point(343, 194);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(36, 34);
			this.pictureBox4.TabIndex = 16;
			this.pictureBox4.TabStop = false;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.White;
			this.panel8.Location = new System.Drawing.Point(385, 227);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(230, 1);
			this.panel8.TabIndex = 15;
			// 
			// textTelephoneClient
			// 
			this.textTelephoneClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.textTelephoneClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textTelephoneClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textTelephoneClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.textTelephoneClient.Location = new System.Drawing.Point(385, 194);
			this.textTelephoneClient.Multiline = true;
			this.textTelephoneClient.Name = "textTelephoneClient";
			this.textTelephoneClient.Size = new System.Drawing.Size(230, 27);
			this.textTelephoneClient.TabIndex = 14;
			this.textTelephoneClient.Text = "Telephone Client";
			this.textTelephoneClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelephoneClient_KeyPress);
			this.textTelephoneClient.Leave += new System.EventHandler(this.textTelephoneClient_Leave);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.Gmail_32;
			this.pictureBox6.Location = new System.Drawing.Point(343, 276);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(36, 34);
			this.pictureBox6.TabIndex = 22;
			this.pictureBox6.TabStop = false;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.White;
			this.panel10.Location = new System.Drawing.Point(385, 309);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(230, 1);
			this.panel10.TabIndex = 21;
			// 
			// txtEmailClient
			// 
			this.txtEmailClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.txtEmailClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEmailClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmailClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtEmailClient.Location = new System.Drawing.Point(385, 276);
			this.txtEmailClient.Multiline = true;
			this.txtEmailClient.Name = "txtEmailClient";
			this.txtEmailClient.Size = new System.Drawing.Size(230, 27);
			this.txtEmailClient.TabIndex = 20;
			this.txtEmailClient.Text = "Email Client";
			this.txtEmailClient.Leave += new System.EventHandler(this.txtEmailClient_Leave);
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.Country_32;
			this.pictureBox7.Location = new System.Drawing.Point(21, 348);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(36, 34);
			this.pictureBox7.TabIndex = 25;
			this.pictureBox7.TabStop = false;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.White;
			this.panel11.Location = new System.Drawing.Point(63, 381);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(230, 1);
			this.panel11.TabIndex = 24;
			// 
			// txtPaysClient
			// 
			this.txtPaysClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.txtPaysClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPaysClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPaysClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtPaysClient.Location = new System.Drawing.Point(63, 348);
			this.txtPaysClient.Multiline = true;
			this.txtPaysClient.Name = "txtPaysClient";
			this.txtPaysClient.Size = new System.Drawing.Size(230, 27);
			this.txtPaysClient.TabIndex = 23;
			this.txtPaysClient.Text = "Pays Client";
			this.txtPaysClient.Leave += new System.EventHandler(this.txtPaysClient_Leave);
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = global::WindowsFormsApp1.Properties.Resources.ville_32;
			this.pictureBox8.Location = new System.Drawing.Point(343, 348);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(36, 34);
			this.pictureBox8.TabIndex = 28;
			this.pictureBox8.TabStop = false;
			// 
			// panel12
			// 
			this.panel12.BackColor = System.Drawing.Color.White;
			this.panel12.Location = new System.Drawing.Point(385, 381);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(230, 1);
			this.panel12.TabIndex = 27;
			// 
			// txtVilleClient
			// 
			this.txtVilleClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.txtVilleClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtVilleClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVilleClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtVilleClient.Location = new System.Drawing.Point(385, 348);
			this.txtVilleClient.Multiline = true;
			this.txtVilleClient.Name = "txtVilleClient";
			this.txtVilleClient.Size = new System.Drawing.Size(230, 27);
			this.txtVilleClient.TabIndex = 26;
			this.txtVilleClient.Text = "Ville Client";
			this.txtVilleClient.Enter += new System.EventHandler(this.txtVilleClient_Enter);
			this.txtVilleClient.Leave += new System.EventHandler(this.txtVilleClient_Leave);
			// 
			// btnActualiser
			// 
			this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.btnActualiser.FlatAppearance.BorderSize = 0;
			this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualiser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnActualiser.Location = new System.Drawing.Point(118, 439);
			this.btnActualiser.Name = "btnActualiser";
			this.btnActualiser.Size = new System.Drawing.Size(165, 35);
			this.btnActualiser.TabIndex = 29;
			this.btnActualiser.Text = "Actualiser";
			this.btnActualiser.UseVisualStyleBackColor = false;
			this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
			// 
			// btnEnregistrer
			// 
			this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.btnEnregistrer.FlatAppearance.BorderSize = 0;
			this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnEnregistrer.Location = new System.Drawing.Point(364, 439);
			this.btnEnregistrer.Name = "btnEnregistrer";
			this.btnEnregistrer.Size = new System.Drawing.Size(165, 35);
			this.btnEnregistrer.TabIndex = 30;
			this.btnEnregistrer.Text = "Enregistrer";
			this.btnEnregistrer.UseVisualStyleBackColor = false;
			this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::WindowsFormsApp1.Properties.Resources.Button_Delete_icon;
			this.btnClose.Location = new System.Drawing.Point(643, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(37, 30);
			this.btnClose.TabIndex = 31;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FRM_Ajoute_Modifier_Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.ClientSize = new System.Drawing.Size(692, 517);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnEnregistrer);
			this.Controls.Add(this.btnActualiser);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.panel12);
			this.Controls.Add(this.txtVilleClient);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.panel11);
			this.Controls.Add(this.txtPaysClient);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.panel10);
			this.Controls.Add(this.txtEmailClient);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.textTelephoneClient);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.txtAdresseClient);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.txtPrenomClient);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.txtNomClient);
			this.Controls.Add(this.lblTitre);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FRM_Ajoute_Modifier_Client";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FRM_Ajoute_Modifier_Client";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.Button btnEnregistrer;
		private System.Windows.Forms.Button btnClose;
		public System.Windows.Forms.Label lblTitre;
		public System.Windows.Forms.Button btnActualiser;
		public System.Windows.Forms.TextBox txtNomClient;
		public System.Windows.Forms.TextBox txtPrenomClient;
		public System.Windows.Forms.TextBox txtAdresseClient;
		public System.Windows.Forms.TextBox textTelephoneClient;
		public System.Windows.Forms.TextBox txtEmailClient;
		public System.Windows.Forms.TextBox txtPaysClient;
		public System.Windows.Forms.TextBox txtVilleClient;
	}
}