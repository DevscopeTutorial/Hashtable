using System.Collections;

namespace HastableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating Hashtable
            Hashtable ht = new Hashtable();

            //Adding Data
            ht.Add("Fruit", "Apple, Orange, Banana");
            ht.Add("Flower", "Lilly, Rose, Lotus");
            ht.Add("Color","Red, Yellow, Blue");
            DisplayAll(ht);

            //Accessing a specific entry

            Console.WriteLine("Accessing Fruit...");
            Console.WriteLine(ht["Fruit"]);

            //Updating hashtable

            ht["Flower"] = "Rose, Tulip, Dahlia";
            Console.WriteLine("After updating...");
            DisplayAll(ht);

            //Removing an element
            Console.WriteLine("Removing color element...");
            if(ht.ContainsKey("Color"))
                ht.Remove("Color");
            else
                Console.WriteLine("Unknown key");
            DisplayAll(ht);

            //Size of the Hashtable

            Console.WriteLine("Size of the hastable: " + ht.Count);

            ht.Clear();
            Console.WriteLine("Size of the hastable after clearing: " + ht.Count);


        }

        private static void DisplayAll(Hashtable ht)
        {
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine(entry.Key + " => " + entry.Value);
            }
        }
    }
}