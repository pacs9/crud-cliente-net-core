using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace common.Utilities
{
    public static class EnumExtension
    {        
        public static IEnumerable<SelectListItem> GetDirectionSelectList<T>(bool addDefaultValue = false)
        {
            Array values = Enum.GetValues(typeof(T));
            List<SelectListItem> items = new List<SelectListItem>();
            
            if (addDefaultValue)
            {
                items.Add(new SelectListItem
                {
                    Text = "Selecione...",
                    Value = ""
                });
            }

            foreach (var i in values)
            {
                items.Add(new SelectListItem
                {
                    Text = ((Enum)i).GetDescription(),
                    Value = i.ToString()
                });
            }

            return items;
        }

        public static string GetDescription(this Enum value)
        {
            var attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
