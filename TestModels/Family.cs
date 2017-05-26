using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TestModels
{
    [DataContract]
    public class Family
    {
        [DataMember]

        public string FamilyName { get; set; }

        [DataMember]

        public List<Person> MemberList { get; set; }
    }
}