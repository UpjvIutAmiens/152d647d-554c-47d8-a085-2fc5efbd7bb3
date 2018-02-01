namespace Commande
{
    class LigneCmd // FQDN : Commande.LigneCmd
    {
        public string designation;
        public double quantite;
        public double prixUnitaire;

        public string Description()
        {
            return $"{designation}, pu:{prixUnitaire}, qt:{quantite}";
        }
    }
}
