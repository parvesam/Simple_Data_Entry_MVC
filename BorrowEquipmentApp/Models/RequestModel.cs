namespace BorrowEquipmentApp.Models
{
    public class RequestModel
    {
        public int Id { get; set; }
        public string? EquipmentType { get; set; }
        public string? Description { get; set; }
        public DateTime? RequestDate { get; set; } // Make this nullable if appropriate

    }
}
