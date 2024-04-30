
int UNITED_PRICE = 1;

Console.WriteLine("Quel âge avez vous? :");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Combien de bonbon(s) avez vous dans votre sac ? :");
int quantity = Convert.ToInt32(Console.ReadLine());
float prix = UNITED_PRICE * quantity;


switch (age)
{
    case <= 10:
        prix *= 0.8f; 
        Console.WriteLine("Le bambin à " + age + " ans, il a acheté " + quantity + " bonbon(s) et le prix est de: " + prix + "€");
        break;
    case <= 18 :
        prix *= 0.9f;
        Console.WriteLine("L'enfant à " + age + " ans, il a acheté " + quantity + " bonbon(s) (L'abus un peu...) et le prix est de: " + prix + "€");
        break;
    default:
        Console.WriteLine("Pour " + quantity + " bonbon(s) le prix est de: " + prix + "€, vous n'avez pas droit à une remise (En même temps " + age + " ans, il serait peut être temps d'arrêter les bonbons...)");
        break;
}