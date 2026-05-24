using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace OrderServices.Entities
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public bool IsPayment { get; set; }
        public DateTime?CreatedData { get; set; }
        public string?status { get; set; }  
        public int UserId { get; set; } 
    }
}
