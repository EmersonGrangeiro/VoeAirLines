using System;
using System.Threading;
using System.Web;

namespace voeairlines.Data
{
    //propriedades automáticas
    public class Aeronave
    {
        public string? Modelo { get; set; }
        public string? Codigo { get; set; }
        public string? Fabricante { get; set; }
        //construtor
        public Aeronave(string? modelo, string? codigo, string? fabricante)
        {
            Modelo = modelo;
            Codigo = codigo;
            Fabricante = fabricante;
        }
    }
}