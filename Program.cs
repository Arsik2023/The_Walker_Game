﻿internal class Program
{
    private static void Main(string[] args)
    {
        // Курсор не видим
        Console.CursorVisible = false;

        char[,] map =
        {
            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
            {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#'},
            {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#'},
            {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*', ' ', '#', ' ', '#', ' ', '#'},
            {'#', ' ', '#', ' ', '*', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', ' ', ' ', ' ', '#', ' ', '#', ' ', '#'},
            {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', '#'},
            {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', '#'},
            {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', '#'},
            {'#', ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#'},
            {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', '#', '#', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#'},
            {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#'},
            {'#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#'},
            {'#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#'},
            {'#', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#'},
            {'#', ' ', ' ', ' ', ' ', '#', ' ', '*', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '*', ' ', '#'},
            {'#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#'},
            {'#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#'},
            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
        };

        int Userx = 7;
        int Usery = 6;

        char[] bag = new char[1];

        while (true)
        {
            // Устанавливает положение текста
            Console.SetCursorPosition(0, 18);
            Console.Write("Сумка: ");

            for (int i = 0; i < bag.Length; i++)
            {
                Console.Write(bag[i] + " ");
            }

            Console.SetCursorPosition(0, 0);

            // Выводится карта
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(Usery, Userx);
            Console.Write("I");

            // Описывает нажатую клавишу консоли
            ConsoleKeyInfo char_key = Console.ReadKey();

            switch (char_key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (map[Userx - 1, Usery] != '#')
                    {
                        Userx--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (map[Userx + 1, Usery] != '#')
                    {
                        Userx++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (map[Userx, Usery - 1] != '#')
                    {
                        Usery--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (map[Userx, Usery + 1] != '#')
                    {
                        Usery++;
                    }
                    break;
            }

            if (map[Userx, Usery] == '*')
            {
                map[Userx, Usery] = 'o';
                char[] temp_bag = new char[bag.Length + 1];
                for (int i = 0; i < bag.Length; i++)
                {
                    temp_bag[i] = bag[i];
                }
                temp_bag[temp_bag.Length - 1] = '*';
                bag = temp_bag;
            }
        }
    }
}