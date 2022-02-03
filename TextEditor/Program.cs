Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Bem vindo ao editor de texto. Escolha sua opção!");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar novo arquivo");
    Console.WriteLine("0 - Sair");

    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Open(); break;
        case 2: Edit(); break;
        default: Menu(); break;
    }
}

static void Open()
{
    Console.Clear();
    Console.WriteLine("Qual caminho do arquivo que deseja abrir?");

    var path = Console.ReadLine();

    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }

    Console.WriteLine("");
    Console.WriteLine("Aperte ENTER para voltar ao Menu.");
    Console.ReadLine();
    Menu();
}

static void Edit()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo (ESC para finalizar).");
    Console.WriteLine("---------------------------------------------");

    string text = String.Empty;

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Console.Write(text);
}

static void Save(string text)
{
    Console.Clear();
    Console.WriteLine("Qual caminho deseja salvar o arquivo?");

    var path = Console.ReadLine();

    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }

    Console.WriteLine($"Arquivo {path} salvo com sucesso!");
    Console.WriteLine("Aperte ENTER para voltar ao Menu.");
    Console.ReadLine();
    Menu();
}
