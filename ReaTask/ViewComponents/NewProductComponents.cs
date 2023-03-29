using Microsoft.AspNetCore.Mvc;
using ReaTask.Data;

namespace ReaTask.ViewComponents
{
    public class NewProductComponents:ViewComponent
    {
        private readonly ReaTaskDbContext _context;

        public NewProductComponents(ReaTaskDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var NewProduct = _context.Products.Where(d => d.IsNew == true);
            return View(NewProduct);
        }
    }
}
