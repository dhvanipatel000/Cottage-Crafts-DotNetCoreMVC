using cottage_crafts.data;
using cottage_crafts.data.Services;
using cottage_crafts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace cottage_crafts.Controllers
{
    public class CartController : Controller
    {
        AppDbContext context = null;
        private ICraftRepository _craftRepo;

        public CartController(AppDbContext _context,ICraftRepository craftRepo)
        {
            context = _context;
            _craftRepo = craftRepo;

        }
        public IActionResult Index()
        {
            return View();
        }
        /*public IActionResult AddtoCart(int id,int quantity,int Id) 
        {
            Crafts craft = _craftRepo.GetCrafts(id);
            Cart cart = new Cart();
            List<Cart> cartlist = new List<Cart>();
           // cartlist = _cartRepo.GetCart();
           foreach(Cart c in cartlist)
            {
                if(c.Id == Id)
                {
                    if(c.cid == Id)
                    {
                        _cartRepo.Add(c);
                        return RedirectToAction("Index");
                    }
                    else
                    {

                    }
                }
            }
        }*/
    }
}
