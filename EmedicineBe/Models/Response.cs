namespace EmedicineBe.Models
{
    public class Response
    {
        public int StarusCode { get; set; }
        public string StatusMessage { get; set; }
        public List<Users> ListUsers
        { get; set; }
        public Users user { get; set; }
    }
}
