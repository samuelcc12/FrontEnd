using System.Data.Entity;

namespace AppiTareaFinal.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection") 
        {

        }

        public System.Data.Entity.DbSet<AppiTareaFinal.Models.Contact> Contacts { get; set; }
    }
}