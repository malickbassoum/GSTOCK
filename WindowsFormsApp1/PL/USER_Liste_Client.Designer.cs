
namespace WindowsFormsApp1.PL
{
	partial class USER_Liste_Client
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnAjouterClient = new System.Windows.Forms.Button();
			this.btnModifierClient = new System.Windows.Forms.Button();
			this.btnSupprimerClient = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtRecherche = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.panel3 = new System.Windows.Forms.Panel();
			this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dvgClient = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dvgClient)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAjouterClient
			// 
			this.btnAjouterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.btnAjouterClient.FlatAppearance.BorderSize = 0;
			this.btnAjouterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouterClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAjouterClient.Image = global::WindowsFormsApp1.Properties.Resources.Actions_list_add_icon;
			this.btnAjouterClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAjouterClient.Location = new System.Drawing.Point(66, 37);
			this.btnAjouterClient.Name = "btnAjouterClient";
			this.btnAjouterClient.Size = new System.Drawing.Size(374, 66);
			this.btnAjouterClient.TabIndex = 0;
			this.btnAjouterClient.Text = "Ajouter";
			this.btnAjouterClient.UseVisualStyleBackColor = false;
			this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
			// 
			// btnModifierClient
			// 
			this.btnModifierClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnModifierClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.btnModifierClient.FlatAppearance.BorderSize = 0;
			this.btnModifierClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModifierClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModifierClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnModifierClient.Image = global::WindowsFormsApp1.Properties.Resources.Recycle_iconaaa;
			this.btnModifierClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModifierClient.Location = new System.Drawing.Point(615, 37);
			this.btnModifierClient.Name = "btnModifierClient";
			this.btnModifierClient.Size = new System.Drawing.Size(374, 66);
			this.btnModifierClient.TabIndex = 1;
			this.btnModifierClient.Text = "Modifier";
			this.btnModifierClient.UseVisualStyleBackColor = false;
			this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
			// 
			// btnSupprimerClient
			// 
			this.btnSupprimerClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSupprimerClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.btnSupprimerClient.FlatAppearance.BorderSize = 0;
			this.btnSupprimerClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSupprimerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSupprimerClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSupprimerClient.Image = global::WindowsFormsApp1.Properties.Resources.Close_2_icon;
			this.btnSupprimerClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSupprimerClient.Location = new System.Drawing.Point(1170, 37);
			this.btnSupprimerClient.Name = "btnSupprimerClient";
			this.btnSupprimerClient.Size = new System.Drawing.Size(374, 66);
			this.btnSupprimerClient.TabIndex = 2;
			this.btnSupprimerClient.Text = "Supprimer";
			this.btnSupprimerClient.UseVisualStyleBackColor = false;
			this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.panel1.Location = new System.Drawing.Point(66, 109);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1478, 5);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.panel2.Location = new System.Drawing.Point(66, 237);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1478, 5);
			this.panel2.TabIndex = 5;
			// 
			// txtRecherche
			// 
			this.txtRecherche.BackColor = System.Drawing.SystemColors.Control;
			this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRecherche.ForeColor = System.Drawing.Color.DimGray;
			this.txtRecherche.Location = new System.Drawing.Point(890, 148);
			this.txtRecherche.Multiline = true;
			this.txtRecherche.Name = "txtRecherche";
			this.txtRecherche.Size = new System.Drawing.Size(334, 45);
			this.txtRecherche.TabIndex = 6;
			this.txtRecherche.Text = "Rechercher";
			this.txtRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtRecherche.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			this.panel3.Location = new System.Drawing.Point(890, 198);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(334, 5);
			this.panel3.TabIndex = 7;
			// 
			// entityCommand1
			// 
			this.entityCommand1.CommandTimeout = 0;
			this.entityCommand1.CommandTree = null;
			this.entityCommand1.Connection = null;
			this.entityCommand1.EnablePlanCaching = true;
			this.entityCommand1.Transaction = null;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Telephone",
            "Email",
            "Ville",
            "Pays"});
			this.comboBox1.Location = new System.Drawing.Point(532, 182);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(272, 33);
			this.comboBox1.TabIndex = 8;
			// 
			// dvgClient
			// 
			this.dvgClient.AllowUserToAddRows = false;
			this.dvgClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dvgClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dvgClient.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dvgClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dvgClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dvgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column7});
			this.dvgClient.EnableHeadersVisualStyles = false;
			this.dvgClient.Location = new System.Drawing.Point(66, 249);
			this.dvgClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dvgClient.Name = "dvgClient";
			this.dvgClient.RowHeadersVisible = false;
			this.dvgClient.RowHeadersWidth = 62;
			this.dvgClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dvgClient.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dvgClient.Size = new System.Drawing.Size(1478, 809);
			this.dvgClient.TabIndex = 9;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "select";
			this.Column1.MinimumWidth = 8;
			this.Column1.Name = "Column1";
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Id";
			this.Column9.MinimumWidth = 8;
			this.Column9.Name = "Column9";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Nom";
			this.Column2.MinimumWidth = 8;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Prenom";
			this.Column3.MinimumWidth = 8;
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Adresse";
			this.Column4.MinimumWidth = 8;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Telephone";
			this.Column5.MinimumWidth = 8;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Email";
			this.Column8.MinimumWidth = 8;
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Ville";
			this.Column6.MinimumWidth = 8;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Pays";
			this.Column7.MinimumWidth = 8;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// USER_Liste_Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dvgClient);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.txtRecherche);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnSupprimerClient);
			this.Controls.Add(this.btnModifierClient);
			this.Controls.Add(this.btnAjouterClient);
			this.Name = "USER_Liste_Client";
			this.Size = new System.Drawing.Size(1706, 1080);
			this.Load += new System.EventHandler(this.USER_Liste_Client_Load);
			((System.ComponentModel.ISupportInitialize)(this.dvgClient)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAjouterClient;
		private System.Windows.Forms.Button btnModifierClient;
		private System.Windows.Forms.Button btnSupprimerClient;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtRecherche;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Panel panel3;
		private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView dvgClient;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
	}
}
