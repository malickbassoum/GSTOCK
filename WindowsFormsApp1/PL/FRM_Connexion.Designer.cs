
namespace WindowsFormsApp1.PL
{
	partial class FRM_Connexion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Connexion));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnQuitter = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnSeConnecter = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(505, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(2, 572);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(505, 2);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 570);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(505, 2);
			this.panel3.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(2, 568);
			this.panel4.TabIndex = 3;
			// 
			// btnQuitter
			// 
			this.btnQuitter.FlatAppearance.BorderSize = 0;
			this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuitter.Image = global::WindowsFormsApp1.Properties.Resources.Button_Delete_icon;
			this.btnQuitter.Location = new System.Drawing.Point(440, 3);
			this.btnQuitter.Name = "btnQuitter";
			this.btnQuitter.Size = new System.Drawing.Size(64, 51);
			this.btnQuitter.TabIndex = 4;
			this.btnQuitter.UseVisualStyleBackColor = true;
			this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FloralWhite;
			this.label1.Location = new System.Drawing.Point(132, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 55);
			this.label1.TabIndex = 5;
			this.label1.Text = "Connexion";
			// 
			// textName
			// 
			this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textName.Location = new System.Drawing.Point(75, 245);
			this.textName.Multiline = true;
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(381, 38);
			this.textName.TabIndex = 6;
			this.textName.Text = "Nom Utilisateur";
			this.textName.Enter += new System.EventHandler(this.textName_Enter);
			this.textName.Leave += new System.EventHandler(this.textName_Leave);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.White;
			this.panel5.Location = new System.Drawing.Point(75, 285);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(410, 2);
			this.panel5.TabIndex = 7;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.Location = new System.Drawing.Point(75, 386);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(410, 2);
			this.panel6.TabIndex = 9;
			// 
			// textPassword
			// 
			this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textPassword.Location = new System.Drawing.Point(75, 340);
			this.textPassword.Multiline = true;
			this.textPassword.Name = "textPassword";
			this.textPassword.Size = new System.Drawing.Size(381, 38);
			this.textPassword.TabIndex = 8;
			this.textPassword.Text = "Mot de Passe";
			this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
			this.textPassword.Enter += new System.EventHandler(this.textPassword_Enter);
			this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.login_32;
			this.pictureBox1.Location = new System.Drawing.Point(16, 237);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(52, 46);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(16, 329);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(52, 58);
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// btnSeConnecter
			// 
			this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.btnSeConnecter.FlatAppearance.BorderSize = 0;
			this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeConnecter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSeConnecter.Location = new System.Drawing.Point(30, 429);
			this.btnSeConnecter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSeConnecter.Name = "btnSeConnecter";
			this.btnSeConnecter.Size = new System.Drawing.Size(454, 49);
			this.btnSeConnecter.TabIndex = 12;
			this.btnSeConnecter.Text = "Se Connecter";
			this.btnSeConnecter.UseVisualStyleBackColor = false;
			this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
			// 
			// FRM_Connexion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.ClientSize = new System.Drawing.Size(507, 572);
			this.Controls.Add(this.btnSeConnecter);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.textPassword);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnQuitter);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FRM_Connexion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			this.Load += new System.EventHandler(this.FRM_Connexion_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnQuitter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnSeConnecter;
	}
}