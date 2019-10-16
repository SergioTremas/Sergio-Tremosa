using System;
using System.Globalization;

namespace ciudades
{
    class Program
    {
        static void Main(string[] args)
        {
            string city0 = "", city1 = "", city2 = "", city3 = "", city4="", city5 ="";

            for (int a = 0; a <= 5; a++)
            {

                if (a == 0)
                {
                    Console.WriteLine($"Introduce el nombre de la ciudad numero {a +1}");
                    city0 = Console.ReadLine();
                }

                if (a == 1)
                {
                    Console.WriteLine($"Introduce el nombre de la ciudad numero {a+1}");
                    city1 = Console.ReadLine();
                }

                if (a == 2)
                {
                    Console.WriteLine($"Introduce el nombre de la ciudad numero {a+1}");
                    city2 = Console.ReadLine();
                }

                if (a == 3)
                {
                    Console.WriteLine($"Introduce el nombre de la ciudad numero {a+1}");
                    city3 = Console.ReadLine();
                }

                if (a == 4)
                {
                    Console.WriteLine($"Introduce el nombre de la ciudad numero {a+1}");
                    city4 = Console.ReadLine();
                }
                if (a == 5)
                {
                    Console.WriteLine($"Introduce el nombre de la ciudad numero {a+1}");
                    city5 = Console.ReadLine();


                }

            }

            Console.WriteLine("Has introducido: \n" + "\n " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(city0)  + "\n " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(city1) + "\n " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(city2) + "\n " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(city3) + "\n " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(city4) + "\n " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(city5));

            string[] aName= {city0,city1,city2,city3,city4,city5 };

            Array.Sort(aName);

            Console.WriteLine("Tus ciudades ordenadas alfabeticamente: ");

            foreach(string i in aName)  {

                Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(i));
            
             }


            Console.WriteLine("Tus ciudades con 4 en lugar de a: ");

            int l = 0;
            string[] ArrayCiutatsModificades = new string[6];

            foreach (string i in aName)
            {            

                var e = i.Replace("A", "4");
                e = e.Replace("a", "4");
     
                Console.WriteLine(e);

                ArrayCiutatsModificades[l] = e;

                l++;

            }

            Console.WriteLine("Tus ciudades al reves: ");

            Array[] _arrayLeters = new Array[6];

            for (int i =0; i < aName.Length; i++)
            {

                
              aName[i] =  CultureInfo.CurrentCulture.TextInfo.ToTitleCase(aName[i]);

                _arrayLeters[i] = aName[i].ToCharArray(0, aName[i].Length);
                Array.Reverse(_arrayLeters[i]);
                
            }



            foreach(Array i in _arrayLeters)
            {

                foreach(char x in i)
                {
                    Console.Write(x);
                }
                Console.WriteLine();

            }


            {

            }




        }
    }
}
