using System.ComponentModel.DataAnnotations;

namespace CarribaVilla_ASP_API.Models
{
    public class RefreshToken
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string JwtTokenId { get; set; }
        public string Refresh_Token { get; set; }
        //is only valid fo use one
        public bool IsValid { get; set; }
        public DateTime ExpiresAt { get; set; }

    }
}
