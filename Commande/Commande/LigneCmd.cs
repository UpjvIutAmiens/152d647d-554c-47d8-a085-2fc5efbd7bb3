﻿using System;

namespace Commande
{
    class LigneCmd // FQDN : Commande.LigneCmd
    {
        
        
        // Les champs privés commence par _
        private double _prixUnitaire;
        private double _quantite;
        private string _designation;

        // Le constructeur est appelé à la construction de l'objet (intanciation)
        // Il a le même nom que la classe et il n'a pas de type de retour
        public LigneCmd(string designation, double prixUnitaire, double quantite)
        {
            Designation = designation;
            PrixUnitaire = prixUnitaire;
            Quantite = quantite;
        }



        // Création de la propriété PrixUnitaire
        // Les membres publiques commencent par une majuscule.
        public double PrixUnitaire
        {
            // Acces en lecture
            get { return _prixUnitaire; }
            // Acces en ecriture
            // La valeur affectée est accessible à travers la variable "value"
            set
            {
                if (value < 0)
                {
                    // throw lève une exception
                    throw new ArgumentOutOfRangeException($"PU négatif : {value}");
                }
                else
                {
                    _prixUnitaire = value;
                }
            }
        }

        public double Quantite
        {
            // Acces en lecture
            get { return _quantite; }
            // Acces en ecriture
            // La valeur affectée est accessible à travers la variable "value"
            set
            {
                if (value < 0)
                {
                    // throw lève une exception
                    throw new ArgumentOutOfRangeException($"QT négative : {value}");
                }
                else
                {
                    _quantite = value;
                }
            }
        }

        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }

        public double Montant
        {
            get { return PrixUnitaire * Quantite; }
        }

        public string Description()
        {
            return $"{Designation}, pu:{PrixUnitaire}, qt:{Quantite}, mnt:{Montant}";
        }
    }
}
