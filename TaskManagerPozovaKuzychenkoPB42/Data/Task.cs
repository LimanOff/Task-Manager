using System;
using System.ComponentModel.DataAnnotations.Schema;
using TaskManagerPozovaKuzychenkoPB42.Data.Enums;

namespace TaskManager_2.Data
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime DeadlineDate { get; set; }

        [NotMapped]
        public string CreatedDateFormatted => CreatedDate.ToString("dd.MM.yyyy");

        [NotMapped]
        public string DeadlineDateFormatted => DeadlineDate.ToString("dd.MM.yyyy");

        public TaskPriority Priority { get; set; }
        public TaskFulfillmentType FulfillmentType { get; set; }
    }
}
