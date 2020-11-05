using System;

namespace Address
{
    class Program
    {
        static void Main(string[] args)
        {
            string street;
            string town;
            int dom;
            int count = 2;
            Address[] adres = new Address[count];
            Address adr;

            for (int i = 0; i < count / 2; i++)
            {
                adr = new Address();
                adr.Updade();
                adres[i] = adr;
            }

            for (int i = 1; i < count; i++)
            {
                Console.WriteLine("Введите свой город");
                town = Console.ReadLine();
                Console.WriteLine("Введите свою улицу");
                street = Console.ReadLine();
                Console.WriteLine("Номер дома");
                dom = Convert.ToInt32(Console.ReadLine());
                adr = new Address(town, street, dom);
                adres[i] = adr;
            }
            Console.WriteLine("Введите индекс");
            int index = Convert.ToInt32(Console.ReadLine());
            adres[index].Select();
            Console.ReadLine();
        }
    }
    class Address
    {
        public string street;
        public string town;
        public int dom;
        public Address()
        {

        }
        public Address(string town, string street, int index)
        {
            this.street = street;
            this.town = town;
            this.dom = index;
        }
        public void Updade()
        {
            Console.WriteLine("Введите свой город");
            town = Console.ReadLine();
            Console.WriteLine("Введите свою улицу");
            street = Console.ReadLine();
            Console.WriteLine("Номер дома");
            dom = Convert.ToInt32(Console.ReadLine());
        }
        public void Select()
        {
            Console.WriteLine(town);
            Console.WriteLine(street);
            Console.WriteLine(dom);
        }
    }
}
