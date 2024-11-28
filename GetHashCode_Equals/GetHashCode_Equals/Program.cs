using GetHashCode_Equals.Entities;

Client a = new("Maria", "maria@gmail.com");
Client b = new("Alex", "alex@gmail.com");

Console.WriteLine(a.Equals(b));
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());