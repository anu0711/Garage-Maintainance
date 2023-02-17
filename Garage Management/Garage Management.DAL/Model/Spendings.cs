

namespace Garage_Management.DAL.Model
{
    public class Spendings : Entity
    {
        public Guid Id { get; set; }    
        public string Detail { get; set; }
        public long Amount { get; set; }
        public bool IsOwner { get; set; }
        public Guid TruckId { get; set; }


    }
}
