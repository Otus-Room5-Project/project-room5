using System.ComponentModel.DataAnnotations;

namespace WebApp_GKH.DTO
{
    public class AddressDTO
    {
        [Required(ErrorMessage = "Необходимо указать страну.")]
        [Display(Name = "Страна")]
        public string County { get; set; }

        [Required(ErrorMessage = "Необходимо указать город.")]
        [Display(Name = "Город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Необходимо указать улицу.")]
        [Display(Name = "Улица")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Необходимо указать дом.")]
        [Display(Name = "Дом")]
        public int House { get; set; }

        [Required(ErrorMessage = "Необходимо указать квартиру.")]
        [Display(Name = "Квартира")]
        public int Flat { get; set; }

    }
}
