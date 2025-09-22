using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Planning
    {
        private readonly List<Transport> _transports = new List<Transport>(); //maar 1 keer worden toegewezen, maar kan nog wel aangepast worden qua inhoud. Goede combi met IReadOnly list ivm externe rechten.
        public IReadOnlyList<Transport> Transports => _transports;
        public void AddTransport(Transport transport)
        {
            _transports.Add(transport);
        }
    }
}
