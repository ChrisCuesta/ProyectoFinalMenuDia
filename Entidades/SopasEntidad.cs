using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SopasEntidad
    {
        public int IdSopa { get; set; }
        public string NomSopa { get; set; }
        public byte[] ImgSopa { get; set; }
        public string IngSopa { get; set; }
        
        public SopasEntidad() { 
        }

        public SopasEntidad(int idSopa, string nomSopa, byte[] imgSopa, string ingSopa)
        {
            IdSopa = idSopa;
            NomSopa = nomSopa;
            ImgSopa = imgSopa;
            IngSopa = ingSopa;
        }
        
        public SopasEntidad(int idSopa, string ingSopa)
        {
            IdSopa = idSopa;
            IngSopa = ingSopa;
        }
    }
    
}
