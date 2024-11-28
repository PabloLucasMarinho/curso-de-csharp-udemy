using Diamond_Problem.Devices;

Printer p = new() { SerialNumber = 1080 };
p.ProcessDoc("My letter");
p.Print("My letter");

Scanner s = new() { SerialNumber = 2003 };
s.ProcessDoc("My Email");
Console.WriteLine(s.Scan());

ComboDevice c = new() { SerialNumber = 3921 };
c.ProcessDoc("My dissertation");
c.Print("My dissertation");
Console.WriteLine(c.Scan());