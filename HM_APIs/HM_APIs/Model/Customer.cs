using System.ComponentModel.DataAnnotations;

namespace HM_APIs.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string IdProof { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
