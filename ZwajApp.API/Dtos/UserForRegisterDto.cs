using System.ComponentModel.DataAnnotations;

namespace ZwajApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [StringLength(8,MinimumLength=4,ErrorMessage="يجب أن لا تزيد كلمة المرور عن ثمانية أحرف ولا تقل عن أربعة")]
        public string Password { get; set; }
    }
}