using System.ComponentModel.DataAnnotations;

namespace TodoApp.Data {
    public class TaskItem {
        public int Id {  get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }

        public DateTime? CreateDate { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}
