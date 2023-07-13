namespace AutomapperApi.Models
{
    public class StudentStoreDatabase : IStudentStoreDatabase
    {
        public string StudentCollectionName { get; set; }
        public string Connectionstring { get; set; }
        public string DatabaseName { get; set; }
    }
}
