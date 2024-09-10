using Fitzone.Controller.Interfaces;
using Fitzone.EF;
using Fitzone.Entidades;
using Microsoft.EntityFrameworkCore;
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
            return contexto.Factura.Include("DetalleFactura").FirstOrDefault(i => i.idFactura == id);
        }

        public Factura? GetByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public string getNumeroProximo()
        {
            int max = 1;
            var facturas = contexto.Factura.ToList();
            foreach (var fac in facturas)
            {
                int.TryParse(fac.numero.Replace("-",""),out int num);
                if (num > max)
                    max = num;
            }
            string maxString = "00000000" + (max+1).ToString();  
            string resultado = maxString.Substring(maxString.Length-8,8);
            return "0000-" + resultado;
        }
        public int Insert(Factura entidad)
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

                    //actualizo la cuota
                    actualizar.pagada = true;

                }
                //inserto el detalle de factura
                contexto.Add(entidad);

                contexto.SaveChanges();
                return entidad.idFactura;

            }
            catch (Exception)
            {
                throw;
            }            
        }

        bool IControllerClasesAuxiliares<Factura>.Insert(Factura entidad)
        {
            throw new NotImplementedException();
        }
    }
}
