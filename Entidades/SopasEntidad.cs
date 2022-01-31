using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SopasEntidad
    {
        /// <summary>
        /// Se encapsulan los atributos de la clase
        /// </summary>
        public int IdSopa { get; set; }
        public string NomSopa { get; set; }
        public byte[] ImgSopa { get; set; }
        public string IngSopa { get; set; }
        /// <summary>
        /// Se crea el constructor vacio de la entidad Sopas
        /// </summary>
        public SopasEntidad() { 
        }
        /// <summary>
        /// Se crea el constructor con parámetros de la entidad Sopas
        /// </summary>
        /// <param name="idSopa">La id de la sopa</param>
        /// <param name="nomSopa">El nombre de la sopa</param>
        /// <param name="imgSopa">La imagen de la sopa</param>
        /// <param name="ingSopa">Los ingredientes de la sopa</param>
        public SopasEntidad(int idSopa, string nomSopa, byte[] imgSopa, string ingSopa)
        {
            IdSopa = idSopa;
            NomSopa = nomSopa;
            ImgSopa = imgSopa;
            IngSopa = ingSopa;
        }
    }
    
}
