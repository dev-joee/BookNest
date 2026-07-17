using BookNest.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookNest;

public class BookNestDbContext : IdentityDbContext<BookNestUser>
{
    public BookNestDbContext(DbContextOptions options) : base(options) {}
    DbSet<Author> Authors { set; get; }
    DbSet<Book> Books { set; get; }
    DbSet<BorrowRecord> BorrowRecords { set; get; }
    DbSet<Category> Categorys { set; get; }
    DbSet<Member> Members { set; get; }
    DbSet<UserRecord> UserRecords { set; get; }
}
