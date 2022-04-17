using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Owner
    {
        private FIO fio;
        private int income;
        private int expenses;

        public int Income
        {
            set
            {
                if (value < 1)
                    Console.WriteLine("Число меньше 1.");
                else
                    income = value;
            }
            get { return income; }
        }

        public FIO Fio
        {
            get { return fio; }
        }

        public int Expenses
        {
            set
            {
                if (value < 1)
                    Console.WriteLine("Число меньше 1.");
                else
                    expenses = value;
            }
            get { return expenses; }
        }



        public void init(FIO fio, int income, int expenses)
        {
            this.fio = fio;
            this.income = income;
            this.expenses = expenses;
        }
        public void enter()
        {
            fio.enter();
            Console.Write("Введите доходы: ");
            income = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расходы: ");
            expenses = Convert.ToInt32(Console.ReadLine());
        }
        public void print()
        {
            Console.WriteLine("\nИнформация о владельце:\n");
            fio.print();
            int profit;
            profitOwner(out profit);
            Console.WriteLine($"Доходы: {income}  Расходы: {expenses} Прибыль: {profit}");
        }
        void profitOwner(out int profit)
        {
            profit = income - expenses;
        }
    }
}