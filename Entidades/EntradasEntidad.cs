using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntradasEntidad
    {
        public EntradasEntidad()
        {
        }

        public EntradasEntidad(int idEntrada, string nomEntrada, byte[] imgEntrada, string ingEntrada)
        {
            IdEntrada = idEntrada;
            NomEntrada = nomEntrada;
            ImgEntrada = imgEntrada;
            IngEntrada = ingEntrada;
        }

        public int IdEntrada { get; set; }
        public string NomEntrada { get; set; }
        public byte[] ImgEntrada { get; set; }
        public string IngEntrada { get; set; }
    }
}
