using System.Data.Entity;

namespace PluralsightEF.DataModel
{
    public class Class1:DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans{ get; set; }
        public DbSet<NinjaEquipment> Equipments { get; set; }
    }
}
