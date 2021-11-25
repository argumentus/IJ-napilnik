using System;
using System.Collections.Generic;
using System.Linq;
using Task02.Interface;

namespace Task02.Model
{
    public class Warehouse
    {
        private List<Cell> _cells = new List<Cell>();
        
        public IReadOnlyList<IReadOnlyCell> Cells => _cells; 

        public bool IsAvailableProduct(Product product, int count)
        {
            Cell productInWarehouse = GetCell(product);

            return productInWarehouse != null && productInWarehouse.Count >= count;
        }

        public bool IsAvailableProducts(List<Cell> cells)
        {
            if (cells == null || cells.Count == 0)
                throw new NullReferenceException(nameof(cells));

            foreach (Cell cell in cells)
            {
                if (!IsAvailableProduct(cell.Product, cell.Count))
                    return false;
            }

            return true;
        }
        
        public void Delive(Product product, int count)
        {
            if (count < 1)
                throw new ArgumentException(nameof(count));

            Cell cell = GetCell(product);

            if (cell == null)
                _cells.Add(new Cell(product, count));
            else
                cell.Count += count;
        }

        public bool Ship(List<Cell> cells)
        {
            if (!IsAvailableProducts(cells))
                throw new ArgumentException(nameof(cells));

            return TakeProducts(cells);
        }
        
        private bool TakeProducts(List<Cell> cells)
        {
            if (!IsAvailableProducts(cells))
                return false;
            
            foreach (Cell cell in cells)
            {
                Cell cellWarehouse = GetCell(cell.Product);
                cellWarehouse.Count -= cell.Count;
            }
            
            return true;
        }
        
        private Cell GetCell(Product product)
        {
            return _cells.FirstOrDefault(p => p.Product.Name == product.Name);
        }

    }
}