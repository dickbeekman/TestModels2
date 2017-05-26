using System.Runtime.Serialization;

namespace TestModels
{
    [DataContract]

    public class Person2

    {

        [DataMember]

        public string FirstName { get; set; }

        [DataMember]

        public string LastName { get; set; }

    }
}