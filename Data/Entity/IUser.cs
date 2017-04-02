using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lq.Data.Entity
{
    public interface IUser:IEntity
    {

        string Name { get; set; }
        string Password { get; set; }
        //string Nick { get; set; }
        //string Photo { get; set; }
        //string Signature { get; set; }
        //int Age { get; set; }
        //string Sex { get; set; }
        Role Role { get; set; }
        DateTime CreateDate { get; set; }
        DateTime FirstLogin { get; set; }
        DateTime LastLogin { get; set; }
    }
}
