using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace WindowsFormsApp1.PL
{
	public partial class FRM_Ajoute_Modifier_Client : Form
	{
		private UserControl usclient;
		public FRM_Ajoute_Modifier_Client(UserControl userC)
		{
			InitializeComponent();
			this.usclient = userC;
		}

		//les champs obligatoire
		string testobligatoire()
		{
			if(txtNomClient.Text=="" || txtNomClient.Text=="Nom Client")
			{
				return "entrer le nom du client";
			}
			if (txtPrenomClient.Text == "" || txtPrenomClient.Text == "Prenom Client")
			{
				return "entrer le Prenom du client";
			}
			if (textTelephoneClient.Text == "" || textTelephoneClient.Text == "Telephone Client")
			{
				return "entrer le numero tel du client";
			}
			if (txtVilleClient.Text == "" || txtVilleClient.Text == "Ville Client")
			{
				return "entrer le ville du client";
			}
			if (txtPaysClient.Text == "" || txtPaysClient.Text == "Pays Client")
			{
				return "entrer le pays du client";
			}
			if (txtEmailClient.Text == "" || txtEmailClient.Text == "Email Client")
			{
				return "entrer le mail du client du client";
			}
			if (txtAdresseClient.Text == "" || txtAdresseClient.Text == "Adresse Client")
			{
				return "entrer l'adresse du client du client";
			}
			//verifier email valide ou nom
			if(txtEmailClient.Text!=""|| txtEmailClient.Text!="Email Client")
			{
				try
				{
					new MailAddress(txtEmailClient.Text);
				}
				catch (Exception )
				{
					return "Email Invalide";
				}
			}
			return null;
		}

		private void txtNomClient_Enter(object sender, EventArgs e)
		{
			if(txtNomClient.Text=="Nom Client")
			{
				txtNomClient.Text = "";
				txtNomClient.ForeColor = Color.White;
			}
		}

		private void txtPrenomClient_Enter(object sender, EventArgs e)
		{
			if (txtPrenomClient.Text == "Prenom Client")
			{
				txtPrenomClient.Text = "";
				txtPrenomClient.ForeColor = Color.White;
			}
		}

		private void txtAdresseClient_Enter(object sender, EventArgs e)
		{
			if (txtAdresseClient.Text == "Prenom Client")
			{
				txtAdresseClient.Text = "";
				txtAdresseClient.ForeColor = Color.White;
			}
		}

		private void textTelephoneClient_Enter(object sender, EventArgs e)
		{
			if (textTelephoneClient.Text == "Prenom Client")
			{
				textTelephoneClient.Text = "";
				textTelephoneClient.ForeColor = Color.White;
			}
		}

		private void txtNomClient_Leave(object sender, EventArgs e)
		{
			if (txtNomClient.Text == "Nom Client")
			{
				txtNomClient.Text = "";
				txtNomClient.ForeColor = Color.Silver;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void txtPrenomClient_Leave(object sender, EventArgs e)
		{
			if (txtPrenomClient.Text == "Prenom Client")
			{
				txtPrenomClient.Text = "";
				txtPrenomClient.ForeColor = Color.Silver;
			}
		}

		private void txtAdresseClient_Leave(object sender, EventArgs e)
		{
			if (txtAdresseClient.Text == "Adresse Client")
			{
				txtAdresseClient.Text = "";
				txtAdresseClient.ForeColor = Color.Silver;
			}
		}

		private void textTelephoneClient_Leave(object sender, EventArgs e)
		{
			if (textTelephoneClient.Text == "Prenom Client")
			{
				textTelephoneClient.Text = "";
				textTelephoneClient.ForeColor = Color.Silver;
			}
		}

		private void txtEmailClient_Enter(object sender, EventArgs e)
		{
			if (txtEmailClient.Text == "Prenom Client")
			{
				txtEmailClient.Text = "";
				txtEmailClient.ForeColor = Color.White;
			}
		}

		private void txtPaysClient_Enter(object sender, EventArgs e)
		{
			if (txtPaysClient.Text == "Pays Client")
			{
				txtPaysClient.Text = "";
				txtPaysClient.ForeColor = Color.White;
			}
		}

		private void txtVilleClient_Enter(object sender, EventArgs e)
		{
			if (txtVilleClient.Text == "Pays Client")
			{
				txtVilleClient.Text = "";
				txtVilleClient.ForeColor = Color.White;
			}
		}

		private void txtVilleClient_Leave(object sender, EventArgs e)
		{
			if (txtVilleClient.Text == "Pays Client")
			{
				txtVilleClient.Text = "";
				txtVilleClient.ForeColor = Color.Silver;
			}
		}

		private void txtPaysClient_Leave(object sender, EventArgs e)
		{

			if (txtPaysClient.Text == "Pays Client")
			{
				txtPaysClient.Text = "";
				txtPaysClient.ForeColor = Color.Silver;
			}
		}

		private void txtEmailClient_Leave(object sender, EventArgs e)
		{

			if (txtEmailClient.Text == "Prenom Client")
			{
				txtEmailClient.Text = "";
				txtEmailClient.ForeColor = Color.Silver;
			}
		}

		private void textTelephoneClient_KeyPress(object sender, KeyPressEventArgs e)
		{
			// textbox numeric
			if(e.KeyChar<48 || e.KeyChar>57) //code asci des numero
			{
				e.Handled = true;
			}
			if (e.KeyChar == 8)
			{
				e.Handled = false;
			}
		}

		public int IDselect;

		private void btnEnregistrer_Click(object sender, EventArgs e)
		{
			if(testobligatoire()!=null)
			{
				MessageBox.Show(testobligatoire(),"Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}else
			if(lblTitre.Text == "Atouter Client")
			{   
				BL.CLS_Client clsclient = new BL.CLS_Client();
				if (clsclient.Ajouter_Client(txtNomClient.Text, txtPrenomClient.Text, txtAdresseClient.Text, textTelephoneClient.Text, txtEmailClient.Text, txtPaysClient.Text, txtVilleClient.Text)==true)
				{
					MessageBox.Show("Client Ajouter avec succes","Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					(usclient as USER_Liste_Client).Actualiserdatagrid();
				}else
				{
					MessageBox.Show("Nom et prenom existent deja dans la base", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else // si lbltitre = Modifier Client
			{
				BL.CLS_Client clsclient = new BL.CLS_Client();
				
				DialogResult R = MessageBox.Show("voulez vous vraiment modifier mle client", "modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if(R== DialogResult.Yes)
				{
					clsclient.Modifer_Client(IDselect, txtNomClient.Text, txtPrenomClient.Text, txtAdresseClient.Text, textTelephoneClient.Text, txtEmailClient.Text, txtPaysClient.Text, txtVilleClient.Text);
					// Actualiser datagridview
					(usclient as USER_Liste_Client).Actualiserdatagrid();
					MessageBox.Show("Client Modifié avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					MessageBox.Show("Modification est annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}

				
				
				
			}
			

		private void btnActualiser_Click(object sender, EventArgs e)
		{
			// vider les textbox
			txtNomClient.Text = "Nom Client"; txtNomClient.ForeColor = Color.Silver;
			txtPrenomClient.Text = "Prenom Client"; txtPrenomClient.ForeColor = Color.Silver;
			txtAdresseClient.Text = "Adresse Client"; txtAdresseClient.ForeColor = Color.Silver;
			textTelephoneClient.Text = "Telephone Client"; textTelephoneClient.ForeColor = Color.Silver;
			txtEmailClient.Text = "Email Client"; txtEmailClient.ForeColor = Color.Silver;
			txtPaysClient.Text = "Pays Client"; txtPaysClient.ForeColor = Color.Silver;
			txtVilleClient.Text = "Ville Client"; txtVilleClient.ForeColor = Color.Silver;

		}
	}

}
