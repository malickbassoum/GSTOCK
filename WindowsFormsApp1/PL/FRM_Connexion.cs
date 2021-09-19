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
	public partial class FRM_Connexion : Form
	{
		private DbStockContext db;
		private Form frmmenu;
		// classe connexion
		BL.CLS_Connexion C = new BL.CLS_Connexion();
		public FRM_Connexion(Form Menu)
		{
			InitializeComponent();
			this.frmmenu = Menu;
			//Initialiser la base de donnée

			db = new DbStockContext();
		}
		//Pour vérifier les champs obligatoire
		string testObligatoire()
		{
			if (textName.Text == "" || textName.Text == "Nom Utilisateur") //si le nom utilisateur est vide ou le text de texbox est "Utilisateur"
			{
				return "Entrer votre Nom Utilisateur";
			}

			if (textPassword.Text == "" || textPassword.Text == "Mot de Passe")
			{
				return "Entrer votre Mot de passe";
			}

			return null;
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void FRM_Connexion_Load(object sender, EventArgs e)
		{

		}

		private void btnQuitter_Click(object sender, EventArgs e)
		{
			//Quitter le formulaire
			this.Close();
		}

		private void textName_Enter(object sender, EventArgs e)
		{
			// poue valider le login

			if (textName.Text== "Nom Utilisateur")
			{
				textName.Text = "";
				textName.ForeColor = Color.WhiteSmoke;//
			}
			
		}

		private void textPassword_Enter(object sender, EventArgs e)
		{
			if (textPassword.Text == "Mot de Passe")
			{
				textPassword.Text = "";
				textPassword.UseSystemPasswordChar = false;
				textPassword.PasswordChar = '*';
				textPassword.ForeColor = Color.WhiteSmoke;//
			}

		}

		private void textName_Leave(object sender, EventArgs e)
		{
			if (textName.Text == "")
			{
				textName.Text = "Nom Utilisateur";
				textName.ForeColor = Color.Silver;
			}
		}

		private void textPassword_Leave(object sender, EventArgs e) 
		{
			if (textPassword.Text == "")
			{
				textPassword.Text = "Mot de Passe";
				textPassword.UseSystemPasswordChar = true; //desactiver password
				textPassword.ForeColor = Color.Silver;
			}

		}

		private void btnSeConnecter_Click(object sender, EventArgs e)
		{
			if(testObligatoire()==null)
			{ 
				if(C.ConnexionValide(db,textName.Text,textPassword.Text)==true)//utilisateur existe
				{
					MessageBox.Show("connexion réussi", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					(frmmenu as FRM_Menu).activerForm();
					this.Close();// quitter formulaire de connexion
				}else
				{
					MessageBox.Show("connexion échoué", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show(testObligatoire(), "obligatoire", MessageBoxButtons.OK ,MessageBoxIcon.Error);
			}
		}

		private void textPassword_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
