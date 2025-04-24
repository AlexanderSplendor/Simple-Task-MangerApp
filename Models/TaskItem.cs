using System.ComponentModel.DataAnnotations;

namespace Task_Manager_App.Models

{
    public enum PriorityLevel
    {
        Low,
        Medium,
        High
    }
    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Due date is required")]
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public PriorityLevel Priority { get; set; }
        public TaskItem()
        {
            IsCompleted = false;
            DueDate = DateTime.Now;
            Priority = PriorityLevel.Low;
        }
    }


}
