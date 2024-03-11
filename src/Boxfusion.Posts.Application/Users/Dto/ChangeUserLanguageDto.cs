using System.ComponentModel.DataAnnotations;

namespace Boxfusion.Posts.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}