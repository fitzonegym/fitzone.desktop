using Fitzone.Controller.Interfaces;
using Fitzone.EF;
using Fitzone.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Controller
{
    public class FacturaController : IControllerClasesAuxiliares<Factura>
    {
        Contexto contexto = new Contexto();

        public List<Factura>? GetAll()
        {
            throw new NotImplementedException();
        }

        public Factura? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Factura? GetByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Factura entidad)
        {
            entidad.idFactura = 0;
            try
            { 
                foreach (var d in entidad.DetalleFactura)
                {
                    //busco en la BD el objeto a modificar
                    var actualizar = contexto.Cuota.FirstOrDefault(i => i.idCuota == d.idCuota);
                    if (actualizar == null)
                        break;   

                    //actualizo los valores
                    actualizar.pagada = true;

                }
                contexto.Add(entidad);

                contexto.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }            
        }
    }
}
