namespace AddressBookApi.Filters
{
    /// <summary>
    /// Pagination used for applying the filters
    /// </summary>
    public class Pagination
    {
        public int size { get; set; } = 10;
        public int pageNo { get; set; } = 1;
        public string sortBy { get; set; } = "FirstName";
        public string sortOrder { get; set; } = "Ascending";
    }
}
