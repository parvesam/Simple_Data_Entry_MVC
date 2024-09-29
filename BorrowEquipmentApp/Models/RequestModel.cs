namespace BorrowEquipmentApp.Models
{
    public class RequestModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Role { get; set; }
        public string? EquipmentType { get; set; }
        public string? RequestDetails { get; set; }
        public int Duration { get; set; }
        public int Id { get; set; }  // For storing request ID
    }
}
