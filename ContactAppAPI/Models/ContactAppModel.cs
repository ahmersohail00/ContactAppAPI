namespace ContactAppAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContactAppModel : DbContext
    {
        public ContactAppModel()
            : base("name=ContactAppModel")
        {
        }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
