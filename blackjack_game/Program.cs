/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/

Random random = new Random();
Dictionary<string, int> TheCards = new Dictionary<string, int>()
{
    {"as", 1}, { "2", 2 }, { "3", 3 }, { "4", 4 }, { "5", 5 }, { "6", 6 }, { "7", 7 }, {"8", 8},{"9", 9},{"10", 10},{"jack", 11},{"queen", 12},{"king", 13}
}; //dictionary with the names and values of the cards
Dictionary<string, int> myCards = new Dictionary<string, int>()
{
    {"as", 1}, { "2", 2 }, { "3", 3 }, { "4", 4 }, { "5", 5 }, { "6", 6 }, { "7", 7 }, {"8", 8},{"9", 9},{"10", 10},{"jack", 11},{"queen", 12},{"king", 13}
};
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
            cupierCards.Add(valores.Item1 + Convert.ToString(cupierCards.Count), valores.Item2);
        }
    }
} // this functionn check if the dictionary have repeat values

int myValue = 0;
int cupierValue = 0;
while (true)
{
    bool Control = Convert.ToBoolean(Console.ReadLine());
    //if()
    compareCards(true);
    compareCards(true);
    compareCards(false);
    compareCards(false);
    foreach (KeyValuePair<string, int> kvp in myCards)
    {
        Console.WriteLine($"Key user= {kvp.Key}");
        myValue += kvp.Value;
    }
    foreach (KeyValuePair<string, int> kvp in cupierCards)
    {
        Console.WriteLine($"Key cupier= {kvp.Key}");
        cupierValue += kvp.Value;
    }
    Console.WriteLine("my value: {0}, cupier value: {1}", myValue, cupierValue);
    Console.WriteLine("Desea continuar?\n presione true si es asi o false si no");
    bool stop = Convert.ToBoolean(Console.ReadLine());
    if (!stop)
    {
        Console.WriteLine("adios");
        break;
    }
    else
    {
        Console.WriteLine("ya vete");
        break;
    }
 
}



