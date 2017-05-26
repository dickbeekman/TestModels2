using System;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TestModels
{
    [DataContract]

    public class Person2

    {
        public Person2(string firstName, int age)
        {
            FirstName = firstName;
            Age = age;
        }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public int Age { get; set; }

        public string SerializeToJson()
        {
            var stringContent = JsonConvert.SerializeObject(this);
            return stringContent;

            //return JsonConvert.DeserializeObject<T>(json);

            //var jsonContent = new StringContent(data);
            //jsonContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


        }
    }
}