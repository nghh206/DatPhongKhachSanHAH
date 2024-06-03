using BaseSolution.BlazorServer.Data.ValueObjects.Common;

namespace BaseSolution.BlazorServer.Data.DataTransferObjects.RoomBooking.Request
{
    public class RoombookingUpdateRequest
    {
        public Guid Id { get; set; }
        public Guid RoomDetailId { get; set; }
        public Guid CustomerId { get; set; }
        public EntityStatus Status { get; set; }
    }
}
