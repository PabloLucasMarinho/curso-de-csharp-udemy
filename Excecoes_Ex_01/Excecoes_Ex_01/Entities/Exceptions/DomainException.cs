namespace Excecoes_Ex_01.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
