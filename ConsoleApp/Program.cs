using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FIO fio = new FIO();
            fio.init("A", "Б", "В");
            Owner Alisher = new Owner();
            Alisher.init(fio, 0, 0);
            Alisher.enter();
            Alisher.print();
            int N = 2;
            Shop[] shop = new Shop[N];
            for (int i = 0; i < N; i++)
            {
                shop[i] = new Shop();
                shop[i].init("1", "2", "3", "10:00-20:00");
                shop[i].print();
                shop[i].cloakShop();
            }
            Shop.CountOfShop();
            Warehouse home = new Warehouse();
            home.enter();
            home.print();
            home.Poisk("AVS");
            int a = 20;
            int time = 0;
            home.cloakWarehouse(ref time, a);
            Console.WriteLine($"Время разгрузки {a} тонн товара: { time } минут");
            Boxoffice box = new Boxoffice();
            box.Init(fio, 10, 10);
            Console.WriteLine($"Кол-во рабочих: {box.Workers}");
            box.Workers = 20;
            box++;
            box.Print();
            Boxoffice box1 = new Boxoffice();
            box1.Init(fio, 10, 10);
            box1 += box;
            box1.Print();
            box1.CloakBoxoffice(100);
        }
    }
}