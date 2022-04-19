using System;

namespace Лабка_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
//Меню
        static void Menu()
        {
            char command;
            char key;
            do
            {
                Console.WriteLine("Меню завданнь");
                Console.WriteLine("Завдання 1");
                Console.WriteLine("Завдання 2");
                Console.WriteLine("Завдання 3");
                Console.WriteLine("Завдання 4");
                Console.WriteLine("Завдання 5");
                Console.WriteLine("Завдання 6");
                Console.WriteLine();
                Console.WriteLine("select of command, press number of key");
                command =(char) Console.Read();
                Console.ReadLine();
                switch (command)
                {
                    case '1': Task1(); break;
                    case '2': Task2(); break;
                    case '3': Task3(); break;
                    case '4': Task4(); break;
                    case '5': Task5(); break;
                    case '6': Task6(); break;
                    default: Console.WriteLine("Помилка"); break;
                }
                Console.WriteLine("Продовжити");
                key = (char)Console.Read();
                Console.ReadLine();
            } while (key!='n');
        }
        //вывод своих данных
        static void Task1()
        {
            string name, email, gr;
            int course, age;
            Console.WriteLine("Ваше імя та призвище");
            name = Console.ReadLine();
            Console.WriteLine("Ваша електронна пошта");
            email = Console.ReadLine();
            Console.WriteLine("Ваш вік");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш курс");
            course = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваша група");
            gr = Console.ReadLine();
            Console.WriteLine("ФІО: " + name + "  Пошта: " + email + "  Вік: " + age + "  Група: " + gr + "  Курс: " + course);
        }
//посчитать площадь прямоугольника
        static void Task2()
        {
            int a, b, p;
            Console.WriteLine("Введіть першу сторону");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть другу сторону");
            b = Convert.ToInt32(Console.ReadLine());
            p = a * b;
            Console.WriteLine("Площа прямокутника: " + p);
            Console.ReadKey();
        }
        //посчитать арифметическое выражение
        // x=(1-a)*(a+b)/(a-b)+куб.корінь з sin a^2
        static void Task3()
        {
            double a, b;
            Console.WriteLine("Введіть число а: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть число b: ");
            b = Convert.ToDouble(Console.ReadLine());
            double x = (1 - a) * (a + b) / (a - b) + Math.Pow(Math.Sin(Math.Pow((double) a, 2)), 1 / 3);
            Console.WriteLine("Значення виразу: "+ x);
        }

        static void Task4()
        {
            double a, b;
            Console.WriteLine("Введіть число а: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть число b: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
                Console.WriteLine("F(x)=" + 0);
            else if (a > b)
                Console.WriteLine("F(x)=" + Math.Pow((double) a, 2) / Math.Pow((double) b, 2));
            else if (a < b)
                Console.WriteLine("F(x)=" + (Math.Pow((double) b, 2) - Math.Pow((double) a, 2)));
            else if (a == b)
                Console.WriteLine("F(x)=" + 1);
            else 
                Console.WriteLine("Помилка");
        }
        static void Task5()
        {
            Console.WriteLine("Введіть номер кольору 1-7");
            int select= Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1: Console.WriteLine("Червоний: "+"#ff0000"); break;
                case 2: Console.WriteLine("Помаранчевий: "+"#ffa500"); break;
                case 3: Console.WriteLine("Жовтий: "+"#ffff00"); break;
                case 4: Console.WriteLine("Зелений: "+"#00ff00"); break;
                case 5: Console.WriteLine("Блакитний: "+"#00bfff"); break;
                case 6: Console.WriteLine("Синій: "+"##0000ff"); break;
                case 7: Console.WriteLine("Фіолетовий: "+"#8b00ff"); break;
                default: Console.WriteLine("Обрана команда не існує"); break;
            }
        }

        static void Task6()
        {
            int a, b, max, min;
            Console.WriteLine("Введіть к-сть суддів");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть мінімальний бал");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть максимальний");
            max = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Введіть балл судді " + (i+1));
                b = Convert.ToInt32(Console.ReadLine());
                if (b < min)
                {
                    
                }
            }
           
        }
    }
}