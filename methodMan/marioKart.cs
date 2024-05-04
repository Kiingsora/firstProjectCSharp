// ajouter logique de voiture qui passe





// bibliothèque
using System.Numerics;

// variables
string[,] pisteDeCourses = new string[,]
{
    {"-","-","-","-","-"},
    {"-","-","-","-","-"},
    {"-","-","-","-","-"},
    {"-","-","-","-","-"},
    {"-","-","-","-","-"},
};

// fonctions
//affichage de la map
void displayMap()
{
    //  abscisse
    for (int i = 0; i < pisteDeCourses.GetLength(0); i++)
    {
    Console.WriteLine("");
        // ordonnée
        for (int j = 0; j < pisteDeCourses.GetLength(1); j++)
        {
           Console.Write(pisteDeCourses[i, j]); 
        }
    }
}

Vector2 deplacement(int X, int Y)
{
    Vector2 direction = new Vector2(X, Y);
    return direction;
}
Vector2 position(int X, int Y)
{
    Vector2 position = new Vector2(X, Y);
    return position;
}

// direction que prendra l'user à chaque touche entrée
Vector2 getDirection(string inputIserDirection)
{
    Vector2 direction = new Vector2(0, 0);

    if (inputIserDirection == "z")
    {
        direction = deplacement(-1, 0);
    }
    else if (inputIserDirection == "s")
    {
        direction = deplacement(1, 0);
    }
    else if (inputIserDirection == "q")
    {
        direction = deplacement(0, -1);
    }
    else if (inputIserDirection == "d")
    {
        direction = deplacement(0, 1);
    }
    else
    {
        return new Vector2(0, 0);
    }
    return direction;
}

// coordination déplacement/direction

void move(Vector2 direction)
{
    // trouver la position de #

    int positionX = 0;
    int positionY = 0;

    for (int i = 0; i < pisteDeCourses.GetLength(0); i++)
    {
        for (int j = 0; j < pisteDeCourses.GetLength(1); j++)
        {
            if (pisteDeCourses[i, j] == "#")
            {
                positionX = i;
                positionY = j;
                break;
            }
        }
    }

    int newX = positionX + Convert.ToInt32(direction.X);
    int newY = positionY + Convert.ToInt32(direction.Y);

    if (newX >= 0 && newX < pisteDeCourses.GetLength(0) && newY >= 0 && newY < pisteDeCourses.GetLength(1))
    {
        pisteDeCourses[positionX, positionY] = "-";
        pisteDeCourses[newX, newY] = "#";
    }
}

// lancement du jeu
while (true)
{
    Console.WriteLine("Dans quelle direction voulez vous aller?(z:up, s:down, q: left, d: right)");
    displayMap();
    string input = Console.ReadLine();
    Vector2 direction = getDirection(input);
    move(direction);
}