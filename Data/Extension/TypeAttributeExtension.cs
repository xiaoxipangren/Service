using System;

namespace Lq.Data.Extension
{
    public static class TypeAttributeExtension
    {
        public static T GetCustomAttribute<T>(this Type type)
        {
            foreach (object attr in type.GetCustomAttributes(typeof(T), false))
            {
                return (T)attr;
            }
            return default(T);
        }
    }
}