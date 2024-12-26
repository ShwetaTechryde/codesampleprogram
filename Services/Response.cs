using codesampleprogram.Interface;
using codesampleprogram.Models;
using codesampleprogram.Controller;

namespace codesampleprogram.Services
{
    public class Response : Productsinf
    {
        private readonly ApplicationDbContext _context;

        public Response()
        {
            _context = new ApplicationDbContext();
        }

        public void Addproducts(Products product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        //public void DeleteProducts(int id)
        //{
        //    var product = _context.Products.Find(id);
        //    if (product != null)
        //    {
        //        _context.Products.Remove(product);
        //        _context.SaveChanges();
        //    }
        //}
    }
}
