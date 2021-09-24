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
		private dbStockContext db;
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
			db = new dbStockContext();
			//desactiver textbox de recherche
			txtRecherche.Enabled = false;

		}
		//Ajouter Datagridview
		public void Actualiserdatagrid()
		{
			db = new dbStockContext();
			dvgClient.Rows.Clear();//valider datagrid view
			foreach(var S in db.Clients)
			{
				//Ajouter les lignes dans datagrid
				dvgClient.Rows.Add(false, S.ID_Client,S.Nom_Client,S.Prenom_Client,S.Adresse_Client,S.Telephone_Client,S.Email_Client,S.Ville_Client,S.Pays_Client);
			}

		}

		// verifier combien de lignes est selectionnées
		public string SelectVerif()
		{
			int NombreLingneSelect = 0;

			for (int i=0;i<dvgClient.Rows.Count;i++)
			{
				if((bool)dvgClient.Rows[i].Cells[0].Value == true) //si la ligne est selectionnée
				{
					NombreLingneSelect++;
				}
			}if(NombreLingneSelect == 0)
			{
				return "Selectionnez le client à modifier";
			}
			if (NombreLingneSelect > 1)
			{
				return "Selectionnez un seul client à modifier";
			}
			return null;

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
			Actualiserdatagrid();

		}

		private void btnAjouterClient_Click(object sender, EventArgs e)
		{
			//Afficher le formulaire de saisie
			PL.FRM_Ajoute_Modifier_Client frmclient = new FRM_Ajoute_Modifier_Client(this);
			frmclient.ShowDialog();

		}
		
		private void btnModifierClient_Click(object sender, EventArgs e)
		{
			PL.FRM_Ajoute_Modifier_Client frmclient = new PL.FRM_Ajoute_Modifier_Client(this);
			if (SelectVerif()==null)
			{
				for (int i = 0;i<dvgClient.Rows.Count;i++)
				{
					if((bool)dvgClient.Rows[i].Cells[0].Value==true)//si le checkbox est vrai affichier les informations dans la faormulaire client
					{
						frmclient.IDselect = (int)dvgClient.Rows[i].Cells[1].Value;
						frmclient.txtNomClient.Text = dvgClient.Rows[i].Cells[2].Value.ToString();
						frmclient.txtPrenomClient.Text = dvgClient.Rows[i].Cells[3].Value.ToString();
						frmclient.txtAdresseClient.Text = dvgClient.Rows[i].Cells[4].Value.ToString();
						frmclient.textTelephoneClient.Text = dvgClient.Rows[i].Cells[5].Value.ToString();
						frmclient.txtEmailClient.Text = dvgClient.Rows[i].Cells[6].Value.ToString();
						frmclient.txtPaysClient.Text = dvgClient.Rows[i].Cells[7].Value.ToString();
						frmclient.txtVilleClient.Text = dvgClient.Rows[i].Cells[8].Value.ToString();

					}
				}
				frmclient.lblTitre.Text = "Modifier Client";
				frmclient.btnActualiser.Visible = false;
				frmclient.ShowDialog();
			}else
			{
				MessageBox.Show(SelectVerif(),"Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void btnSupprimerClient_Click(object sender, EventArgs e)
		{
			BL.CLS_Client cLS_Client = new BL.CLS_Client();
			//pour supprimer tout les clients selectionnée
			int select = 0;
			for(int i = 0; i<dvgClient.Rows.Count;i++)
			{
				if((bool)dvgClient.Rows[i].Cells[0].Value==true)
				{
					select++;// combien de lignes selectionnée
				}
			}
			if(select == 0)
			{
				MessageBox.Show("Aucun client selectionner", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				DialogResult R =
					MessageBox.Show("Voulez-vous vraiment supprimer", "supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if(R==DialogResult.Yes)
				{
					// pour supprimmer toute les clients selectionnée
					for (int i = 0; i < dvgClient.Rows.Count; i++)
					{
						if ((bool)dvgClient.Rows[i].Cells[0].Value == true)
						{
							cLS_Client.Supprimer_Client(int.Parse(dvgClient.Rows[i].Cells[1].Value.ToString()));// id client
						}
					}
					//Actualiser datagrid view
					Actualiserdatagrid();
					MessageBox.Show("Suppression avec succés", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					MessageBox.Show("Suppression est annulé", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void txtRecherche_TextChanged(object sender, EventArgs e)
		{
			db = new dbStockContext();
			var listerecherche = db.Clients.ToList(); // listerecher = liste client
			if(txtRecherche.Text!= "")// Pas vide
			{
				switch (comboRecherche.Text)
				{
					 
					case "Nom":
						listerecherche = listerecherche.Where(s =>s.Nom_Client.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
						//StringComparison.CurrentCultureIgnoreCase = soit j'ecris la lettre en majuscule ou en miniscule
						// != -1 existe dans la base de donnée
						break;
					case "Prenom":
						listerecherche = listerecherche.Where(s => s.Prenom_Client.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
						break;
					case "Telephone":
						listerecherche = listerecherche.Where(s => s.Telephone_Client.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
						break;
					case "Email":
						listerecherche = listerecherche.Where(s => s.Email_Client.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
						break;
					case "Pays":
						listerecherche = listerecherche.Where(s => s.Pays_Client.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
						break;
					case "Ville":
						listerecherche = listerecherche.Where(s => s.Ville_Client.IndexOf(txtRecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
						break;
				}
			}
			//vider data grid
			dvgClient.Rows.Clear();
			//ajouter listerecherche dans datagrid view client
			foreach(var l in listerecherche)
				{
				dvgClient.Rows.Add(false, l.ID_Client, l.Nom_Client, l.Prenom_Client, l.Adresse_Client, l.Email_Client, l.Pays_Client, l.Ville_Client);
				}
		}

		private void comboRecherche_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Activet le textbox recherche si j'ai choisie un champs
			txtRecherche.Enabled = true;
			txtRecherche.Text = ""; // vider le textbox de recherche

		}
	}
}
