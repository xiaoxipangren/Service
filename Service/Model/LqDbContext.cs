using System.Data.Entity;
using MySql.Data.Entity;
using Lq.Data.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Lq.Service.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class LqDbContext : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//ȥ���������s

            //������λ��ᵼ��BasicInfo���˫����ʧ��
            //modelBuilder.Entity<BasicInfo>()
            //    .HasRequired(t => t.Region)
            //    .WithOptional();
                
        }

        public LqDbContext(): base("name=DbContext"){}

        //Ӧ��д��ÿһ��ʵ�����Ӧ��Db<Set>
        public virtual DbSet<Region> Managers { get; set; }
        public virtual DbSet<BasicInfo> OrderDetails { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<BusStation> BusStatios { get; set; }
        public virtual DbSet<BusStationMap> BusStationMaps { get; set; }


    }

}