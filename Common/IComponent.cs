using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.Common
{
    public interface IComponent
    {
        public IEntity Entity { get; set; }
        public void OnInstall();
        public void OnUninstall();
        public List<Type> GetDependency();
        public void OnOthersInstall(List<IComponent> components);
    }
}
