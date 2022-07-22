using BusinessLayer;

namespace ProjectPro
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryManager cm = new CategoryManager();
            foreach (var item in cm.GetAll())
            {
                Console.WriteLine("ID:" +" "+ item.CategoryID+ " - Kategori Adı:" + item.CategoryName );
            }
           

            ProductManager pm = new ProductManager();
            foreach (var item in pm.GetAll())
            {
                Console.WriteLine("ID:"+ " "+ item.ProductID+ " Ürün Adı:"+ item.ProductName);
            }
            Console.Read();

        }
    }
}