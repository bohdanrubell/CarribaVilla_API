using System.ComponentModel.DataAnnotations;

namespace CarribaVilla_ASP_API.Models.Dto
{
    public class VillaNumberUpdateDTO
    {
        [Required]
        public int VillaNo { get; set; }

        public string SpecialDetails { get; set; }
    }
}
