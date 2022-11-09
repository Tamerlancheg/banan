internal class Class1
{

    /*public string State { get; set; }*/
    /*public Employee() { }*/
    /*public static int price;*/

    public void WriteEmployee()
    {

    }
    public static void DisplayEmployee(string name)
    {
    }
    public static void Menu()
    {
        List<string> torts = new List<string>();
        torts.Add("Форма");
        torts.Add("Размер");
        torts.Add("Вкус");
        torts.Add("Количество");
        torts.Add("Глазурь");
        torts.Add("Декор");
        Console.WriteLine(" Меню");
        for (int i = 0; i < torts.Count; i++)
        {
            Console.WriteLine(" " + i + ".{0}", torts[i]);
        }
    }
    public static void selector()
    {

        int position = 0;
        while (true)
        {
            Console.Clear();
            Menu();
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            if (key.Key == ConsoleKey.UpArrow)
            {
                position = position - 1;
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                position = position + 1;
            }
            if (position == 0)
            {
                position = position + 1;
            }
            if (position == 9)
            {
                position = position - 1;
            }
            if (position == 1 && key.Key == ConsoleKey.Enter)
            {
                Form();
            }
            if (position == 2 && key.Key == ConsoleKey.Enter)
            {
                Size();
            }
            if (position == 3 && key.Key == ConsoleKey.Enter)
            {
                Thetasteofcakes();
            }
            if (position == 4 && key.Key == ConsoleKey.Enter)
            {
                numbers();
            }
            if (position == 5 && key.Key == ConsoleKey.Enter)
            {
                glaze();
            }
            if (position == 6 && key.Key == ConsoleKey.Enter)
            {
                decor();
            }
        }

    }
    public static void Size()
    {
        Console.Clear();
        List<string> Size1 = new List<string>();
        Size1.Add("Маленький (Диаметр - 16см, 8 порций) - 1000р");
        Size1.Add("Обычнчый (Диаметр - 18см, 10 порций) - 1200р");
        Size1.Add("Большой (Диаметр - 18см, 24 порций) - 2000р");
        Console.SetCursorPosition(0, 1);
        for (int i = 0; i < Size1.Count; i++)
        {
            Console.WriteLine(" " + i + ".{0}", Size1[i]);
        }
        Console.ReadLine();
    }
    public static void Form()
    {
        Console.Clear();
        List<string> form = new List<string>();
        form.Add("Круг");
        form.Add("Квадрат");
        form.Add("Прямоугольник");
        form.Add("Сердцечко");
        Console.SetCursorPosition(0, 1);
        for (int i = 0; i < form.Count; i++)
        {
            Console.WriteLine(" " + i + ".{0}", form[i]);
        }
        Console.ReadLine();
    }
    public static void Thetasteofcakes()
    {
        Console.Clear();
        List<string> Thetasteofcakes1 = new List<string>();
        Thetasteofcakes1.Add("Ванильный - 100");
        Thetasteofcakes1.Add("Шоколадный - 400");
        Thetasteofcakes1.Add("Карамельный - 200");
        Thetasteofcakes1.Add("Ягодный - 250");
        Console.SetCursorPosition(0, 1);
        for (int i = 0; i < Thetasteofcakes1.Count; i++)
        {
            Console.WriteLine(" " + i + ".{0}", Thetasteofcakes1[i]);
        }
        Console.ReadLine();
    }
    public static void numbers()
    {
        Console.Clear();
        List<string> numbers1 = new List<string>();
        numbers1.Add("Два коржа");
        numbers1.Add("Три коржа");
        numbers1.Add("Четыре коржа");
        numbers1.Add("Пять коржей");
        Console.SetCursorPosition(0, 1);
        for (int i = 0; i < numbers1.Count; i++)
        {
            Console.WriteLine(" " + i + ".{0}", numbers1[i]);
        }
        Console.ReadLine();
    }
    public static void glaze()
    {
        Console.Clear();
        List<string> glaze1 = new List<string>();
        glaze1.Add("Шоколад");
        glaze1.Add("Крем");
        glaze1.Add("Бизе");
        glaze1.Add("Драже");
        Console.SetCursorPosition(0, 1);
        for (int i = 0; i < glaze1.Count; i++)
        {
            Console.WriteLine(" " + i + ".{0}", glaze1[i]);
        }
        Console.ReadLine();
    }
    public static void decor()
    {
        Console.Clear();
        List<string> decor1 = new List<string>();
        decor1.Add("Шоколадный");
        decor1.Add("Ягодный");
        decor1.Add("С бобром");
        decor1.Add("Кремовый");
        Console.SetCursorPosition(0, 1);
        for (int i = 0; i < decor1.Count; i++)
        {
            Console.WriteLine(" " + i + ".{0}", decor1[i]);
        }
        Console.ReadLine();
    }
    
internal class Program
    {
        static void Main(string[] args)
        {
            Class1.selector();
        }





    }
}

