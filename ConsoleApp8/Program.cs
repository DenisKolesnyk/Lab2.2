using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var components = new Сomplementary("", "", 0, 0);

            for (int j = 0; j < components.arr.Length; j++)
            {
                Console.Write("Введiть позначення: ");
                string marking = Console.ReadLine();
                Console.Write("Введiть тип: ");
                string type = Console.ReadLine();
                Console.Write("Введiть номінал: ");
                int par = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введiть кількість: ");
                int number = (int)Convert.ToDouble(Console.ReadLine());
                components.arr[j] = new Сomplementary(marking, type, par, number);
            }

            Сomplementary.count--;

            void MostNumber()
            {
                int y = int.MaxValue;
                for (int i = 0; i < components.arr.Length; i++)
                {

                    if (components.arr[i].number < y)
                        y = components.arr[i].number;

                }
                Console.WriteLine("Найбільша кількість " + Math.Abs(y));
            }

            Console.WriteLine("Об'єкти: " + (Сomplementary.count) + "\n");
            MostNumber();
            if (Сomplementary.count < 3)
                Console.WriteLine("Об'єктiв менше нiж в таблицi");
            else if (Сomplementary.count == 3)
                Console.WriteLine("Об'єктiв рiвно скiльки в таблицi");
            else if (Сomplementary.count > 3)
                Console.WriteLine("Об'єктiв бiльше нiж в таблицi");
        }
    }

    class Сomplementary
    {
        public Сomplementary[] arr = new Сomplementary[9];
        public static int count = 0;
        public string type;
        public string marking;
        public int par;
        public int number;
        public Сomplementary(string marking, string type, int par, int number)
        {
            this.type = type;
            this.marking = marking;
            this.par = par;
            this.number = number;
            count++;
        }
    }
}

