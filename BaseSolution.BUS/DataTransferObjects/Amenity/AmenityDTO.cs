using BaseSolution.Domain.Enums;

namespace BaseSolution.Application.DataTransferObjects.Amenity
{
    public class AmenityDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        //Tổng số Amenity trong ksan
        public int Total { get; set; }
        //Số phòng sử dụng
        public int NumberOfRoomUse { get; set; }
        
    }
}
