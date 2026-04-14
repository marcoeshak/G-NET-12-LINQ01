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

            #region Q03
            /*
            var result = ProductList
            .OrderBy(p => p.UnitPrice);

            foreach (var p in result)
            {
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            }
            */
            #endregion

            #region Q04
            /*
            var result = ProductList
            .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            */
            #endregion

            #region Q05
            /*
            var result = ProductList
            .Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            */
            #endregion

            #region Q06
            /*
                    var result = ProductList
                    .Select(p => new
                     {
                    Name = p.ProductName,
                    Price = p.UnitPrice,
                   StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
                     });

                       foreach (var item in result)
                      {
                    Console.WriteLine($"{item.Name} - {item.Price} - {item.StockStatus}");
                     }

            */

            #endregion

            #region Q07
            /*

            var result = ProductList
         .Select((p, index) => new
            {
            Index = index + 1,
           Name = p.ProductName
             }
            );

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Index}. {item.Name}");
            }

            */
            #endregion

        }
    }
}
