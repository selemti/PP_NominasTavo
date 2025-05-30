using System;
using System.Collections.Generic;
using System.Linq;

namespace PP_Nominas.Helpers
{
    public static class EnumHelper<TEnum> where TEnum : Enum
    {
        public static List<TEnum> ToList()
        {
            return Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToList();
        }
    }
}
