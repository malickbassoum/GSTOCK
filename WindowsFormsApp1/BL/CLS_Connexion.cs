using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
	class CLS_Connexion
	{
		// fonction pour verifier la connexion
		public bool ConnexionValide(dbStockContext db, string Nom, string Mot_de_passe)
		{
			Utilisateur u = new Utilisateur(); //table utilisateur
			u.Nom_Utilisateur = Nom;
			u.Mot_De_Passe = Mot_de_passe;
			if(db.Utilisateurs.SingleOrDefault(s=>s.Nom_Utilisateur==Nom && s.Mot_De_Passe ==Mot_de_passe)!=null) // si l'utilisateur et le mot de passe exise dans la base
			{
				return true;
			}else // s'il n'existe pas
			{
				return false;
			}

		}

	}
}
