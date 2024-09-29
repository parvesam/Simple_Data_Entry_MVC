namespace BorrowEquipmentApp.Models
{
    public class EquipmentModel
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public bool Availability { get; set; }
    }
}
