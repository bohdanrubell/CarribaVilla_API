using CarribaVilla_Web.Models.Dto;

namespace CarribaVilla_Web.Models.ViewModel
{
    public class VillaUpdateViewModel
    {
       
        public VillaNumberUpdateDTO VillaNumberUpdate { get; set; }
        public IEnumerable<VillaDTO> VillaList { get; set; }
    }
}
