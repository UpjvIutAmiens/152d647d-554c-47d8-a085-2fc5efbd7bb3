namespace Commande
{
    class LigneCmd // FQDN : Commande.LigneCmd
    {
        public string designation;
        public double quantite;
        public double prixUnitaire;

        public double Montant()
        {
            return prixUnitaire * quantite;
        }

        public string Description()
        {
            return $"{designation}, pu:{prixUnitaire}, qt:{quantite}, mnt:{Montant()}";
        }
    }
}
