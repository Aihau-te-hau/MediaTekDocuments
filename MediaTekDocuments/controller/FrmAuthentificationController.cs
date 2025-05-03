using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;
using System;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmAuthentification
    /// </summary>
    class FrmAuthentificationController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des utilisateurs
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Utilisateur> GetAllUtilisateurs()
        {
            return access.GetAllUtilisateurs();
        }
    }
}
