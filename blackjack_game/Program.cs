/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/

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

int myValue = 0;
int cupierValue = 0;
while (true)
{
    Console.WriteLine("Desea jugar una partida?\nEscribe true to say yes or false to say no");
    bool Control = Convert.ToBoolean(Console.ReadLine());
    if (Control)
    {
        compareCards(true);
        compareCards(true);
        compareCards(false);
        compareCards(false);
        while (true)
        {
            foreach (KeyValuePair<string, int> kvp in myCards)
            {
                Console.WriteLine($"Key user= {kvp.Key}");
                myValue += kvp.Value;
            }
            Console.WriteLine("Estas son tus cartas");
            foreach (KeyValuePair<string, int> kvp in cupierCards)
            {
                Console.WriteLine($"Key cupier= {kvp.Key}");
                cupierValue += kvp.Value;
            }
            if (myValue == 21)
            {
                Console.WriteLine("You win");
            }
            if(cupierValue == 21)
            {
                Console.WriteLine("");
            }
            else
            {

            }
        }
    }
    else
    {

    }
    Console.WriteLine("my value: {0}, cupier value: {1}", myValue, cupierValue);
    Console.WriteLine("Desea continuar?\n presione true si es asi o false si no");

    else
    {
        Console.WriteLine("ya vete");
        break;
    }
 
}



