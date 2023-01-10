namespace AddressBookApi.Entities.DTO
{
    /// <summary>
    /// FileDownloadDto Used for the user
    /// </summary>
    public class FileDownloadDto
    {
        public byte[]  FileContent{ get; set; }
        public string FileType { get; set; }
    }
}
