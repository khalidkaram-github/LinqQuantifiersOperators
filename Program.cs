namespace LinqQuantifiersOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Contains
            var numbers = new int[] { 1, 2, 3, 4, 5, -1 };
            var item = 89;
            var result = numbers.Contains(item);
            //Console.WriteLine(result); 
            #endregion

            #region contains
            var products = new List<Product>
            {
              new Product { Id = 1, Name = "Laptop" },
              new Product { Id = 2, Name = "Tablet" }
            };

            var obj = products[0];

            bool containsProduct = products.Contains(obj);

            // Console.WriteLine(containsProduct);
            #endregion

            #region SequenceEqual

            string[] words1 = { "apple", "banana", "cherry" };
            string[] words2 = { "apple", "banana", "cherry", "" };
            string[] words3 = { "Apple", "Banana", "Cherry" };

            // Case-sensitive comparison
            bool areWordsEqual = words1.SequenceEqual(words2);
            // Console.WriteLine(areWordsEqual); // Output: True

            areWordsEqual = words1.SequenceEqual(words3);
            // Console.WriteLine(areWordsEqual); // Output: False (Case matters) 
            #endregion
        }
    }
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
