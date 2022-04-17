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

        public FIO() { }
        public FIO(string surname) {
            this.surname = surname;
        }
        public FIO(string name, string surname, string patronymic) {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname {
            get { return surname; }
            set { surname = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

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
            if (name == "" && surname == "" && patronymic == "")
            {
                if (name != "")
                    Console.Write($"Имя: {name}  ");
                if (surname != "")
                    Console.Write($"Фамилия: {surname}  ");
                if (patronymic != "")
                    Console.Write($"Отчество: {patronymic}  ");
            }
        }
    }
}
