namespace _14_Class_Object_Method_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product:Id,Name,Price

            //Bir listeye 5 adet product kayıdı yapılacak.

            List<Product> products = new List<Product>();
            Product.Kayit(products);

        }
    }
    class Product
    {
        public int Id;
        public string Name;
        public double Price;
    
        public static void Kayit(List<Product> products)
        {
            Product p = new Product();

            Console.WriteLine("ID:");
            p.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ad:");
            p.Name = Console.ReadLine();

            Console.WriteLine("Fiyat:");
            p.Price = Convert.ToDouble(Console.ReadLine());

            products.Add(p);
        }
    
    }
}
