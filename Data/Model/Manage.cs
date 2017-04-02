using Lq.Data.Attribute;
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
    public class ManageIndex : BaseEntity
    {
        [MaxLength(50)]
        [ColumnComment("指标名")]
        public string Name { get; set; }
        [MaxLength(50)]
        [ColumnComment("指标详细描述")]
        public string Description { get; set; }
        [MaxLength(50)]
        [ColumnComment("指标类型")]
        public string Type { get; set; }
        [MaxLength(50)]
        [ColumnComment("指标级别")]
        public string Level { get; set; }
        [MaxLength(50)]
        [ColumnComment("父指标ID")]
        public int ParentId { get; set; }
        [ColumnComment("指标权重")]
        public decimal IndexWeight { get; set; }
        [ColumnComment("最大值")]
        public decimal? Maximum { get; set; }
        [ColumnComment("最小值")]
        public decimal? Minimum { get; set; }
        [MaxLength(50)]
        [ColumnComment("单位")]
        public string Unit { get; set; }
        [MaxLength(50)]
        [ColumnComment("归一化方法")]
        public string Normalization { get; set; }
        [MaxLength(50)]
        [ColumnComment("指标用途")]
        public string Usage { get; set; }
        [MaxLength(50)]
        [ColumnComment("备注")]
        public string Comment { get; set; }

    }


    public class ManageIndexValue
    {
        [Key, Column(Order = 1)]
        [MaxLength(50)]
        [ColumnComment("指标ID")]
        public string IndexId { get; set; }

        [ColumnComment("指标值")]
        [MaxLength(2000)]
        public string IndexValue { get; set; }
        [MaxLength(50)]
        [ColumnComment("录入时间")]
        public string RecordDate { get; set; }

        [ForeignKey("IndexId")]
        public virtual ManageIndex ManageIndex { get; set; }
    }

    public class ManageProject : SpatialEntity
    {
        [ColumnComment("项目名称")]
        [MaxLength(500)]
        public string Name { get; set; }

        [ColumnComment("项目描述")]
        [MaxLength(500)]
        public string Description { get; set; }

        [ColumnComment("项目内容")]
        [MaxLength(3000)]
        public string Content { get; set; }

        [MaxLength(500)]
        [ColumnComment("项目规划")]
        public string Plan { get; set; }

        [MaxLength(50)]
        [ColumnComment("项目规划文件路径")]
        public string PlanDocument { get; set; }

        [MaxLength(500)]
        [ColumnComment("项目规划图片路径")]
        public string PlanPics { get; set; }

        [MaxLength(500)]
        [ColumnComment("项目所属行政区编码")]
        public string RegionCode { get; set; }

        [MaxLength(500)]
        [ColumnComment("项目图片")]
        public string Pics { get; set; }

        [MaxLength(500)]
        [ColumnComment("项目视频路径")]
        public string Videos { get; set; }


        [ColumnComment("项目预算")]
        public decimal? Budget { get; set; }


        [ColumnComment("项目花费")]
        public decimal? Cost { get; set; }

        [ColumnComment("项目开始时间")]
        public DateTime StartDate { get; set; }
        [ColumnComment("项目结束时间")]
        public DateTime EndDate { get; set; }
        [ColumnComment("项目验收时间")]
        public DateTime AcceptDate { get; set; }

        [ColumnComment("项目管理部门")]
        [MaxLength(50)]
        public string ManageDepartment { get; set; }
        [MaxLength(50)]
        [ColumnComment("项目负责人")]
        public string Principal { get; set; }
        [MaxLength(50)]
        [ColumnComment("项目审批人")]
        public string Approver { get; set; }

        [MaxLength(50)]
        [ColumnComment("项目备注")]
        public string Comment { get; set; }


        [ForeignKey("RegionCode")]
        public virtual AdminRegion AdminRegion { get; set; }
    }
}
