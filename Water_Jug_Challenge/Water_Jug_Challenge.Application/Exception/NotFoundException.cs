

using System.Xml.Linq;

namespace Water_Jug_Challenge.Application.Exception
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string? name) : base($"Entity \"{name}\" no fue encontrado")
        {
        }
    }
}
