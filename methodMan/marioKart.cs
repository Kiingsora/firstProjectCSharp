// bibliothèque
using System.Numerics;



// variables
string[,] pisteDeCourses = new string[,]
{
    {"#","-","-","-","-"},
    {"-","-","-","-","-"},
    {"-","-","-","-","-"},
    {"-","-","-","-","-"},
    {"-","-","-","-","-"},
};


Vector2 down = deplacement(0,-1);
Vector2 left = deplacement(1,0);
Vector2 right = deplacement(-1,0);

// fonctions
Vector2 deplacement(int X, int Y)
{
    Vector2 direction = new Vector2(X,Y);
    return direction;

}
Vector2 position(int X, int Y)
{
    Vector2 position = new Vector2(X,Y);
    return position;
}

for (int i = 0; i < 1; i++)
{
    Vector2 initialPosition = position(0,0);
    Vector2 up = deplacement(0,1);
    Vector2 moveUp = initialPosition + up;
}

void displayMap(){  

for (int i = 0; i < pisteDeCourses.GetLength(0); i++)
{
    Console.WriteLine("");
    Console.Write(pisteDeCourses[0, i]);
    Console.Write(pisteDeCourses[1, i]);
    Console.Write(pisteDeCourses[2, i]);
    Console.Write(pisteDeCourses[3, i]);
    Console.Write(pisteDeCourses[4, i]);
}
}



// jeu
while (true)
{
Console.WriteLine("Dans quelle direction voulez vous aller?(z:up, s:down, q: left, d: right)");
displayMap();
string input = Console.ReadLine();


}