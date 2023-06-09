﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoitaMod.Utils
{
    public static class GeneralUtil
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="force">The sign is forced to be + or -, not none.</param>
        /// <returns>Sign (+, -, or none) of the number.</returns>
        public static string GetSign(this double d, bool force = false)
        {
            int s = Math.Sign(d);
            switch (s)
            {
                case 1:
                    return "+";
                case -1:
                    return "-";
                default:
                    return force ? "+" : string.Empty;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="force">The sign is forced to be + or -, not none.</param>
        /// <returns>The number with it's sign in front.</returns>
        public static string ToSigned(this double d, bool force = false)
        {
            return string.Join(null, d.GetSign(force), d);
        }
        public static double RadToDeg(this double rad)
        {
            return Math.Round(rad / Math.PI * 180, 1);
        }
        public static double DegToRad(this double deg)
        {
            return Math.Round(deg * Math.PI / 180, 1);
        }
        public static double TickToSecond(this int tick)
        {
            return Math.Round(tick / (double)60, 2);
        }
        public static string ToJSON(object obj)
        {
            var option = new JsonSerializerOptions();
            option.IncludeFields = true;
            option.IgnoreReadOnlyFields = true;
            option.IgnoreReadOnlyProperties = true;
            var result = JsonSerializer.Serialize(obj, option);
            return result;
        }
        public static T JSONToObj<T>(string json)
        {
            var result = JsonSerializer.Deserialize<T>(json);
            return result;
        }
    }
}
