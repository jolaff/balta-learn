// See https://aka.ms/new-console-template for more information
Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Qual função deseja executar?\n");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("0 - Sair");

    Console.WriteLine("\n------------------");
    Console.Write("Selecione uma opção: ");

    short escolha = short.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 0: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Soma()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float segundoValor = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = primeiroValor + segundoValor;
    Console.WriteLine($"O resultado da soma é {resultado}");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float segundoValor = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = primeiroValor - segundoValor;
    Console.WriteLine($"O resultado da subtração é {resultado}");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float segundoValor = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = primeiroValor / segundoValor;
    Console.WriteLine($"O resultado da divisão é {resultado}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float segundoValor = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = primeiroValor * segundoValor;
    Console.WriteLine($"O resultado da multiplicação é {resultado}");
    Console.ReadKey();
    Menu();
}