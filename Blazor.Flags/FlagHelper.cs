using System.ComponentModel;
using System.Reflection;

namespace Blazor.Flags
{
    public static class FlagHelper
    {
        public static string Name<Country>(this Country source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }
    }
}
