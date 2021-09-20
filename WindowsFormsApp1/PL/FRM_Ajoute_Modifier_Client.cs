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
		public FRM_Ajoute_Modifier_Client()
		{
			InitializeComponent();
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
				catch(Exception e)
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

		private void btnEnregistrer_Click(object sender, EventArgs e)
		{
			if(testobligatoire()!=null)
			{
				MessageBox.Show(testobligatoire(),"Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void btnActualiser_Click(object sender, EventArgs e)
		{
			// vider les textbox


		}
	}
}
