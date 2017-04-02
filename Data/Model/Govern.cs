using Lq.Data.Entity;
using Lq.Data.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lq.Data.Model
{
    public class GovernProject:ManageProject
    {
        public virtual IEnumerable<GovernTask> Tasks { get; set; }
        public virtual IEnumerable<GovernResult> Results { get; set; }
    }


    public class GovernTask:SpatialEntity
    {
        [ColumnComment("所属项目id")]
        [ForeignKey("Project")]
        public int GovernProjectId { get; set; }

        [ColumnComment("任务描述")]
        [MaxLength(500)]
        public string Description { get; set; }

        [ColumnComment("任务目标")]
        [MaxLength(500)]
        public string Goal { get; set; }

        [ColumnComment("任务图片")]
        [MaxLength(500)]
        public string Pics { get; set; }

        [ColumnComment("任务预算")]
        [MaxLength(500)]
        public decimal? Cost { get; set; }

        [ColumnComment("任务责任人")]
        [MaxLength(50)]
        public string Principal { get; set; }

        [ColumnComment("任务是否完成")]
        public bool? Finished { get; set; }

        [ColumnComment("任务启动日期")]
        public DateTime StartDate { get; set; }

        [ColumnComment("任务结束日期")]
        public DateTime EndDate { get; set; }


        public virtual GovernProject GovernProject { set; get; }
    }


    public class GovernResult:ManageIndexValue
    {
        [Key, Column(Order = 2)]
        [MaxLength(50)]
        [ColumnComment("整治项目id")]
        public int GovernProjectId { get; set; }


        [ForeignKey("GovernProjectId")]
        public virtual GovernProject GovernProject { get; set; }

    }

    public class GovernPoi:SpatialEntity
    {
        [ColumnComment("Poi 名称")]
        [MaxLength(20)]
        public string Name { get; set; }

        [ColumnComment("Poi 描述")]
        [MaxLength(20)]
        public string Description { get; set; }

        [ColumnComment("Poi 图片路径")]
        [MaxLength(20)]
        public string Pics { get; set; }

    }


    public class GovernSolution:BaseEntity
    {
        [ColumnComment("整治方案名称")]
        [MaxLength(100)]
        public string Name { get; set; }

        [ColumnComment("整治方案所属部门")]
        [MaxLength(50)]
        public string Department { get; set; }

        [ColumnComment("整治方案针对的问题")]
        [MaxLength(500)]
        public string Problem { get; set; }

        [ColumnComment("整治方案具体内容")]
        [MaxLength(500)]
        public string Content { get; set; }

        [ColumnComment("整治方案文件路径")]
        public string File { get; set; }

        [ColumnComment("整治方案创建日期")]
        public DateTime CreateDate { get; set; }

        [ColumnComment("整治方案上传日期")]
        public DateTime UploadDate { get; set; }


        public virtual IEnumerable<SolutionComment> Comments { get; set; }
        public virtual IEnumerable<SolutionQuestion> Questions { get; set; }
    }


    public class SolutionComment:BaseEntity
    {
        [ColumnComment("评论针对的方案id")]
        public int GovernSolutionId { get; set; }

        [ColumnComment("评论人")]
        [MaxLength(50)]
        public string Commentator { get; set; }

        [ColumnComment("评论内容")]
        [MaxLength(500)]
        public string Content { get; set; }

        [ColumnComment("评论日期")]
        public DateTime Date { get; set; }

        public virtual GovernSolution Solution { get; set; }
    }


    public class SolutionQuestion:BaseEntity
    {
        [ColumnComment("问题内容")]
        [MaxLength(100)]
        public string Content { get; set; }

        [ColumnComment("问题涉及的方案id")]
        [ForeignKey("Solution")]
        public int GovernSolutionId { get; set; }

        [ColumnComment("提问人")]
        [MaxLength(20)]
        public string Questioner { get; set; }

        [ColumnComment("提问时间")]
        public DateTime Date { get; set; }


        public virtual IEnumerable<SolutionAnswer> Answers { get; set; }
        public virtual GovernSolution Solution { get; set; }
    }

    public class SolutionAnswer:BaseEntity
    {
        [ColumnComment("问题id")]
        [ForeignKey("Question")]
        public int SolutionQuestionId { get; set; }

        [ColumnComment("回答者")]
        [MaxLength(50)]
        public string Responser { get; set; }
        [ColumnComment("回答内容")]
        [MaxLength(500)]
        public string Content { get; set; }

        [ColumnComment("回答日期")]
        public DateTime Date { get; set; }

        public virtual SolutionQuestion Question { get; set; }
    }


}
