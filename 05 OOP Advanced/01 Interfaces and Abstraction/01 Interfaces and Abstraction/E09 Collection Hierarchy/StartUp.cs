
namespace E09_Collection_Hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IAddCollection<string> addCollection = new AddCollection<string>();
            IAddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
            IMyList<string> myList = new MyList<string>();

            var itemsToAdd = Console.ReadLine().Split(' ');
            var removeOperationsCount = int.Parse(Console.ReadLine());

            var addCollAddIndexes = new StringBuilder();
            var addRemCollAddIndexes = new StringBuilder();
            var myListAddIndexes = new StringBuilder();

            foreach (var item in itemsToAdd)
            {
                addCollAddIndexes.Append($"{addCollection.Add(item)} ");
                addRemCollAddIndexes.Append($"{addRemoveCollection.Add(item)} ");
                myListAddIndexes.Append($"{myList.Add(item)} ");
            }

            Console.WriteLine(addCollAddIndexes.ToString().Trim());
            Console.WriteLine(addRemCollAddIndexes.ToString().Trim());
            Console.WriteLine(myListAddIndexes.ToString().Trim());

            var addRemCollRemoveElements = new StringBuilder();
            var myListRemoveElements = new StringBuilder();

            for (int i = 0; i < removeOperationsCount; i++)
            {
                addRemCollRemoveElements.Append($"{addRemoveCollection.Remove()} ");
                myListRemoveElements.Append($"{myList.Remove()} ");
            }

            Console.WriteLine(addRemCollRemoveElements.ToString().Trim());
            Console.WriteLine(myListRemoveElements.ToString().Trim());
        }
    }
}
