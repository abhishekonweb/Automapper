using AutomapperApi.Models;
using AutomapperApi.Models;
using AutomapperApi.Services;
using MongoDB.Driver;

namespace AutomapperApi.Services
{
    public class Createstudent : Icreate
    {
        private readonly IMongoCollection<Student> _student;



        public Createstudent(IStudentStoreDatabase setting, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(setting.DatabaseName);
            _student = database.GetCollection<Student>(setting.StudentCollectionName);

        }

        public Student CreateStudent(Student student)
        {
            _student.InsertOne(student);
            return student;
        }

        public List<Student> GetStudents()
        {
            return _student.Find(student => true).ToList();
        }
    }
}
