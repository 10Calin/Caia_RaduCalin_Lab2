using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Caia_RaduCalin_Lab2.Models;

namespace Caia_RaduCalin_Lab2.Pages.BookPages
{
    public class IndexModel : PageModel
    {
        private readonly Caia_RaduCalin_Lab2Context _context;

        public IndexModel(Caia_RaduCalin_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .Include(b => b.Author)
                    .ToListAsync();
            }
        }
    }
}