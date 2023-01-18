/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/
Random random = new Random();
Dictionary<string, int> TheCards = new Dictionary<string, int>()
{
    {"as", 1}, {"1", 1}, { "2", 2 }, { "3", 3 }, { "4", 4 }, { "5", 5 }, { "6", 6 }, { "7", 7 }, {"8", 8},{"9", 9},{"10", 10},{"jack", 11},{"queen", 12},{"king", 13},
}; //dictionary with the names and values of the cards
Dictionary<string, int> distribute()
{
    Dictionary<string, int> interiorsCards = new Dictionary<string, int>();
    int num1 = random.Next(0, 13);
    int num2 = random.Next(0, 13);
    bool numControl1 = false;
    bool numControl2 = false;
    foreach (KeyValuePair<string, int> kvp in TheCards)
    {
        if (num1 == kvp.Value && !numControl1)
        {
            interiorsCards.Add(kvp.Key, kvp.Value);
            numControl1 = true;
        }
        else if (num2 == kvp.Value && !numControl2)
        {
            interiorsCards.Add(kvp.Key, kvp.Value);
            numControl2 = true;
        }
        else if (numControl1 && numControl2)
        {
            break;
        }
    }
    return interiorsCards;
}



Dictionary<string, int> myCards = new Dictionary<string, int>();
Dictionary<string, int> cupierCards = new Dictionary<string, int>();
while (true)
{
    myCards = distribute();
    cupierCards = distribute();
    Console.WriteLine(myCards.Count);
    Console.WriteLine(cupierCards.Count);
    Console.WriteLine("Desea continuar?\n presione true si es asi o false si no");
    bool stop = Convert.ToBoolean(Console.ReadLine());
    if (!stop)
    {
        break;
    }
}



