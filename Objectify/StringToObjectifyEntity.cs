using System;
using System.Collections.Generic;
using System.Linq;

namespace Objectify
{
    public class StringToObjectifyEntity
    {
        static string NL = Environment.NewLine;
        public List<string[]> properties;
        public StringToObjectifyEntity(string _theString)
        {
            var lineSplitDelimiter = new string[]{ Environment.NewLine,",","\r\n"};
            var lines = _theString.SplitAndClean(lineSplitDelimiter);
            var entities = new List<ObjectifyEntity>();
            
            foreach (var line in lines)
            {
                // Kontrollera att det är en ny entitet
                if (line.StartsWith("---"))
                {
                    var entityName = line.Replace("---", "");
                    var entity = new ObjectifyEntity(entityName);


                }
            }

            // Skapa ny entitet

            // Kolla varje rad

            // 

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
