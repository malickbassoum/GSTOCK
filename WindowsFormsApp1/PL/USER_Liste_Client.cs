using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.PL
{
	public partial class USER_Liste_Client : UserControl
	{
		private static USER_Liste_Client UserClient;
		//créer un instance pour le usercontrole
		public static USER_Liste_Client Instance
		{
			get
			{
				if(UserClient==null)
				{
					UserClient = new USER_Liste_Client();
				}
				return UserClient;
			} 
		}
		public USER_Liste_Client()
		{
			InitializeComponent();
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			if(txtRecherche.Text=="Rechercher")
			{
				txtRecherche.Text = "";
				txtRecherche.ForeColor = Color.Black;
			}
		}

		private void USER_Liste_Client_Load(object sender, EventArgs e)
		{
			//Exemple d'ajout des lignes
			dvgClient.Rows.Add();
			dvgClient.Rows[0].Cells[1].Value = "DIOP";
			dvgClient.Rows[0].Cells[2].Value = "babacar";
			dvgClient.Rows[0].Cells[3].Value = "mbao";
			dvgClient.Rows[0].Cells[4].Value = "77777777";
			dvgClient.Rows[0].Cells[5].Value = "Dakar";
			dvgClient.Rows[0].Cells[6].Value = "senegal";

		}

		private void btnAjouterClient_Click(object sender, EventArgs e)
		{
			//Afficher le formulaire de saisie
			PL.FRM_Ajoute_Modifier_Client frmclient = new FRM_Ajoute_Modifier_Client();
			frmclient.ShowDialog();

		}
	}
}
