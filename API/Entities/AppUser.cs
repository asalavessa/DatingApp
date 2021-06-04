namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }                 //using the "Id" name for the ease of use with Entity Framework"
        public string UserName { get; set; }        //using the "UserName" name with uppercare "N" for the ease of use with ASP.NET Core Identity

        public byte[] PasswordHash { get; set; }
        
        public byte[] PasswordSalt { get; set; }
        
    }
}