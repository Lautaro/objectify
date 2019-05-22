using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objectify
{
    internal static class Extensions
    {
        internal static string[] SplitAndClean(this string stringToSplit, string delimiter)
        {

            if (string.IsNullOrEmpty(stringToSplit) || !stringToSplit.Contains(":"))
            {
                throw new Exception("No proper delimiter found");
            }

            return stringToSplit
                .Split(delimiter).ToList()// split
                .Select(p => p.Trim())// trim each
                .Where(p => !string.IsNullOrEmpty(p))// remove empty items
                .ToArray();

        }

        internal static List<string[]> SplitAndClean(this string[] stringsToSplit, string delimiter)
        {
            var list = new List<string[]>();

            foreach (var stringToSplit in stringsToSplit)
            {
                list.Add(stringToSplit.SplitAndClean(delimiter));
            }

            return list;

        }

        internal static string JoinStrings(this IEnumerable<string> stringCollection, string delimiter = "")
        {
            return string.Join(delimiter, stringCollection);

        }
    }
}
