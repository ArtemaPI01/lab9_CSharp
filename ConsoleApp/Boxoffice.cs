using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Boxoffice
    {
        private FIO fio;
        private int workers;
        private int count;

        public void Init(FIO fio, int workers, int count)
        {
            this.fio = fio;
            this.workers = workers;
            this.count = count;
        }

        public int Workers
        {
            set
            {
                if (value < 1)
                    Console.WriteLine("Число меньше 1.");
                else
                    workers = value;
            }
            get { return workers; }
        }

        public FIO Fio
        {
            get { return fio; }
        }

        public int Сount
        {
            set
            {
                if (value < 1)
                    Console.WriteLine("Число меньше 1.");
                else
                    count = value;
            }
            get { return count; }
        }

        public void Enter()
        {
            fio.enter();
            Console.Write("Введите кол-во кассиров: ");
            workers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во касс: ");
            count = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("\nИнформация о кассе:\nФИО старшего кассира:");
            fio.print();
            Console.WriteLine($"Кассиры: {workers}  Кассы: {count}");
        }
        public void CloakBoxoffice(int x)
        {
            int a;
            if (count - workers < 0)
                a = (x / count) * 2;
            else
                a = (x / workers) * 2;
            Console.WriteLine($"\nВремя обслуживания {x} клиентов - {a} минут.\n");
        }
        public static Boxoffice operator +(Boxoffice a, Boxoffice b)
        {
            Boxoffice result = new Boxoffice();
            result.fio = a.fio;
            result.workers = a.workers + b.workers; 
            result.count = a.count + b.count; 
            return result;
        }
        public static Boxoffice operator ++(Boxoffice a)
        {
            a.workers++;
            a.count++;
            return a;
        }
    }
}
