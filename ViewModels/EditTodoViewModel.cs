using System.ComponentModel.DataAnnotations;

namespace MyTodo.ViewModels
{
    public class EditTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}