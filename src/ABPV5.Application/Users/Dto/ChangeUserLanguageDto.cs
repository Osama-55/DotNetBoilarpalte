using System.ComponentModel.DataAnnotations;

namespace ABPV5.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}