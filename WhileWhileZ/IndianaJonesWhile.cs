
bool[,] map = new bool[4, 4];

int retry = 0;
Random rand = new Random();
int randRow = Convert.ToInt32(rand.Next(4));
int randColumn = Convert.ToInt32(rand.Next(4));
map[randRow, randColumn] = true;
// Console.WriteLine(map[randRow, randColumn] = true);
Console.WriteLine("INDIANA JONES à la recherche de tout TANT QUE amon");
Console.WriteLine("");
Console.WriteLine("Après avoir parcouru le desert, vous arrivez enfin devant la pyramide que vous recherchiez...Vous avez l'impression d'être déjà venu ici...");
Console.WriteLine("");
Console.WriteLine("Vous entrez...");
Console.WriteLine("");
Console.WriteLine("Vous marchez prudemment pendant 5 min, vous vous arrêtez devant une grande salle.");
Console.WriteLine("Cette salle vous la connaissez car elle était mentionné dans les ouvrages que vous avez étudié...");
Console.WriteLine("");
Console.WriteLine("Le sol était un damier de pierre déssiné sur le sol.");
Console.WriteLine("et de l'autre côté, se trouve la relique que vous convoitez tant");
Console.WriteLine("");
Console.WriteLine("Vous devez traverser la salle afin de récupérer la relique en posant les pides sur les bonnes dalles ou vous risquerez de le regretter...Voulez-vous y aller? (y) ou (n)");


string input = Console.ReadLine();

if (input == "y")
{
    Console.WriteLine(map);

    while (true)
    {
        Console.WriteLine("Quelle sera la première dalle où vous poserez le pied?");
        string input1 = Console.ReadLine();
        if (string.IsNullOrEmpty(input1))
        {
            Console.WriteLine("Veuillez entrer une valeur valide.");
            // continu permet de passer à la boucle suivante si l'utilisateur entre dans cette condition
            continue;
        }
        int numberIndex1 = Convert.ToInt32(input1);

        Console.WriteLine("Et quel est la dernière dalle qui vous permettra d'ouvrir la porte qui renferme la relique ?");
        string input2 = Console.ReadLine();
        if (string.IsNullOrEmpty(input2))
        {
            Console.WriteLine("Veuillez entrer une valeur valide.");
            // continu permet de passer à la boucle suivante si l'utilisateur entre dans cette condition
            continue;
        }
        int numberIndex2 = Convert.ToInt32(input2);

        if (numberIndex1 < 4 && numberIndex2 < 4)
        {
            if (retry == 5)
            {
                Console.WriteLine("Après votre " + retry + "eme tentative, vous entendez une porte se fermer derrière vous!");
                Console.WriteLine("");
                Console.WriteLine("Après plusieurs jours sans boire ni manger,vous êtes mort...");
                Console.WriteLine("");
                Console.WriteLine("Puis vous vous éveillez dans une salle blanche, une porte se tiens devant vous...");
                Console.WriteLine("");
                Console.WriteLine("Vous vous approchez, et appercevez un écriteaux sur lequel il est écrit :");
                Console.WriteLine("");
                Console.WriteLine("''Appuyez sur ce bouton si vous voulez une nouvelle chance...''");
                Console.WriteLine("");
                Console.WriteLine("Vous regardez le bouton, il est inscrit F5...Vous appuyez...");
                break;
            }

            if (map[randRow, randColumn] == map[numberIndex1, numberIndex2])
            {
                Console.WriteLine("Félicitation! ");
                Console.WriteLine("");
                Console.WriteLine(" vous arrivez devant la relique!");
                Console.WriteLine("");
                Console.WriteLine("Vous remplissez un sac de sable et avec une grande dextérité vous échangez le sac de sable contre la relique...vous avez réussi!");
                Console.WriteLine("");
                Console.WriteLine("Vous vous retournez fière, sourire aux lèvres...");
                Console.WriteLine("");
                Console.WriteLine("...Tout à coup, la pyramide tremble! (On abuse pas tout TANT QUE amont aussi facilement...)");
                Console.WriteLine("");
                Console.WriteLine("Il est temps de partir! Ni une, ni deux vous courrez vers la sortie !");
                Console.WriteLine("");
                Console.WriteLine("Des pièges fuse de toute part! Des flèches qui traverse les couloirs! Un rocher déboule derière vous et semble vous poursuivre!");
                Console.WriteLine("");
                Console.WriteLine("Tout à coup la sortie! devant vous!");
                Console.WriteLine("");
                Console.WriteLine("Vous utilisez vos dernières force pour atteindre la sortie alors que la porte est en train de se refermer sur vous!");
                Console.WriteLine("");
                Console.WriteLine("in extremis, vous glissez sous la porte faites tomber votre chapeau et le récupérez juste avant que la porte ne vous écrase le bras...");
                Console.WriteLine("");
                Console.WriteLine("Tandis que vous avez rescapé à la mort, vous vous éloignez pendant que la pyramide s'éffondre sur elle même...");
                Console.WriteLine("");
                Console.WriteLine("...Il est temps de rentrer se reposer, car vous devez rentrer pour exposer votre nouvelle récompense...");
                Console.WriteLine("");
                Console.WriteLine(" Dans la pénombre, quelqu'un vous guette...Les ennuis ne sont jamais loins...");
                Console.WriteLine("");
                Console.WriteLine("...À suivre");
                break;
            }// loose
            else
            {
                Console.WriteLine("La porte qui renferme la relique est toujours fermé...Vous avez dû faire une erreur quelque part, vous rééssayez");
                Console.WriteLine("");
                retry++;
            }
        }
        else
        {
            Console.WriteLine("il n'y a pas de dalle a ces endroits là...");
            Console.WriteLine("");
        }
    }
}
else
{
    Console.WriteLine("Par manque de courage, vous avez voulu partir, vous êtes tombé dans un piège et vous êtes mort...");
}


