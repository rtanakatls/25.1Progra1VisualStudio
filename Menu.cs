using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    internal class Menu
    {
        private List<Person> persons;

        public void Execute()
        {
            persons=new List<Person>();
            PersonMenu();
        }

        private void PersonMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("1. Agregar persona");
                Console.WriteLine("2. Agregar alumno");
                Console.WriteLine("3. Mostrar todas las personas");
                Console.WriteLine("0. Salir");

                string option= Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        AddStudent();
                        break;
                    case "3":
                        ShowPeople();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;

                }
            }
        }

        private void AddPerson()
        {
            persons.Add(GetPerson());
        }

        private void AddStudent()
        {
            persons.Add(GetStudent());
        }

        private void ShowPeople()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ShowInfo());
            }
        }

        private Person GetPerson()
        {
            Person person;

            string name = GetName();
            int age = GetAge();
            person = new Person(name, age);

            return person;
        }


        private Student GetStudent()
        {
            Student student;

            string name = GetName();
            int age = GetAge();
            string code = GetCode();
            student = new Student(name, age, code);

            return student;
        }

        private string GetCode()
        {
            string code;
            Console.WriteLine("Introduce tu Código:");
            code = Console.ReadLine();
            return code;
        }


        private string GetName()
        {
            string name;
            Console.WriteLine("Introduce tu nombre:");
            name = Console.ReadLine();
            return name;
        }

        private int GetAge()
        {
            int age = -1;

            while (age < 0)
            {
                Console.WriteLine("Introduce tu edad:");
                age = int.Parse(Console.ReadLine());
                if (age < 0)
                {
                    Console.WriteLine("Escribe bien tu edad");
                }
            }
            return age;
        }




    }
}
