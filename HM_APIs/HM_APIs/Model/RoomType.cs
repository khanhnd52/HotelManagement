using System.ComponentModel.DataAnnotations;

namespace HM_APIs.Model
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public int Capacity { get; set; }
        public int Bed { get; set; }

    }
}
