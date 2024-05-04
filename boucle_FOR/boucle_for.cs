
Console.WriteLine("Entrez un nombre à multiplier :");

string inputNumber = Console.ReadLine();

int chiffreAmultiplier = Convert.ToInt32(inputNumber);

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(chiffreAmultiplier + " x " + i + " = " + (chiffreAmultiplier * i));
}

int [] numbers = new int[5] {1,2,3,4,5};
Console.Write(numbers);