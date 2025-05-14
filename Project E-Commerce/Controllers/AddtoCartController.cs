using Microsoft.AspNetCore.Mvc;
using Project_E_Commerce.Data;
using Project_E_Commerce.Models;

namespace Project_E_Commerce.Controllers
{
    public class AddToCartController : Controller
    {
        private readonly AppDbContext _context;

        public AddToCartController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Add(int productId, int quantity)
        {
            // جيب اليوزر الحالي (لو عندك نظام تسجيل دخول)
            var userId = User.Identity.Name ?? "guest"; // مؤقتًا استخدم "guest"

            // شوف لو المنتج موجود في الكارت مسبقًا
            var existingItem = await _context.Cart_Item
                .FirstOrDefaultAsync(c => c.ProductId == productId && c.UserId == userId);

            if (existingItem != null)
            {
                // زود الكمية
                existingItem.Quantity += quantity;
            }
            else
            {
                var cartItem = new Cart_Item
                {
                    ProductId = productId,
                    Quantity = quantity,
                    UserId = userId,
                    DateAdded = DateTime.Now
                };

                _context.Cart_Item.Add(cartItem);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("ViewCart");
        }

        // عرض الكارت
        [HttpGet]
        public async Task<IActionResult> ViewCart()
        {
            var userId = User.Identity.Name ?? "guest";

            var cartItems = await _context.Cart_Item
                .Include(c => c.Product)
                .Where(c => c.UserId == userId)
                .ToListAsync();

            return View(cartItems);
        }
    }

}
