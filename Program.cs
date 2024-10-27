// Classe abstraite Paiement
public abstract class Paiement
{
    public double Montant { get; set; }
    public string Description { get; set; }

    public Paiement(double montant, string description)
    {
        Montant = montant;
        Description = description;
    }

    public abstract void AfficherDetails();
}

// Classe CarteCredit héritant de Paiement
public class CarteCredit : Paiement
{
    public int NumeroCarte { get; set; }

    public CarteCredit(double montant, string description, int numeroCarte)
        : base(montant, description)
    {
        NumeroCarte = numeroCarte;
    }

    public override void AfficherDetails()
    {
        Console.WriteLine($"Paiement par Carte Crédit : Montant = {Montant}, Description = {Description}, Numéro de Carte = {NumeroCarte}");
    }
}


// Classe PayPal héritant de Paiement
public class PayPal : Paiement
{
    public string Email { get; set; }

    public PayPal(double montant, string description, string email)
        : base(montant, description)
    {
        Email = email;
    }

    public override void AfficherDetails()
    {
        Console.WriteLine($"Paiement par PayPal : Montant = {Montant}, Description = {Description}, Email = {Email}");
    }
}

// Classe Utilisateur
public class Utilisateur
{
    public string Nom { get; set; }
    public List<Paiement> Paiements { get; set; }

    public Utilisateur(string nom)
    {
        Nom = nom;
        Paiements = new List<Paiement>();
    }

    public void AjouterPaiement(Paiement paiement)
    {
        Paiements.Add(paiement);
    }

    public void AfficherInfos()
    {
        Console.WriteLine($"Utilisateur: {Nom}");
        foreach (var paiement in Paiements)
        {
            paiement.AfficherDetails();
        }
        // Classe Utilisateur
public class Utilisateur
    {
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }

        public Utilisateur(string nom)
        {
            Nom = nom;
            Paiements = new List<Paiement>();
        }

        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"Utilisateur: {Nom}");
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Utilisateur utilisateur = new Utilisateur("nadir");
            CarteCredit paiementCarteCredit = new CarteCredit(100.50, "Achat en ligne", 123456789);
            PayPal paiementPayPal = new PayPal(250.75, "Abonnement mensuel", "nadir@gmail.com");

            utilisateur.AjouterPaiement(paiementCarteCredit);
            utilisateur.AjouterPaiement(paiementPayPal);

            
            utilisateur.AfficherInfos();

            Console.ReadLine();
        }

