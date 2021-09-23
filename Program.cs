using System;

namespace Exc2_csharp
{
    class Employee

    {



        public int employeeid;

        public double WorkedYears;

        public string name;



        public Employee(double a, int x, string s)

        {

            name = s;

            employeeid = x;

            WorkedYears = a;

        }





        public Employee(string s, int x, double a)

        {

            WorkedYears = a;

            employeeid = x;

            name = s;

        }



        public void Show()

        {

            Console.WriteLine("Employee id: " + employeeid);

            Console.WriteLine("Time in Company : " + WorkedYears + "years");

            Console.WriteLine("Name: " + name);

        }

    }





    class Contructors

    {





        static void Main()

        {



            Employee employee1 = new Employee(11.9, 020310, "MR. Unosquare");

            Employee employee2 = new Employee("Rodrigo Alfaro", 040090, 0.2);



            Console.WriteLine("First Constructor: ");

            employee1.Show();



            Console.WriteLine();



            Console.WriteLine("Second Constructor: ");

            employee2.Show();





            //Palindrome String ----------------------------------------------------------





            string string1, revs = "";

            Console.WriteLine(" Enter  the string to validate if it's palindrome or not");

            string1 = Console.ReadLine();

            for (int i = string1.Length - 1; i >= 0; i--)

            {

                revs += string1[i].ToString();

            }

            if (revs == string1)

            {

                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", string1, revs);

            }

            else

            {

                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", string1, revs);

            }

            Console.ReadKey();







        }

    }

}



