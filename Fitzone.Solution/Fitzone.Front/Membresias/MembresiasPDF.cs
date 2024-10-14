using Fitzone.Controller;
using Fitzone.Entidades;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Fitzone.Front.Membresias
{
    public class MembresiasPDF 
    {
        List<Membresia> membresias;
        public MembresiasPDF(List<Membresia> membresias)
        {
            this.membresias = membresias;
        }

        public void GenerarPDF()
        {

        }
    }
}
