using Task02.Interface;

namespace Task02.Model
{
    public class Cell : IReadOnlyCell
    {
        public Product Product { get; }
        public int Count { get; set; }

        public Cell(Product product, int count)
        {
            Product = product;
            Count = count;
        }

    }
}