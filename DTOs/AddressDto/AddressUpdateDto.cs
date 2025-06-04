namespace Repository_pattern_API.DTOs.AddressDto
{
    public class AddressUpdateDto
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string StreetName { get; set; }

        public string? HomeNum { get; set; }

        public string FullAddress { get; set; }
    }
}
