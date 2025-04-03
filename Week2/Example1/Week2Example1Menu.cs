using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week2.Example1
{
    internal class Week2Example1Menu : Menu
    {
        private int[] values;
        private List<int> list;
        private int currentIndex;

        public Week2Example1Menu()
        {
            values = new int[0];
            list = new List<int>();
            currentIndex = 0;
        }

        public override void Execute()
        {
            ShowOptions();
        }

        private void ShowOptions()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("1. Introducir un elemento al arreglo");
                Console.WriteLine("2. Remover un elemento al arreglo");
                Console.WriteLine("3. Mostrar arreglo");
                Console.WriteLine("4. Introducir un elemento a la lista");
                Console.WriteLine("5. Remover un elemento a la lista");
                Console.WriteLine("6. Mostrar lista");

                string option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        AddElementToArray();
                        break;
                    case "2":
                        RemoveElementFromArray();
                        break;
                    case "3":
                        ShowArray();
                        break;
                }
            }
        }

        private void AddElementToArray()
        {
            int[] temp= new int[currentIndex + 1];
            for (int i = 0; i < values.Length; i++)
            {
                temp[i] = values[i];
            }
            values = temp;
            Console.WriteLine($"Introduce el elemento {currentIndex} al arreglo");
            int value = int.Parse(Console.ReadLine());
            values[currentIndex] = value;
            currentIndex++;
        } 

        private void RemoveElementFromArray()
        {
            int[] temp=new int[values.Length-1];
            Console.WriteLine("Introduce la posición del elemento a remover del arreglo");
            for(int i=0;i < values.Length; i++)
            {
                Console.WriteLine($"{i}. {values[i]}");
            }
            int position = int.Parse(Console.ReadLine());

            for (int i = 0; i < temp.Length; i++) 
            {
                if (i < position)
                {
                    temp[i] = values[i];
                }
                else if (i >= position)
                {
                    temp[i] = values[i + 1];
                }
            }
            values = temp;
        }

        private void ShowArray()
        {
            for(int i=0;i<values.Length;i++)
            {
                Console.WriteLine(values[i]);
            }
        }

        private void AddElementToList()
        {
            Console.WriteLine($"Introduce el elemento {currentIndex} al arreglo");
            int value = int.Parse(Console.ReadLine());
            list.Add(value);
        }

        private void RemoveElementToList()
        {
            Console.WriteLine("Introduce la posición del elemento a remover del arreglo");
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"{i}. {values[i]}");
            }
            int position = int.Parse(Console.ReadLine());
            list.RemoveAt(position);
        }

    }
}
