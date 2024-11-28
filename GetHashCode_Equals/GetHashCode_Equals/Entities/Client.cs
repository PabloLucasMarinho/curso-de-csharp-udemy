namespace GetHashCode_Equals.Entities
{
    internal class Client(string name, string email)
    {
        public string Name { get; set; } = name;
        public string Email { get; set; } = email;

        public override bool Equals(object? obj)
        {
            if (obj is not Client)
            {
                return false;
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
