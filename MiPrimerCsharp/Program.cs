using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerCsharp
{
  

    class Program
    {
        static void Main(string[] args)
        {

            Rectangulo rectangulo = new Rectangulo();
            rectangulo.x1 = 0;
            rectangulo.y1 = 4;
            //Todas las coordenas

            rectangulo.CalcularArea();
            rectangulo.CalcularPerimetro();




            //Declaración de variables
            int age = 32;
            string firstName = "Hugo";
            float salary = 8000;

            //Declarar el objeto
            Person person1 = new Person();
            person1.PersonId = 1;
            person1.LastName = "Torrico";
            person1.FirstName = "Hugo";

            Person person2 = new Person
            {
                PersonId = 2,
                LastName = "Torrico",
                FirstName = "Reyna"
            };

            Person person3 = new Person
            {
                PersonId = 3,
                LastName = "Torrico",
                FirstName = "Derek"
            };

            //Lista de Objetos
            List<Person> people1 = new List<Person>();
                        
            people1.Add(person1);
            people1.Add(person2);
            people1.Add(person3);

            //funciones
            foreach (var item in people1)
            {
                Console.WriteLine(item.GetFullName());
            }
            //Procedimientos
            foreach (var item in people1)
            {
                //Ejecute el procedimiento
                item.CreateFullName();
                Console.WriteLine(item.FullName);
            }




            //Console.WriteLine(age.ToString());
            //Console.WriteLine(firstName);
            //Console.WriteLine(salary.ToString());
            Console.Read();

        }
    }
}
