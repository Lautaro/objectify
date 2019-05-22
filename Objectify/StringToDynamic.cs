using System;
using System.Collections.Generic;
using System.Linq;

namespace Objectify
{
    public class StringToProperties
    {
        static string NL = Environment.NewLine;
        public List<string[]> properties;
        public StringToProperties(string _theString)
        {
            //1 dela upp efter radbrytning
             properties = _theString.SplitAndClean(NL).SplitAndClean(":");

        }

        public override string ToString()
        {
            return properties
                .Select(p => $"{p[0]} = {p[1]}") // merge property name and value
                .JoinStrings(NL); // join each property
        }
    }
}
