namespace TaskManagementAPI_PostgreSQL.Data.DTO
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Status { get; set; } // Convert Enum to string
    }
}
