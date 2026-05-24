namespace OrderServices.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public bool IsPayment { get; set; }
        public DateTime? CreatedData { get; set; }
        public string? status { get; set; }
        public int UserId { get; set; }
    }
}
