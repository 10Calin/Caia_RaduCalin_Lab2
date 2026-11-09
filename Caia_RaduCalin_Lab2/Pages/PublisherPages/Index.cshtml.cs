using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Caia_RaduCalin_Lab2.Models;

namespace Caia_RaduCalin_Lab2.Pages.PublisherPages;

public class IndexModel : PageModel
{
    private readonly Caia_RaduCalin_Lab2Context _context;

    public IndexModel(Caia_RaduCalin_Lab2Context context)
    {
        _context = context;
    }

    public IList<Publisher> Publisher { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Publisher = await _context.Publisher.ToListAsync();
    }
}
