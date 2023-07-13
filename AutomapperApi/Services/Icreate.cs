

using AutomapperApi.Models;

namespace AutomapperApi.Services
{
    public interface Icreate
    {
        List<Student> GetStudents();

        Student CreateStudent(Student student);

    }
}
