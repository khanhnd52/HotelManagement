using System.ComponentModel.DataAnnotations;

namespace HM_APIs.Model
{
    public class Room
    {
        [Key]
        public int IDRoom { get; set; }
        public string? RoomName { get; set; }
        public bool IsActive { get; set; }


    }
}
