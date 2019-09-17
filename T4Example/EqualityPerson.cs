 

namespace ConsoleApp1
{
    partial class EqualityPerson 
    {
        public override bool Equals(object other)
        {
            return Equals(other as EqualityPerson); 
        }

        public static bool operator==(EqualityPerson left, EqualityPerson right)
        {
            if (ReferenceEquals(left, right))
                return true;
            else if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;
            else
                return left.Equals(right);
        }

        public static bool operator!=(EqualityPerson left, EqualityPerson right)
        {
            if (ReferenceEquals(left, right))
                return false;
            else if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return true;
            else
                return !left.Equals(right);
        }

				public string Forename { get; set; }
			public string Surname { get; set; }
	    }
} 

