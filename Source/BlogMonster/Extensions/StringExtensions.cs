﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BlogMonster.Extensions
{
    public static class StringExtensions
    {
        public static string FormatWith(this string s, params object[] args)
        {
            return String.Format(s, args);
        }

        public static string CoalesceIfWhiteSpace(this string s, string other)
        {
            return String.IsNullOrWhiteSpace(s) ? other : s;
        }

        public static IEnumerable<string> NotNullOrWhitespace(this IEnumerable<string> source)
        {
            return source
                .Where(s => !String.IsNullOrWhiteSpace(s));
        }

        public static string Join(this IEnumerable<string> source, string separator)
        {
            return string.Join(separator, source.ToArray());
        }

        public static string RegexReplace(this string s, string pattern, string replacement)
        {
            return Regex.Replace(s, pattern, replacement);
        }

        public static string RemoveCharacters(this string s, string toRemove)
        {
            var working = s;
            foreach (var c in toRemove.ToCharArray())
            {
                working = working.Replace(c.ToString(), string.Empty);
            }

            return working;
        }
    }
}