using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Controller.Interfaces
{
    public interface IControllerClasesAuxiliares<Entity>
    {
        bool Insert(Entity entidad);
        List<Entity>? GetAll();
        Entity? GetById(int id);
        Entity? GetByName(string nombre);
    }
}
