using System;
using System.Text;

class Lab_1
{
    static void Main()
    {

        int choice;
        do
        {
            Console.WriteLine("Выберите пункт:");
            Console.WriteLine("0 - Выход");
            Console.WriteLine("1 - Первое задание");
            Console.WriteLine("2 - Второе задание");
            Console.WriteLine("3 - Третье задание");
            Console.WriteLine("4 - Четвёртое задание");
            Console.WriteLine("5 - Пятое задание");
            Console.WriteLine("6 - Шестое задание");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    First();
                    break;
                case 2:
                    Second();
                    break;
                case 3:
                    Third();
                    break;
                case 4:
                    Fourth();
                    break;
                case 5:
                    int[] intArray = { 5, 3, 9, 1, 7 };
                    string inputString = "Hello, world!";

                    // Вызываем локальную функцию и присваиваем результат кортежу
                    var result = Fiveth(intArray, inputString);

                    // Выводим результат
                    Console.WriteLine($"Максимальный элемент: {result.max}");
                    Console.WriteLine($"Минимальный элемент: {result.min}");
                    Console.WriteLine($"Сумма элементов массива: {result.sum}");
                    Console.WriteLine($"Первая буква строки: {result.firstLetter}");
                    break;
                case 6:
                    UserChecked();
                    UserUnchecked();
                    break;
            }
        } while (choice != 0);
        
    }

    static void First()
    {
        Console.WriteLine("1 Задание\n");

        byte bt = 42;
        sbyte sbt = -42;
        short s = 12345;
        ushort us = 54321;
        int i = 123456789;
        uint ui = 987654321;
        long l = 1234567890123456789;
        ulong ul = 9876543210987654321;
        float f = 3.14f;
        double d = 3.14159265359;
        decimal dc = 12345.6789m;
        bool b = true;
        char c = 'A';
        string str = "Привет, мир!";

        Console.WriteLine("byte: " + bt);
        Console.WriteLine("sbyte: " + sbt);
        Console.WriteLine("short: " + s);
        Console.WriteLine("ushort: " + us);
        Console.WriteLine("int: " + i);
        Console.WriteLine("uint: " + ui);
        Console.WriteLine("long: " + l);
        Console.WriteLine("ulong: " + ul);
        Console.WriteLine("float: " + f);
        Console.WriteLine("double: " + d);
        Console.WriteLine("decimal: " + dc);
        Console.WriteLine("bool: " + b);
        Console.WriteLine("char: " + c);
        Console.WriteLine("string: " + str);

        Console.Write("Введите целое число: ");
        int input = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Вы ввели: " + input);


        //Явное преобразование
        double da = 3.5;
        int ib = (int)da;
        char cc = (char)ib;
        float fd = (float)da;
        long le = (long)fd;

        Console.WriteLine("da (явное): " + da);
        Console.WriteLine("ib (явное): " + ib);
        Console.WriteLine("cc (явное): " + cc);
        Console.WriteLine("fd (явное): " + fd);
        Console.WriteLine("le (явное): " + le);


        //Неявное преобразование
        int intValue = 4;
        double doubleValue = intValue;
        float floatValue = intValue;
        long longValue = intValue;
        short shortValue = 10;
        intValue = shortValue;
        ushort uShortValue = 50;
        ulong uLongValue = uShortValue;

        Console.WriteLine("doubleValue (неявное): " + doubleValue);
        Console.WriteLine("floatValue (неявное): " + floatValue);
        Console.WriteLine("longValue (неявное): " + longValue);
        Console.WriteLine("intValue (неявное): " + intValue);
        Console.WriteLine("uLongValue (неявное): " + uLongValue);

        //Convert
        int conInt = Convert.ToInt32('A');
        Console.WriteLine("Преобразрвание char в int при помощи Convert" + conInt);

        //Упаковка и распаковка
        int originalInt = 42;

        object boxedInt = originalInt;

        int unboxedInt = (int)boxedInt;

        Console.WriteLine("originalInt: " + originalInt);
        Console.WriteLine("boxedInt: " + boxedInt);
        Console.WriteLine("unboxedInt: " + unboxedInt);

        //Тип var
        var number = 42;

        var text = "Привет, мир!";

        Console.WriteLine("number: " + number);
        Console.WriteLine("text: " + text);

        //Nullable переменные
        int? nullableInt = null;

        if (nullableInt.HasValue == false)
        {
            Console.WriteLine("nullableInt равен null");
        }

        nullableInt = 10;
        Console.WriteLine(nullableInt);
    }

    static void Second()
    {
        Console.WriteLine("\n\n2 Задание\n");

        string str1 = "Hello, world!";
        string str2 = "Hello, world!";
        string str3 = "Goodbye, world!";

        bool areEqual1 = (str1 == str2);
        bool areEqual2 = (str1 == str3);

        bool areEqual3 = str1.Equals(str2);
        bool areEqual4 = str1.Equals(str3);


        Console.WriteLine("Сравнение строк с использованием операторов:");
        Console.WriteLine("str1 и str2: " + areEqual1);
        Console.WriteLine("str1 и str3: " + areEqual2);

        Console.WriteLine("\nСравнение строк с использованием метода Equals:");
        Console.WriteLine("str1 и str2: " + areEqual3);
        Console.WriteLine("str1 и str3: " + areEqual4);



        string s1 = "Привет,";
        string s2 = " мир!";
        string s3 = " C#!";

        // Сцепление (конкатенация) строк
        string concatenatedString = s1 + s2 + s3;
        Console.WriteLine("Сцепление строк: " + concatenatedString);

        // Копирование строки
        string copiedString = concatenatedString;
        Console.WriteLine("Копия строки: " + copiedString);

        // Выделение подстроки
        string substring = concatenatedString.Substring(7, 4);
        Console.WriteLine("Подстрока: " + substring);

        // Разделение строки на слова
        string sentence = "Это просто предложение";
        string[] words = sentence.Split(' ');
        Console.WriteLine("Слова в строке: ");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        string originalString = "Я люблю С#, это мой язык программирования";
        string insertedString = "любимый ";
        string finalString = originalString.Insert(20, insertedString);
        Console.WriteLine("Строка с вставленной подстрокой: " + finalString);

        // Удаление заданной подстроки
        string stringWithSubstring = "Это просто тестовое предложение";
        string substringToRemove = "просто ";
        string stringWithoutSubstring = stringWithSubstring.Replace(substringToRemove, "");
        Console.WriteLine("Строка после удаления подстроки: " + stringWithoutSubstring);

        //Интерполирование строк
        int count = 10;
        Console.WriteLine($"В группе {count} человек");

        // Создаем пустую строку
        string emptyString = "";

        // Создаем строку со значением null
        string? nullString = null;

        // Используем метод string.IsNullOrEmpty
        bool isEmpty1 = string.IsNullOrEmpty(emptyString); // Проверяем пустую строку
        bool isEmpty2 = string.IsNullOrEmpty(nullString);  // Проверяем строку со значением null

        Console.WriteLine("Пустая строка пуста: " + isEmpty1); // Ожидается true
        Console.WriteLine("Строка со значением null пуста: " + isEmpty2); // Ожидается true

        // Дополнительные операции с пустой строкой и строкой со значением null
        bool areEqual = (nullString == emptyString);
        Console.WriteLine("Сравнение строки со значением null и пустой строки: " + areEqual);

        // Получение длины строки
        int length = emptyString.Length;
        Console.WriteLine("Длина пустой строки: " + length);

        //StringBuilder
        StringBuilder strBuild = new StringBuilder("Hello world!");
        strBuild.Remove(2, 1);
        strBuild.Insert(0, 'h');
        strBuild.Append('.');
        Console.WriteLine(strBuild);
    }

    static void Third()
    {
        int[][] arr = new int[4][];
        for(int i = 0; i < 4; i++)
        {
            arr[i] = new int[5];
            for(int j = 0; j < 5; j++)
            {
                Random rnd = new Random();
                arr[i][j] = rnd.Next() % 10;
            }
        }

        for(int i = 0; i < 4; i++)
        {
            foreach(int j in arr[i])
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        //одномерный массив строк
        string[] arrayS1 = { "abc", "def", "123", "456", "абвгд" };
        foreach (string item in arrayS1)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\nДлинна массива строк: " + arrayS1.Length);
        Console.WriteLine("Какой элемент заменить? (от 1 до 5): ");
        int replace = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите строку: ");
        arrayS1[replace - 1] = Console.ReadLine();

        foreach (string item in arrayS1)
        {
            Console.Write(item + " ");
        }

        //ступенчатый массив вещественных чисел
        double[][] jaggedArray = new double[3][];
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine($"\nВведите кол-во столбцов для строки {i + 1}: ");
            int count = int.Parse(Console.ReadLine());
            jaggedArray[i] = new double[count];

            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Random rnd = new Random();
                jaggedArray[i][j] = rnd.Next() % 10;
            }
        }
        Console.WriteLine("Вывод массива: ");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }

        //неявно типизированные переменные для массив и строк
        var arrayVar = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        var text = "ABCDEFG";
    }

    static void Fourth()
    {
        //создание кортежа
        (int, string, char, string, ulong) t = (123, "abc", 'd', "efg", 456);
        Console.WriteLine(t);
        Console.WriteLine($"{t.Item1}, {t.Item3}, {t.Item5}");

        //распаковка котрежа
        (int a, string b, char c, string d, ulong e) = t;
        Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);

        //_ для игнорирования ненужных элементов
        (_, string _, char _, _, ulong _) = t;

        //сравнение двух кортежей
        (int, string, char, string, ulong) _t = (123, "abc", 'd', "efg", 456);
        bool tEqual = t.Equals(_t);
        Console.WriteLine(tEqual);
    }

    static (int max, int min, int sum, char firstLetter) Fiveth(int[] array, string str)
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;

        foreach (int num in array)
        {
            if (num > max)
                max = num;

            if (num < min)
                min = num;

            sum += num;
        }

        char firstLetter = str.Length > 0 ? str[0] : '\0';

        return (max, min, sum, firstLetter);
    }

    static void UserChecked()
    {
        int value = int.MaxValue;

        try
        {
            checked
            {
                Console.WriteLine(value + 3);
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static void UserUnchecked()
    {
        unchecked
        {
            int value = int.MaxValue;
            Console.WriteLine(value + 3);
        }
    }
}