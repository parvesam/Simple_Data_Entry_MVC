namespace BorrowEquipmentApp.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty; // Initialized with default value
        public string Description { get; set; } = string.Empty; // Initialized with default value
        public bool IsAvailable { get; set; }
    }
}
