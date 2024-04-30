string jump = "s";
string continu = "a";
int score = 0;

Console.WriteLine("Super Mario Bros. WRITING WORLD ARRAY");

Console.WriteLine("Bienvenue! Dans un nouveau jeu Mario!");
Console.WriteLine("Dans ce jeu, vous devrez voyager dans les mondes numérique de Mario!");

Console.WriteLine("Les règles du jeu sont simple, des évènements aurons lieu et vous devrez réagir en conséquence. lorsqu'un chemin sûr ce présenteras a toi, tu appuiera sur la touche (a) pour avancer mais si c'est un ennemi, appuie sur (s) pour sauter! Amuse toi bien !");

Console.WriteLine("Veuillez entrer ok et appuyer sur entrée pour Lancer la partie ou n'importe quelle touche pour quitter");
string input = Console.ReadLine();

if (input == "ok")
{

    string[] niveau = ["-", "-", "x", "x", "*", "-", "x", "x", "*", "-", "-", "*", "FIN"];

    for (int i = 0; i < niveau.Length; i++)
    {
        switch (niveau[i])
        {
            case "-":
                Console.WriteLine("Vous êtes devant un chemin, que voulez vous faire?");
                break;
            case "*":
                Console.WriteLine("Vous voyez une étoile, que voulez vous faire?");
                break;
            case "x":
                Console.WriteLine("Vous êtes devant un goomba, que voulez vous faire?");
                break;
            default:
                Console.WriteLine("Fin du niveau, vous avez fais un score de " + score + " point(s)");
                break;
        }

        input = Console.ReadLine();

        if (input != continu && niveau[i] == "-")
        {
            Console.WriteLine("YOU DIED");
            break;
        }
        else if (input != continu && niveau[i] == "*")
        {
            Console.WriteLine("YOU DIED");
            break;

        }
        else if (input != jump && niveau[i] == "x")
        {
            Console.WriteLine("YOU DIED");
            break;
        }
        else if (input == continu && niveau[i] == "*")
        {
            score++;
        }
    }
}
else
{
    Console.WriteLine("Vous avez peur ?");
}