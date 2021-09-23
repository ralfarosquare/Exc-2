using System;



namespace ToString

{

    class Countries

    {

        string country, capital;

        public string FirstName { get { return country; } set { country = value; } }

        public string LastName { get { return capital; } set { capital = value; } }



        public Countries(string cName, string capName)

        {

            country = cName;

            capital = capName;

        }



        public string countryinfo

        {

            get

            {

                string x = country + " " + capital;

                return x;

            }

        }

    }



    class Program

    {

        static void Main(string[] args)

        {

            Countries x = new Countries("Mexico", "Mexico City");

            Countries y = new Countries("Maldivias", "Male");

            Countries z = new Countries("Japon", "Tokio");

            Console.WriteLine("{0}", x.countryinfo);

            Console.WriteLine("{0}", y.countryinfo);

            Console.WriteLine("{0}", z.countryinfo);

        }
    }
}
