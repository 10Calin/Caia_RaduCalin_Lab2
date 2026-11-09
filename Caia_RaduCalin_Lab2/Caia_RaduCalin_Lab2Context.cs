using Microsoft.EntityFrameworkCore;

public class Caia_RaduCalin_Lab2Context(DbContextOptions<Caia_RaduCalin_Lab2Context> options) : DbContext(options)
{
    public DbSet<Caia_RaduCalin_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Caia_RaduCalin_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Caia_RaduCalin_Lab2.Models.Author> Author { get; set; } = default!;
}