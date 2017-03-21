using Lq.Data.Attribute;
using Lq.Data.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Lq.Data.Model
{
    [EntityMap("orderdetail")]
    public class OrderDetail : BaseEntity
    {
        public int Uid { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }

        public DateTime Date { get; set; }
    }
}