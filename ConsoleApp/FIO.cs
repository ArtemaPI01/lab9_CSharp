using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class FIO
    {
        private string name;
        private string surname;
        private string patronymic;
        public void init(string name, string surname, string patronymic)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public void enter()
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            patronymic = Console.ReadLine();
        }
        public void print()
        {
            Console.WriteLine($"Имя: {name}  Фамилия: {surname}  Отчество: {patronymic} ");
        }
    }
}
