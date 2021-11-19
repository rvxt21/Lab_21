using System;
using System.Collections.Generic;
using System.Text;

namespace SeventeenLab
{
    class Personcs
    {
        //2.	Измените конструкторы, методы доступа типа set, метод ввода с клавиатуры так,
        //чтобы они вызывали инвариаты класса и выбрасывали (throw)
        //исключения в случае приема неправильных данных для объекта. 
        private int age;
        private string name;
        private string surname;
        public string type;

        public Personcs(int age,string name,string surname)
        {
            if (this.age < 0)
            {
                throw new Exception("Отрицательный возраст");
                //Конструктор не выполняется дальше 
            }
            this.age = age;
            this.name = name;
            this.surname = surname;
        }
        public Personcs()
        {
            Console.WriteLine("enter age:");
            age = Convert.ToInt32(Console.ReadLine());
            if (this.age < 0)
            {
                throw new Exception("Отрицательный возраст");
                //Конструктор не выполняется дальше 
            }
            Console.WriteLine("enter name:");
            name = Console.ReadLine();
            if (name.GetType() != type.GetType())
            {
                throw new Exception("name isn`t string!");
            }
            Console.WriteLine("enter surname:");
            surname = Console.ReadLine();
            if (surname.GetType() != type.GetType())
            {
                throw new Exception("surname isn`t string!");
            }
        }
        private string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
