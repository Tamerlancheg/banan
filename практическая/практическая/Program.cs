Console.Write("Выберите одну из игр:");
while (true)
{
    string c = Console.ReadLine();
    {
        if (c == "1")
        {
            {
                Console.WriteLine("Угадайте число от 0 до 100:");
                string str;
                Random random = new Random();
                int g = random.Next(0, 100);

                do
                {
                    Console.Write("Ваш вариант: ");
                    str = Console.ReadLine();

                    if (int.Parse(str) < g)
                        Console.WriteLine("Задуманное число больше");
                    if (int.Parse(str) > g)
                        Console.WriteLine("Задуманное число меньше");

                }
                while (int.Parse(str) != g);

                Console.WriteLine("Вы угадали!!!");
            }
            Console.WriteLine(' ');
            Console.WriteLine("Введите операцию еще раз");
        }
        if (c == "2")
        {
            int[,] tabl = new int[10, 10];

            for (short i = 1; i < 10; i += 1)
            {
                for (short j = 1; j < 10; j += 1)
                {
                    tabl[i, j] = i * j;
                    Console.Write(" {0}\t", tabl[i, j], "");
                }
                Console.WriteLine();


            }
            Console.WriteLine("выберете операцию ещё раз");


        }

        if (c == "3")
        {
            Console.WriteLine("введите число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("делители числа {0}", b);
            for (int i = 1; i <= b; i++)
            {
                if (b % i == 0)
                    Console.Write(" {0} ", i);
            }
            Console.Write("\nВыберете операцию ещё раз ");
        }

        if (c == "4")
        {
            Environment.Exit(0);

        }

    }
}

