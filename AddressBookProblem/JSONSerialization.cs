using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    internal class JSONSerialization
    {
        public void JsonSerialize()
        {
            Blogsites bsObj = new Blogsites()
            {
                Name = "Snehal",
                Description = "22 yr old Female"
            };
            //Converting Blogsite object to Jason string format
            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
        }
        public void JsonDesrialize()
        {
            string json = @"{ 'Name' : 'Snehal',
                               'Description' : '22 yr old Female'}";
            Blogsites bsobj = JsonConvert.DeserializeObject<Blogsites>(json);
            Console.WriteLine(bsobj.Name);

        }
        [DataContract]
        class Blogsites
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string Description { get; set; }

        }
    }
}
