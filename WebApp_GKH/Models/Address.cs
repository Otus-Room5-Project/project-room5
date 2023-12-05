namespace WebApp_GKH.Models
{
    /// <summary>
    /// 
    /// 
    /// 
    /// </summary>
    public class Address
    {
        public Guid Id { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Flat { get; set; }
    }
}
