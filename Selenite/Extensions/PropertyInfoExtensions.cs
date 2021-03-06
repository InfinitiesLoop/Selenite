using System.Reflection;

namespace Selenite.Extensions
{
    public static class PropertyInfoExtensions
    {
        public static void InvokeSetMethod(this PropertyInfo propertyInfo, object obj, params object[] parameters)
        {
            propertyInfo
                .GetSetMethod()
                .Invoke(obj, parameters);
        }
    }
}