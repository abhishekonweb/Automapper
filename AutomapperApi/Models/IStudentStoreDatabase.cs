namespace AutomapperApi.Models
{
    public interface IStudentStoreDatabase
    {
        public string StudentCollectionName { get; set; }

        public string Connectionstring { get; set; }

        public string DatabaseName { get; set; }
    }
}
