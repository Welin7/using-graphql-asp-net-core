namespace ProjectGraphQL.Models
{
    public class Music : Base
    {
        public string    Name {get; set;}
        public string Comment {get; set;}
        public List<Artist> Artists {get; set;}
    }
}