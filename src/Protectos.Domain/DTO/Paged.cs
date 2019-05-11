using System.Collections.Generic;
namespace Protectos.Domain.DTO
{
    public class Paged<T> where T : class
    {
        public IEnumerable<T> List { get; set; }
        public int Count { get; set; }
    }
}
