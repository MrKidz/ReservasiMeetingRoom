//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservasiMeetingRoom.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MDKAReservasiEntities : DbContext
    {
        public MDKAReservasiEntities()
            : base("name=MDKAReservasiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblM_Ruangan> tblM_Ruangan { get; set; }
        public virtual DbSet<tblM_Status> tblM_Status { get; set; }
        public virtual DbSet<tblT_Reservasi> tblT_Reservasi { get; set; }
    }
}
