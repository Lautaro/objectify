using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Objectify
{
    public class ParseToObject<T>
    {
        public readonly T ParsedObject;
        Type type = typeof(T);
        public ParseToObject(Dictionary<string,string> properties)
        {
            ParsedObject = (T)Activator.CreateInstance(type);

            foreach (var prop in properties)
            {
                var propertyInfo = type.GetProperty(prop.Key);
                propertyInfo.SetValue(ParsedObject, prop.Value);

            }
        }

        public override string ToString()
        {
            return type.GetProperties().Select(p => $"{p.Name} => {p.GetValue(ParsedObject)}").JoinStrings(Environment.NewLine);
        }
        public string TypeToString()
        {   
            var type = typeof(T);

            return type.GetProperties() // Get all properties
                .Select(p => p.Name.ToString()) // Get property names 
                .JoinStrings(); // Join to one string


        }
    }
}
