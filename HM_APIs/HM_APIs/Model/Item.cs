using System.ComponentModel.DataAnnotations;

namespace HM_APIs.Model
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public float Cost { get; set; }
    }
}
