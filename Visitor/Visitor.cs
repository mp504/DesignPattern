using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
   

    public interface IItemVisitor
    {
        void Visit(Book book);
        void Visit(Electronics electronics);
        void Visit(Clothing clothing);
    }


    public interface IShoppingCartItem
    {
        void Accept(IItemVisitor visitor);
    }


    public class Book : IShoppingCartItem
    {
        public decimal Price { get; set; }
        public Book(decimal price) { Price = price; }

        public void Accept(IItemVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Electronics : IShoppingCartItem
    {
        public decimal Price { get; set; }
        public Electronics(decimal price) { Price = price; }

        public void Accept(IItemVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Clothing : IShoppingCartItem
    {
        public decimal Price { get; set; }
        public Clothing(decimal price) { Price = price; }

        public void Accept(IItemVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class ShoppingCartVisitor : IItemVisitor
    {
        public decimal TotalPrice { get; private set; }

        public void Visit(Book book)
        {
            // Apply a discount for books
            TotalPrice += book.Price * 0.9m; // 10% discount
        }

        public void Visit(Electronics electronics)
        {
            // No discount for electronics
            TotalPrice += electronics.Price;
        }

        public void Visit(Clothing clothing)
        {
            // Apply a discount for clothing
            TotalPrice += clothing.Price * 0.85m; // 15% discount
        }
    }


}
