class zad
{
    static void mnozTab(int x, string[] tab)
    {
        string[] nowa = new string[tab.Length];
        for (int i = 0; i < tab.Length; i++)
        {
            for (int j = 0; j < x; j++)
            {
                nowa[i] = nowa[i] + tab[i];
            }
        }
        Console.WriteLine("Twoja nowa tablica ");
        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write(nowa[i] + " ");
        }
    }
    static void Main(string[] args)
    {
        string[] tab = { "ala", "ma", "kota" };
        int x;
        Console.WriteLine("Podaj ilukrotnie pomnożyć twoją tablicę");
        x = int.Parse(Console.ReadLine());
        mnozTab(x, tab);
        Console.ReadKey();
    }
}