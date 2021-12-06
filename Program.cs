using System;
using SeriesDIO.Classes;
using SeriesDIO.Enums;

namespace SeriesDIO
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();

        static void Main(string[] args)
        {
            string opt;
            bool run = true;
            while(run)
            {
                opt = GetUserOption();
                Console.WriteLine();
                switch(opt)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        InsertSerie();
                        break;
                    case "3":
                        UpdateSerie();
                        break;
                    case "4":
                        ExcludeSerie();
                        break;
                    case "5":
                        ViewSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        run = false;
                        break;
                }
                Console.ReadKey();
            }
            Console.WriteLine("Finishing...");
            Console.ReadKey();
        }

        private static void ViewSerie()
        {
            Console.WriteLine("Type the serie's Id: ");
            int serieIndex = int.Parse(Console.ReadLine());
            Serie serie = repository.GetById(serieIndex);
            Console.WriteLine(serie);
        }

        private static void ExcludeSerie()
        {
            Console.WriteLine("Type the serie's Id: ");
            int serieIndex = int.Parse(Console.ReadLine());
            repository.Exclude(serieIndex);
        }

        private static void UpdateSerie()
        {
            Console.WriteLine("Type the serie's Id: ");
            int serieIndex = int.Parse(Console.ReadLine());
            foreach(int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
            }
            Console.WriteLine("Type the serie's genre between the options above: ");
            int genreInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the serie's title: ");
            string titleInput = Console.ReadLine();
            Console.WriteLine("Type the serie's year of beginning: ");
            int yearInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the serie's description: ");
            string descriptionInput = Console.ReadLine();
            Serie updateSerie = new Serie(
                id: serieIndex,
                genre: (Genre)genreInput,
                title: titleInput,
                year: yearInput,
                description: descriptionInput
            );
            repository.Update(serieIndex, updateSerie);
        }

        private static void InsertSerie()
        {
            Console.WriteLine("Insert new serie");
            foreach(int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
            }
            Console.WriteLine("Type the serie's genre between the options above: ");
            int genreInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the serie's title: ");
            string titleInput = Console.ReadLine();
            Console.WriteLine("Type the serie's year of beginning: ");
            int yearInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the serie's description: ");
            string descriptionInput = Console.ReadLine();
            Serie newSerie = new Serie(
                id: repository.NextId(),
                genre: (Genre)genreInput,
                title: titleInput,
                year: yearInput,
                description: descriptionInput
            );
            repository.Insert(newSerie);
        }

        private static void ListSeries()
        {
            Console.WriteLine("List series");
            var list = repository.List();
            if(list.Count == 0)
            {
                Console.WriteLine("There are no series registered!");
                return;
            }
            foreach(Serie serie in list)
            {
                Console.WriteLine("#ID {0} - {1}", serie.getId(), serie.getTitle());
            }
        }

        private static string GetUserOption()
        {
            Console.WriteLine("\nSelect your option: ");
            Console.WriteLine("1 - List series");
            Console.WriteLine("2 - Insert new serie");
            Console.WriteLine("3 - Update serie");
            Console.WriteLine("4 - Exclude serie");
            Console.WriteLine("5 - View serie");
            Console.WriteLine("C - Clear screen");
            Console.WriteLine("X - exit");
            string opt = Console.ReadLine().ToUpper();
            return opt;
        }
    }
}
