using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntradasEntidad
    {
        /// <summary>
        /// Se crea el constructor vacio para la entidad Entradas
        /// </summary>
        public EntradasEntidad()
        {
        }
        /// <summary>
        /// Se crea el cosntructor con parámetros para la entidad Entradas
        /// </summary>
        /// <param name="idEntrada">El id de la entrada</param>
        /// <param name="nomEntrada">El nombre de la entrada</param>
        /// <param name="imgEntrada">La imagen de la entrada</param>
        /// <param name="ingEntrada">Los ingredientes de la entrada</param>
        public EntradasEntidad(int idEntrada, string nomEntrada, byte[] imgEntrada, string ingEntrada)
        {
            IdEntrada = idEntrada;
            NomEntrada = nomEntrada;
            ImgEntrada = imgEntrada;
            IngEntrada = ingEntrada;
        }
        /// <summary>
        /// Se encapsulan los atributos de la clase
        /// </summary>
        public int IdEntrada { get; set; }
        public string NomEntrada { get; set; }
        public byte[] ImgEntrada { get; set; }
        public string IngEntrada { get; set; }
    }
}
