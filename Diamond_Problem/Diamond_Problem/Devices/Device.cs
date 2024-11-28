namespace Diamond_Problem.Devices
{
    internal abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}
