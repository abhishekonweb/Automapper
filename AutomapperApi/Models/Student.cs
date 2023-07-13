using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System.Reflection.Emit;
using System;
using System.Runtime.Serialization;

namespace AutomapperApi.Models
{
    public class Student
    {

        [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
        public ObjectId? ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Age { get; set; }


        public string Status { get; set; }

        public int StatusCode { get; set; }

        public string StatusMessage { get; set; }




    }
}
