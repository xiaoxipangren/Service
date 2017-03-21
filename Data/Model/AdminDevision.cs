using Lq.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lq.Data.Model
{
    public class Region
    {
        [Key]
        public string Code { get; set; }

        [MaxLength(50)]
        public string Level { get; set; }
        [MaxLength(50)]
        public string Category { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string PCode { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }
        public string Contour { get; set; }
        

    }

    public class BasicInfo
    {
        [Key,Column(Order =1)]
        public string RegionCode { get; set; }
        [Key,Column(Order =2)]
        public int Year { get; set; }
        public decimal? Altitude { get; set; }
        public decimal? Temperature { get; set; }
        public decimal? Area { get; set; }
        public decimal? ArableArea { get; set; }
        public decimal? PerArableArea { get; set; }
        public decimal? ForestArea { get; set; }
        public decimal? FruitArea { get; set; }


        [ForeignKey("RegionCode")]
        public virtual Region Region { get; set; }
    }


    public class BusStation : BaseEntity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        public virtual ICollection<BusStationMap> Maps { get; set; }

    }


    public class Bus : BaseEntity
    {
        public int BusStationId { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public decimal? Price { get; set; }
        public int? StartStation { get; set; }
        public int? EndStation { get; set; }
        public int? StationCount { get; set; }
        public decimal? Length { get; set; }
        public string Stations { get; set; }
        public decimal? IntervalTime { get; set; }
        public DateTime? First { get; set; }
        public DateTime? Last { get; set; }

        public virtual ICollection<BusStationMap> Maps { get; set; }
    }


    public class BusStationMap
    {
        [Key,Column(Order =1)]
        [ForeignKey("Bus")]
        public int BusId { get; set; }

        [Key,Column(Order =2)]
        [ForeignKey("BusStation")]
        public int BusStaionId { get; set; }

        public int? Order { get; set; }

        public virtual BusStation BusStation { get; set; }
        public virtual Bus Bus { get; set; }
    }

}
