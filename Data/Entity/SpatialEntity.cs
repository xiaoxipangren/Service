using Lq.Data.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lq.Data.Entity
{
    /// <summary>
    /// 带有空间属性的实体类
    /// </summary>
    public class SpatialEntity : BaseEntity, ISpatialEntity
    {
        [ColumnComment("中心位置坐标")]
        [MaxLength(50)]
        public string Location { get; set; }

        [ColumnComment("轮廓geojson字符串")]
        [MaxLength(500)]
        public string Contour { get; set; }

        [ColumnComment("包含空间对象geojson字符串")]
        [MaxLength(2000)]
        public string Geojson { get; set; }
    }
}
