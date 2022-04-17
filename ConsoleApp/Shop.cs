﻿using System;
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

        public Shop(string name, string type, string street, string time)
        {
            counter++;
            this.name = name;
            this.type = type;
            this.street = street;
            this.time = time;
        }

        public Shop(string time)
        {
            counter++;
            this.time = time;
        }

        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        } 

        public static void CountOfShop()
        {
            Console.WriteLine($"Кол-во магазинов: {counter}.\n");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
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
