namespace Generics.Entities
{
    internal class PrintService<T>
    {
        private T[] Values { get; set; } = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            else
            {
                Values[_count] = value;
                _count++;
            }
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            else
            {
                return Values[0];
            }
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(Values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(Values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
