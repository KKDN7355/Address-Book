using Address_Book.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Address_Book.Data
{
    public class AddressBookDbContext: DbContext
    {
        public AddressBookDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}