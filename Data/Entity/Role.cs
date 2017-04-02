using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lq.Data.Entity
{
    public enum Role
    {
        /// <summary>
        /// 微信用户
        /// </summary>
        WCUser=1,
        /// <summary>
        /// 管理员
        /// </summary>
        Administrator,
        /// <summary>
        /// 政府部门
        /// </summary>
        Department,
        /// <summary>
        /// 商家
        /// </summary>
        Merchant,
        /// <summary>
        /// 访客
        /// </summary>
        Guest
    }
}
