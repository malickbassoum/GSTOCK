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
		public FRM_Connexion()
		{
			InitializeComponent();
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
	}
}
