using System.ComponentModel.DataAnnotations;
using WebApp_GKH.Models;

namespace CommonLib.DTO
{

    public class ApplicationDTO
    {
        [Required(ErrorMessage = "Необходимо указать тему.")]
        [Display(Name = "Тема")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Необходимо описать вопрос.")]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        public ApplicationType Type { get; set; }

    }
}
