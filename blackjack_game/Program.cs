/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/

using System.Runtime.InteropServices;

Random random = new Random();
Dictionary<string, int> TheCards = new Dictionary<string, int>()
{
    {"as", 1}, { "2", 2 }, { "3", 3 }, { "4", 4 }, { "5", 5 }, { "6", 6 }, { "7", 7 }, {"8", 8},{"9", 9},{"10", 10},{"jack", 10},{"queen", 10},{"king", 10}
}; //dictionary with the names and values of the cards
Dictionary<string, int> myCards = new Dictionary<string, int>();
Dictionary<string, int> cupierCards = new Dictionary<string, int>();
(string, int) distribute()
{
    //Dictionary<string, int> interiorsCards = new Dictionary<string, int>() { };
    int num1 = random.Next(1, 13);
    string value = "";
    int num = 0;
    foreach (KeyValuePair<string, int> kvp in TheCards)
    {
        if (num1 == kvp.Value)
        {
            value = kvp.Key;
            num = kvp.Value;
            break;
        }
    }
    return (value, num);
} //function,give cards to the participants
//problems with duplicate values 

void compareCards(bool control)
{
    (string, int) valores;
    if (control)
    {
        valores = distribute();
        if (!myCards.ContainsKey(valores.Item1))
        {
            myCards.Add(valores.Item1, valores.Item2);
        }
        else
        {
            myCards.Add(valores.Item1 + Convert.ToString(myCards.Count), valores.Item2);
        }
    }
    else
    {
        valores = distribute();
        if (!cupierCards.ContainsKey(valores.Item1))
        {
            cupierCards.Add(valores.Item1, valores.Item2);
        }
        else
        {
            cupierCards.Add(valores.Item1 + " " + Convert.ToString(cupierCards.Count), valores.Item2);
        }
    }
} // this functionn check if the dictionary have repeat values

int lectura(Dictionary<string, int> internalDictionary, bool control)
{
    int contador = 0;
    if (control)
        Console.WriteLine("This is yours cards");
    foreach (KeyValuePair<string, int> kvp in internalDictionary)
    {
        if (control)
        {
            Console.WriteLine($"Your card = {kvp.Key}");
        }
        contador += kvp.Value;
    }
    return contador;
}// show the cards of the player have in any moment



bool control = false;
while (true)
{
    int myValue;
    int cupierValue;
    myCards.Clear();
    cupierCards.Clear();
    if (control)
    {
        compareCards(true);
        compareCards(true);
        compareCards(false);
        compareCards(false);
        myValue = lectura(myCards, true);
        cupierValue = lectura(cupierCards, false);
        while (true)
        {
            Console.WriteLine("Do want one extra card?\nEscribe true to say yes or false to say no ");
            if (Convert.ToBoolean(Console.ReadLine()))
            {
                compareCards(true);
                myValue = lectura(myCards, true);
                compareCards(false);
                cupierValue = lectura(cupierCards, false);
                if (myValue == 21)
                {
                    Console.WriteLine("You win");
                    break;
                }
                else if (cupierValue == 21)
                {
                    Console.WriteLine("You lose");
                    break;
                }
                else if (myValue >= 21)
                {
                    Console.WriteLine("Too far, you lose");
                    break;
                }
                else if (cupierValue >= 21)
                {
                    Console.WriteLine("your enemy lose, you win");
                }
            }
            else
            {
                if (myValue == 21)
                {
                    Console.WriteLine("You win");
                    break;
                }
                else if (cupierValue == 21)
                {
                    Console.WriteLine("You lose");
                    break;
                }
                else if (myValue >= 21)
                {
                    Console.WriteLine("Too far, you lose");
                    break;
                }
                else if (cupierValue >= 21)
                {
                    Console.WriteLine("your enemy lose, you win");
                    break;
                }
            }

        }
    }
    Console.WriteLine("Do you want to play a match?\nEscribe true to say yes or false to say no");
    control = Convert.ToBoolean(Console.ReadLine());
    if (!control)
    {
        Console.WriteLine("see you");
        break;
    }

}



