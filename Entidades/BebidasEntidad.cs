using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BebidasEntidad
    {
        
        public BebidasEntidad()
        {
        }

        public BebidasEntidad(int idBebida, string nomBebida, byte[] imgBebida, string ingBebida)
        {
            IdBebida = idBebida;
            NomBebida = nomBebida;
            ImgBebida = imgBebida;
            IngBebida = ingBebida;
        }

        public int IdBebida { get; set; }
        public string NomBebida{ get; set; }
        public byte[] ImgBebida { get; set; }
        public string IngBebida{ get; set; }
    }
}
