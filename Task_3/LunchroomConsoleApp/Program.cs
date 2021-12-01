using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchroomLibrary;
using SerializationLibrary;

namespace LunchroomConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<LunchroomProduct>();
           

            var dish = new Dish("Борщь");

            dish.Recipe.AddIngredient(new Ingridient("Тесто", 1, 1, new StorageConditions(-2, 2)));

            var pizza = new Dish("Пицца");

            pizza.Recipe.AddIngredient(new Ingridient("Тесто", 1, 1, new StorageConditions(-2, 2)));
            pizza.Recipe.AddIngredient(new Ingridient("Салями", 2, 1, new StorageConditions(-2, 2)));
            pizza.Recipe.AddProcessing(new Processing(ProcessingType.Beat, 5, 1));
            pizza.Recipe.AddIngredient(new Ingridient("Сыр", 2, 1, new StorageConditions(-2, 2)));
            pizza.Recipe.AddProcessing(new Processing(ProcessingType.Fry, 7, 0.50));

            var chef = new Chef();

            chef.Prepare(pizza);

            list.Add(dish);
            list.Add(pizza);

            JsonFileSerializer.Serialize("dishes.txt", list);

            var list2 = JsonFileSerializer.Deserialize<Dish>("dishes.txt");

            foreach (Dish product in list2)
            {
                Console.WriteLine(product);
            }

            Console.ReadLine();
        }
    }
}
