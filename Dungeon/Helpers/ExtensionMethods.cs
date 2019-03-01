using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dungeon.Helpers
{
    public static class ExtensionMethods
    {
        public static string ToFirstLetterUpper(this string str)
        {
            var lowered = str.ToLower();
            return str.Substring(0).ToUpper() + lowered.Substring(1);
        }
    }
}
