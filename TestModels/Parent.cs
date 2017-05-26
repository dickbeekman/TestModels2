using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TestModels
{
    [DataContract]
    public class Parent : Person
    {
        [DataMember]
        public IEnumerable<Person> Children { get; set; }
    }
}