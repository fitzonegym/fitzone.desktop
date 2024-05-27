using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Controller.Interfaces
{
    interface IControllersClasesPrincipales<Entity>
    {
        bool Insert(Entity entidad);
        bool Update(Entity entidad, int id);
        bool Delete(int id);
        bool Anular(int id);
        List<Entity>? GetAll();
        Entity? GetById(int id);
        Entity? GetByName(string nombre);
    }
}
