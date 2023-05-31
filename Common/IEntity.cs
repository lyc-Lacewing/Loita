using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.Common
{
    public interface IEntity
    {
        public object Source { get; set; }
        public Dictionary<string, List<IComponent>> Hooks { get; set; }
        public Dictionary<string, Dictionary<IComponent, Delegate>> Components { get; set; }
    }
}
