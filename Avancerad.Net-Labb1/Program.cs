namespace Avancerad.Net_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collection of 5 boxes
            LådaCollection lådor = new LådaCollection();
            lådor.Add(new Låda(2, 4, 5));
            lådor.Add(new Låda(3, 2, 7));
            lådor.Add(new Låda(5, 3, 3));
            lådor.Add(new Låda(1, 2, 3));
            lådor.Add(new Låda(4, 5, 6));
            Display(lådor);
            Console.WriteLine("---------------------------");

            //Try to add a box that already exists
            lådor.Add(new Låda(1, 2, 3));
            Console.WriteLine("---------------------------");
            //Try to add a box with same volume as another
            lådor.Add(new Låda(2, 1, 3));
            Console.WriteLine("---------------------------");

            //Remove a box
            lådor.Remove(new Låda(3, 2, 7));
            Display(lådor);
            Console.WriteLine("---------------------------");

            //Check if a specific box exists in the collection
            if (lådor.Contains(new Låda(2, 4, 5)))
            {
                Console.WriteLine("Lådan finns i collection");
            }
            else
            {
                Console.WriteLine("Lådan finns inte i collection");
            }

            Console.ReadKey();
        }
        public static void Display(LådaCollection lådor)
        {
            Console.WriteLine("Nr.\tHöjd\tLängd\tBredd\tVolym");
            int counter = 1;
            foreach(Låda låda in lådor)
            {
                Console.WriteLine($"{counter}.\t{låda.höjd} cm\t{låda.längd} cm\t{låda.bredd} cm\t{låda.höjd * låda.längd * låda.bredd} cm3");
                counter++;
            }
            
        }
    }
}