//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pro_9Entities : DbContext
    {
        private static pro_9Entities _content;
        public pro_9Entities()
            : base("name=pro_9Entities")
        {

        }
        public static pro_9Entities GetContext()
        {
            if (_content == null)
                _content = new pro_9Entities();
            return _content;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientService> ClientService { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Service> Service { get; set; }
    }
}
