using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Task02.Interface;

namespace Task02.Model
{
    public class Cells : IEnumerable<IReadOnlyCell>
    {
        private List<Cell> _values = new List<Cell>();
        
        // private IReadOnlyList<IReadOnlyCell> _valuesReadOnly => _values;
        public int Count => _values.Count;
        
        public void Add(Product product, int count)
        {
            if (count < 1)
                throw new ArgumentException(nameof(count));

            Cell productInCells = GetCell(product);

            if (productInCells == null)
                _values.Add(new Cell(product, count));
            else
                productInCells.Count += count;
        }

        public bool Remove(Cells cells)
        {
            if (!IsAvailableProducts(cells))
                return false;
            
            foreach (IReadOnlyCell cell in cells)
            {
                Cell cellFound = GetCell(cell.Product);
                cellFound.Count -= cell.Count;
            }
            
            return true;
        }
        
        public bool IsAvailableProduct(Product product, int count)
        {
            Cell productInCells = GetCell(product);

            return productInCells != null && productInCells.Count >= count;
        }

        public bool IsAvailableProducts(Cells cells)
        {
            if (cells == null || cells.Count == 0)
                throw new NullReferenceException(nameof(cells));

            foreach (IReadOnlyCell cell in cells)
            {
                if (!IsAvailableProduct(cell.Product, cell.Count))
                    return false;
            }

            return true;
        }
        
        public IReadOnlyCell this[int index]
        {
            get
            {
                return _values[index];
            }
        }

        public IEnumerator<IReadOnlyCell> GetEnumerator()
        {
            return _values.GetEnumerator(); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        private Cell GetCell(Product product)
        {
            return _values.FirstOrDefault(p => p.Product.Name == product.Name);
        }
    }
}