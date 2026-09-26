namespace APIP1.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public Responsible Responsible { get; set; } = null;
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskDate { get; set; }
        public string TaskStatus { get; set; } = "";

        public TaskItem(int id, Responsible responsible, string taskName, string taskDescription, DateTime taskDate, string taskStatus)
        {
            Id = id;
            Responsible = responsible;
            TaskName = taskName;
            TaskDescription = taskDescription;
            TaskDate = taskDate;
            TaskStatus = taskStatus;
        }
    }
}
