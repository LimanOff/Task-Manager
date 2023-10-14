using System;
using System.ComponentModel.DataAnnotations.Schema;
using TaskManagerPozovaKuzychenkoPB42.DataBase.Data.Enums;

namespace TaskManagerPozovaKuzychenkoPB42.DataBase.Data
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime DeadlineDate { get; set; }

        public TaskPriority Priority { get; set; }
        public TaskType TaskType { get; set; }

        public Task(int id,string name, string description, DateTime createdDate, DateTime deadlineDate,
            TaskPriority priority, TaskType taskType)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedDate = createdDate;
            DeadlineDate = deadlineDate;
            Priority = priority;
            TaskType = taskType;
        }
    }
}
