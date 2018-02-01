namespace Commande
{
    class LigneCmd // FQDN : Commande.LigneCmd
    {
        public string designation;
        public double quantite;
        // Les champs privés commence par _
        private double _prixUnitaire;

        // Création de la propriété PrixUnitaire
        // Les membres publiques commencent par une majuscule.
        public double PrixUnitaire
        {
            // Acces en lecture
            get { return _prixUnitaire; }
            // Acces en ecriture
            // La valeur affectée est accessible à travers la variable "value"
            set { _prixUnitaire = value; }
        }

        public double Montant()
        {
            return PrixUnitaire * quantite;
        }

        public string Description()
        {
            return $"{designation}, pu:{PrixUnitaire}, qt:{quantite}, mnt:{Montant()}";
        }
    }
}
