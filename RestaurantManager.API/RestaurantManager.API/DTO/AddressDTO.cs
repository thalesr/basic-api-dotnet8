using RestaurantManager.API.DTO.Base;

namespace RestaurantManager.API.DTO
{

    public class CreateAddressDTO : BaseCreateDTO
    {
        public int UserID { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Pincode { get; set; }
    }

    public class UpdateAddressDTO : BaseUpdateDTO
    {
        public int UserID { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Pincode { get; set; }
    }

    public class AddressDTO : BaseDTO
    {
        public int UserID { get; set; }
        public UserDTO User { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Pincode { get; set; }
    }

}
