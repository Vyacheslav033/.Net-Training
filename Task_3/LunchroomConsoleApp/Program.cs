using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchroomLibrary;

namespace LunchroomConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var pizza = new Dish("Пицца");

            Console.WriteLine();

            pizza.Structure.AddObject(new Ingridient("Тесто", 1, 1, new StorageConditions(-2, 2)));
            pizza.Structure.AddObject(new Ingridient("Салями", 2, 1, new StorageConditions(-2, 2)));

            pizza.CookingSequence.AddObject(new Processing(ProcessingType.Beat, 5, 1));
            pizza.CookingSequence.AddObject(new Processing(ProcessingType.Fry, 7, 0.50));




            Console.WriteLine(pizza);
            Console.WriteLine("IngredientsCount - " + pizza.Structure.Count);
            Console.WriteLine("IngredientsCost - " + pizza.Structure.IngredientsCost);
            Console.WriteLine("ProcessingCount - " + pizza.CookingSequence.Count);
            Console.WriteLine("ProcessingCost - " + pizza.CookingSequence.ProcessingCost);

            foreach (Ingridient ing in pizza.Structure.Ingredients)
            {
                Console.WriteLine(ing);
            }

            foreach (Processing pr in pizza.CookingSequence.ProcessingMethods)
            {
                Console.WriteLine(pr);
            }

            Console.ReadKey();

            Console.ReadLine();
        }
    }
}
