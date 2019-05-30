using System;
using System.Collections.Generic;
using System.Text;

namespace Objectify
{
    public class ObjectifyEntity
    {
        public readonly string Identifier;

        public ObjectifyEntity(string identifier)
        {
            Identifier = identifier;

        }
        public List<ObjectifyProperty> Property { get; set; }
    }

    public class ObjectifyProperty
    {
        public readonly string Name;
        public readonly object Value;
        public readonly bool IsColletion;

        public readonly Type PropertyType;
        public ObjectifyProperty(string name,object value)
        {
            PropertyType = value.GetType();
            if (PropertyType.GetProperty().PropertyType.IsGenericType )
            {

            }
            Name = name;
            Value = value;

        }        
    }
    
    public enum ObjectifyTypes
    {
        _String, 
        _Int,
        _Decimal,
        _DateTime,
        _Bool,
        _Entity
    }
}
