using Task02.Model;

namespace Task02.Interface
{
    public interface IReadOnlyCell
    {
        public Product Product { get; }
        public int Count { get; }
    }
}