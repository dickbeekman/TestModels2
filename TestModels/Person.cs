using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace TestModels
{
    [DataContract]

    public class Person

    {

        [DataMember]

        public string FirstName { get; set; }

        [DataMember]

        public string LastName { get; set; }

    }
}
