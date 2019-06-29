using System;
namespace First
{   class ItemType
    {
        protected string itemType = "PC";
    }
    class Items:ItemType
    {
        string brand_name;
        int cost;
        string memorySize;
        public void setDetails(string b, int c, string m)
        {
            this.brand_name=b;
            this.cost = c;
            this.memorySize = m;
        }
        public void getDetails()
        {
            Console.WriteLine($"Item Type: {itemType}\nBrand: {brand_name}\nCost: {cost}\nMemory size: {memorySize}\n-------".Replace("\n", Environment.NewLine));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Items p1 = new Items();
            p1.setDetails("Lenevo", 25000, "1TB");
            p1.getDetails();
            p1.setDetails("Sony", 30000, "2TB");
            p1.getDetails();
            p1.setDetails("Apple_MAC", 60000, "1TB");
            p1.getDetails();
            Console.ReadKey();
        }
           
        }
    }
