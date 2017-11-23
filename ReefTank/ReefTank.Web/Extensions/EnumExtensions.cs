using System;
using System.ComponentModel.DataAnnotations;

namespace ReefTank.Web.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets the Display name value of an Enum.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DisplayName(this Enum value)
        {
            //Get values from the given enum member
            var enumType = value.GetType();
            var enumValue = Enum.GetName(enumType, value);
            var member = enumType.GetMember(enumValue)[0];

            //Get attribute values
            var attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);

            //Determine display value
            var displayName = string.Empty;
            if (attrs.Length != 0)
            {
                if (((DisplayAttribute)attrs[0]).ResourceType != null)
                {
                    displayName = ((DisplayAttribute)attrs[0]).GetName();
                }
            }

            //Return the display value
            return displayName;
        }
    }
}