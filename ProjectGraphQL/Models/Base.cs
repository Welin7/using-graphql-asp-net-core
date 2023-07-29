namespace ProjectGraphQL.Models
{
    public class Base
    {
        private Guid? _id;
        public Guid? Id
        {
            get {return _id ?? Guid.NewGuid();}
            set {_id = value;}
        }
    }
}