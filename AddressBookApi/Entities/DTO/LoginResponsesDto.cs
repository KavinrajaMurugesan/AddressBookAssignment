namespace AddressBookApi.Entities.DTO
{
    /// <summary>
    /// this class gives login responses format
    /// </summary>
    public class LoginResponsesDto
    {
        public string Token { get; set; }
        public string Type { get; set; } = "Bearer";
    }
}
