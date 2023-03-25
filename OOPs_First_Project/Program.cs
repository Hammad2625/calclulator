using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_First_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.sum(1, 2));

            Vehicle car = new Vehicle();
            Console.WriteLine(car.Car());

            Animal animal = new Animal();
            Console.WriteLine(animal.Lion());


            Console.WriteLine("Enter the value of A");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of B");
            int b = Convert.ToInt32(Console.ReadLine());

           

            Calculator divide = new Calculator();
            Console.WriteLine(divide.Divide(a, b));


            Calculator muliply = new Calculator();
            Console.WriteLine(muliply.muliply(a, b));


            Calculator addition = new Calculator();
            Console.WriteLine(addition.add(a, b));


            Calculator subtraction = new Calculator();
            Console.WriteLine(subtraction.subtract(a, b));

        }
    }
}
