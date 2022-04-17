using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Shop
    {
        private static int counter;
        private string name;
        private string type;
        private string street;
        private string time;

        public Shop()
        {
            counter++;
        }
        ~Shop()
        {
            counter--;
        }

        public void init(string name, string type, string street, string time)
        {
            this.name = name;
            this.type= type;
            this.street = street;
            this.time = time;
        }

        public static int Counter
        {
            get;
            private set;
        } 

        public static void CountOfShop()
        {
            Console.WriteLine($"Кол-во магазинов: {counter}.\n");
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Street { get; set; }
        public string Time { get; set; }
        public void enter()
        {
            Console.Write("Введите название:");
            name = Console.ReadLine();
            Console.Write("Введите тип: ");
            type = Console.ReadLine();
            Console.Write("Введите улицу: ");
            street = Console.ReadLine();
            Console.Write("Введите время: ");
            time = Console.ReadLine();
        }
        public void print()
        {
            Console.WriteLine($"Название: {name}  Тип: {type}  Улица: {street}  Часы работы: {time}\n");
        }
        public void cloakShop()
        {
            string[] subs = time.Split(':', '-');
            int a = Convert.ToInt32(subs[2]) - Convert.ToInt32(subs[0]);
            int b = Convert.ToInt32(subs[3]) - Convert.ToInt32(subs[1]);
            if (b < 0)
            {
                b+=60;
                a--;
            }
            Console.WriteLine($"Часы работы: {time}\nЧасы: {a}    Минуты: {b}");
        }
    }
}
