using BaseSolution.BlazorServer.Data.ValueObjects.Common;

namespace BaseSolution.BlazorServer.Data.DataTransferObjects.User
{
    public class UserHotelDTO
    {

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid UserRoleId { get; set; }
        public string RoleCode { get; set; }
        public EntityStatus Status { get; set; }
    }
}
