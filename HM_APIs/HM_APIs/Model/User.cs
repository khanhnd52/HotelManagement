using System.ComponentModel.DataAnnotations;

namespace HM_APIs.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
         
    }
}
