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
	public partial class FRM_Menu : Form
	{
		public FRM_Menu()
		{
			InitializeComponent();
			panel1.Size = new Size(330, 737);
			pnlParamettre.Visible = false;
		}
		// desactiver le formulaire
		public void desactiverForm()
		{
			btnclient.Enabled = false;
			btnproduit.Enabled = false;
			btncategorie.Enabled = false;
			btnutilisateur.Enabled = false;
			btnCopieApp.Enabled = false;
			btnRestore.Enabled = false;
			btncommande.Enabled = false;
			btnDeconnecter.Enabled = false;
			pnlbut.Enabled = false;
			// cconnecter activer
			btnConnecter.Enabled = true;
		}
		public void activerForm()
		{
			btnclient.Enabled = true;
			btnproduit.Enabled = true;
			btncategorie.Enabled = true;
			btnutilisateur.Enabled = true;
			btnCopieApp.Enabled = true;
			btnRestore.Enabled = true;
			btncommande.Enabled = true;
			btnDeconnecter.Enabled = true;
			pnlbut.Enabled = true;
			// connecter desactiver
			btnConnecter.Enabled = false;
			pnlParamettre.Visible = false;

		}


		private void button3_Click(object sender, EventArgs e)
		{
			if (panel1.Width == 330)
				{
				panel1.Size = new Size(74, 479);
			}
			else
			{
				panel1.Size = new Size(330, 737);
					}
		}

		private void btncommande_Click(object sender, EventArgs e)
		{
			pnlbut.Top = btncommande.Top;
		}

		private void btnproduit_Click(object sender, EventArgs e)
		{
			pnlbut.Top = btnproduit.Top;
		}

		private void btnclient_Click(object sender, EventArgs e)
		{
			pnlbut.Top = btnclient.Top;
			if(!pnlAffiche.Controls.Contains(USER_Liste_Client.Instance))
			{
				pnlAffiche.Controls.Add(USER_Liste_Client.Instance);
				USER_Liste_Client.Instance.Dock = DockStyle.Fill;
				USER_Liste_Client.Instance.BringToFront();
			}else
			{
				USER_Liste_Client.Instance.BringToFront();
			}
		}

		private void btncategorie_Click(object sender, EventArgs e)
		{
			pnlbut.Top = btncategorie.Top;
		}

		private void btnutilisateur_Click(object sender, EventArgs e)
		{
			pnlbut.Top = btnutilisateur.Top;
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		
		private void button1_Click_2(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button9_Click(object sender, EventArgs e)
		{

		}

		private void btnParamettre_Click(object sender, EventArgs e)
		{
			pnlParamettre.Size = new Size(424, 200);
			pnlParamettre.Visible = !pnlParamettre.Visible;
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnConnecter_Click(object sender, EventArgs e)
		{
			//Afficher formulaire de connexion
			FRM_Connexion frmC = new FRM_Connexion(this);// this= FRM_MENU
			frmC.ShowDialog();
		}

		private void FRM_Menu_Load(object sender, EventArgs e)
		{
			desactiverForm();
		}

		private void btnDeconnecter_Click(object sender, EventArgs e)
		{
			desactiverForm();   
		}
	}
}
