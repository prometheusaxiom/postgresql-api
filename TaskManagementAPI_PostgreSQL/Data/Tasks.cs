namespace TaskManagementAPI_PostgreSQL.Data
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public TaskStatusEnum Status { get; set; }
    }
}
