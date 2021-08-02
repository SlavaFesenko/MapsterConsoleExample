namespace ExoticCasesLib
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        
        public UserPoco UserShadow { get; set; }
    }
}