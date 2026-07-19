using BookNest.Data.Models;
using BookNest.Data.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookNest;

public class BookNestDbContext : IdentityDbContext<BookNestUser>
{
    public BookNestDbContext(DbContextOptions options) : base(options) {}
    public DbSet<Author> Authors { set; get; }
    public DbSet<Book> Books { set; get; }
    public DbSet<BorrowRecord> BorrowRecords { set; get; }
    public DbSet<Category> Categorys { set; get; }
    public DbSet<Member> Members { set; get; }
    public DbSet<UserRecord> UserRecords { set; get; }
}
