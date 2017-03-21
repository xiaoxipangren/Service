using Lq.Data.Attribute;
using Lq.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Lq.Data.Model
{
    [EntityMap("manager")]
    public class Manager:BaseEntity
    {
        [MaxLength(30)]
        public string Name { get; set; }
        public int Age { get; set; }
        [MaxLength(5)]
        public string Sex { get; set; }
    }
}