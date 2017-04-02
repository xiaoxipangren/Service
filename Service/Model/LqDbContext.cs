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
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//去掉表名后的s

            //下面这段话会导致BasicInfo表的双主键失败
            //modelBuilder.Entity<BasicInfo>()
            //    .HasRequired(t => t.Region)
            //    .WithOptional();
                
        }

        public LqDbContext(): base("name=DbContext"){}

        //应该写出每一个实体类对应的Db<Set>
        


    }

}