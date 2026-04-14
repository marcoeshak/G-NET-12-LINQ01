namespace G_NET_12_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q01
            /*
            var result = ProductList
            .Where(p => p.Category == "Seafood");

            foreach (var p in result)
            {
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            }

            */

            #endregion

            #region Q02
            /*
            var result = ProductList
            .Select(p => p.ProductName);

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
             */

            #endregion


        }
    }
}
