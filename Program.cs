namespace ConsoleApp7
{
    internal class Program
    {
        public static T Max<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;

            if (b.CompareTo(max) >= 0)
                max = b;
            

            if (c.CompareTo(max) >= 0)
                max = c;
            

            return max;
        }

        static void Main(string[] args)
        {
            //Задание 1
            //EnglishRussianDictionary dictionary = new EnglishRussianDictionary();

            //dictionary.AddWord("hello", new List<string> { "привет", "здравствуйте" });
            //dictionary.AddWord("country", new List<string> { "страна", "государство" });

            //dictionary.AddTranslation("country", "земля");
            //dictionary.SearchTranslation("hello");

            //dictionary.EditWord("hello", "hi");

            //dictionary.SearchTranslation("hi");

            //dictionary.RemoveTranslation("country", "государство");

            //dictionary.SearchTranslation("country");
            //dictionary.RemoveWord("country");

            //dictionary.SearchTranslation("country");

            //Задание 2
            //Console.WriteLine(Max(6, 40, 20));
            //Console.WriteLine(Max(300.5, 76.2, 100.9));


            //Задание 3
            //Oceanarium oceanarium = new Oceanarium();
            //oceanarium.AddCreature(new SeaCreature("Дельфин", "Млекопитающее", "Открытые моря"));
            //oceanarium.AddCreature(new SeaCreature("Краб", "Ракообразное", "Мелководие"));
            //oceanarium.AddCreature(new SeaCreature("Кальмар", "Моллюски", "Глубоководие"));

            //foreach (SeaCreature creature in oceanarium)
            //{
            //    Console.WriteLine(creature);
            //}

        }
    }
}