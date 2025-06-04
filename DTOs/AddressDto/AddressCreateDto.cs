namespace Repository_pattern_API.DTOs.AddressDto
{
    public class AddressCreateDto
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string StreetName { get; set; }

        public string? HomeNum { get; set; }

        public string FullAddress { get; set; }
    }
}
