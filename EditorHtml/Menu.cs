namespace EditorHtml
{
    public static class Menu
    {
        private const int COLUMNS_WIDTH = 60;
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen(COLUMNS_WIDTH);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen(int columns)
        {
            DrawTopBottomBorders(columns);

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= columns; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }

            DrawTopBottomBorders(columns);
        }

        public static void DrawTopBottomBorders(int columns)
        {
            Console.Write("+");
            for (int i = 0; i <= columns; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor de HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==============================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}