// See https://aka.ms/new-console-template for more information
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundo");
    Console.WriteLine("M = Minuto");
    Console.WriteLine("0 = Sair");
    Console.Write("Quanto tempo deseja contar? : ");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;

    if (type == 'm')
        multiplier = 60;

    if (time == 0)
        System.Environment.Exit(0);

    Start(time * multiplier);
}

static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("StopWatch finalizado...");
    Thread.Sleep(3000);

    Menu();
}
