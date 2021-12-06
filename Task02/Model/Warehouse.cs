namespace Task02.Model
{
    public class Warehouse
    {
        public Cells Cells = new Cells();

        public bool IsAvailableProduct(Product product, int count)
        {
            return Cells.IsAvailableProduct(product, count);
        }

        public void Delive(Product product, int count)
        {
            Cells.Add(product, count);
        }

        public bool Ship(Cells cells)
        {
            return Cells.Remove(cells);
        }

    }
}