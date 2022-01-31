using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SegundosEntidad
    {
        /// <summary>
        /// Se crea el constructor vacio de la entidad Segundos
        /// </summary>
        public SegundosEntidad()
        {
        }
        /// <summary>
        /// Se crea el constructor con parámetros de la entidad Segundos
        /// </summary>
        /// <param name="idSegundo">El id del segundo</param>
        /// <param name="nomSegundo">El nombre del segundo</param>
        /// <param name="imgSegundo">La imagen del segundo</param>
        /// <param name="ingSegundo">Los ingredientes del segundo</param>
        public SegundosEntidad(int idSegundo, string nomSegundo, byte[] imgSegundo, string ingSegundo)
        {
            IdSegundo = idSegundo;
            NomSegundo = nomSegundo;
            ImgSegundo = imgSegundo;
            IngSegundo = ingSegundo;
        }
        /// <summary>
        /// Se encapsulan los atributos de la clase
        /// </summary>
        public int IdSegundo { get; set; }
        public string NomSegundo { get; set; }
        public byte[] ImgSegundo{ get; set; }
        public string IngSegundo { get; set; }
    }
}
