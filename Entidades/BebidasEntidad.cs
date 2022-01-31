using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BebidasEntidad
    {
        /// <summary>
        /// Se crea el constructor vacío para la entidad Bebidas
        /// </summary>
        public BebidasEntidad()
        {
        }
        /// <summary>
        /// Se crea el constructor con parámetros de la entidad Bebidas
        /// </summary>
        /// <param name="idBebida">El id de la bebida</param>
        /// <param name="nomBebida">El nombre de la bebida</param>
        /// <param name="imgBebida">La imagen de la bebida</param>
        /// <param name="ingBebida">Los ingredientes de la bebida</param>
        public BebidasEntidad(int idBebida, string nomBebida, byte[] imgBebida, string ingBebida)
        {
            IdBebida = idBebida;
            NomBebida = nomBebida;
            ImgBebida = imgBebida;
            IngBebida = ingBebida;
        }
        /// <summary>
        /// Se encapsulan los atributos de la clase
        /// </summary>
        public int IdBebida { get; set; }
        public string NomBebida{ get; set; }
        public byte[] ImgBebida { get; set; }
        public string IngBebida{ get; set; }
    }
}
