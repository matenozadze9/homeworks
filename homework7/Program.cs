namespace homework7
{
    class Product
    {
        // produqtis tvisebebi
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public bool nuts { get; set; }
        public string image { get; set; }
        public bool vegeterian { get; set; }
        public int spiciness { get; set; }
        public string category { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Produqti: {name} | Fasi: {price} lari |ategoria: {category}");
        }
    }

    class Program
    {
        static void Main()
        {
            Product item = new Product();
            item.id = 1;
            item.name = "Burgeri";
            item.price = 12.5;
            item.nuts = false;
            item.image = "burger.jpg";
            item.vegeterian = false;
            item.spiciness = 1;
            item.category = "swrafi kveba";

            item.PrintInfo();
        }
    }
}