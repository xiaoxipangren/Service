using Lq.Data.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using Lq.Data.Extension;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lq.Data.Entity
{
    public class BaseEntity : IEntity
    {
        private static Dictionary<string, Type> entityMap;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get;set;
        }

        public static Dictionary<string,Type> EntityMap
        {
            get
            {
                if (entityMap == null)
                {
                    entityMap =typeof(BaseEntity).Assembly.GetTypes()
                        .Where(t=>t.GetInterface("Lq.Data.Entity.IEntity")!=null && t.GetCustomAttribute<EntityMapAttribute>()!=null)//独立实体类必须实现IEntity接口
                        .ToDictionary(t => 
                        {
                            return string.IsNullOrEmpty(t.GetCustomAttribute<EntityMapAttribute>().EntityName)
                            ? t.Name.ToLower()
                            :t.GetCustomAttribute<EntityMapAttribute>().EntityName.ToLower();
                        });

                }
                return entityMap;
            }
        }
    }
}
