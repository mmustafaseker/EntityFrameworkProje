using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            // bu bize bir veri tabanından geliyormuş gibi kendimiz oluşturduk
            _products = new List<Product> 
            { 
                new Product{ ProductId=1,CategoryId=1,ProductName="Bardak",Uniteprice=15,UnitsInStock=15},
                new Product{ ProductId=2,CategoryId=1,ProductName="Kamera",Uniteprice=500,UnitsInStock=3},
                new Product{ ProductId=3,CategoryId=2,ProductName="Telefon",Uniteprice=1500,UnitsInStock=15},
                new Product{ ProductId=4,CategoryId=2,ProductName="Kalavye",Uniteprice=150,UnitsInStock=65},
                new Product{ ProductId=5,CategoryId=2,ProductName="Fare",Uniteprice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            //busness benden istiyor
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
          return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //gönderdiğim ürün ıd'sine sahip ola ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.Uniteprice = product.Uniteprice;
            productToUpdate.UnitsInStock = product.UnitsInStock;


           
        }
    }
}
