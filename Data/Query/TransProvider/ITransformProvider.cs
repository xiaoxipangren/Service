using System;
using System.Collections.Generic;


namespace Lq.Data.Query.TransProvider
{

    public interface ITransformProvider
    {
        bool Match(ConditionItem item, Type type);
        IEnumerable<ConditionItem> Transform(ConditionItem item, Type type);
    }
}