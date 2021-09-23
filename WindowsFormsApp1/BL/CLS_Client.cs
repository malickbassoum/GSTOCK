using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
	class CLS_Client
	{
		private dbStockContext db = new dbStockContext();
		private Client C; //table client

		//fonction pour ajour client dans la base de donhnée
		public bool Ajouter_Client(string Nom, string Prenom, string Adresse, string Telephone, string Email, string Pays, string Ville)
		{
			C = new Client();// Nouveau client
			C.Nom_Client = Nom;
			C.Prenom_Client = Prenom;
			C.Adresse_Client = Adresse;
			C.Telephone_Client = Telephone;
			C.Email_Client = Email;
			C.Pays_Client = Pays;
			C.Ville_Client = Ville;
			//Verifier si le nom et prenom existe dans la base de donnée
			if(db.Clients.SingleOrDefault(s=>s.Nom_Client == Nom && C.Prenom_Client == Prenom)==null)
			{
				db.Clients.Add(C); // Ajouter dans la base de données
				db.SaveChanges(); //Enregistrer dans la base de données

				return true;
			}else
			{
				return false;
			}
		}

		//Fonction pour modifier client
		public void Modifer_Client(int id, string Nom, string Prenom, string Adresse, string Telephone, string Email, string Pays, string Ville)
		{
			C = new Client();
			C = db.Clients.SingleOrDefault(s => s.ID_Client == id);// veriff*ier si id du client existe dans la base
			if(C!=null)//existe
			{
				C.Nom_Client = Nom; //nouveau nom du client
				C.Prenom_Client = Prenom;
				C.Adresse_Client = Adresse;
				C.Telephone_Client = Telephone;
				C.Email_Client = Email;
				C.Ville_Client = Pays;
				C.Pays_Client = Ville;
				db.SaveChanges();

			}

		}
	}
}
