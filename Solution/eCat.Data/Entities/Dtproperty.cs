namespace eCat.Data.Entities
{
    public class Dtproperty
    {
        public int Id { get; set; } // id (Primary key)
        public int? Objectid { get; set; } // objectid
        public string Property { get; set; } // property (Primary key) (length: 64)
        public string Value { get; set; } // value (length: 255)
        public string Uvalue { get; set; } // uvalue (length: 255)
        public byte[] Lvalue { get; set; } // lvalue (length: 2147483647)
        public int Version { get; set; } // version

        public Dtproperty()
        {
            Version = 0;
        }
    }
}