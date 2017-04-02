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
    /// <summary>
    /// 美丽乡村建设项目管理
    /// </summary>
    public class ConstructionProject : ManageProject
    {
        public virtual IEnumerable<ConstructionResult> Results { get; set; }
    }

    /// <summary>
    /// 美丽乡村建设成果
    /// </summary>
    public class ConstructionResult:ManageIndexValue
    {
        [Key, Column(Order = 2)]
        [MaxLength(50)]
        [ColumnComment("美丽乡村建设项目id")]
        public int ProjectId { get; set; }
        

        [ForeignKey("ProjectId")]
        public virtual ConstructionProject ConstructionProject { get; set; }
        
    }
}
