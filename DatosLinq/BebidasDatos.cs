using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DatosLinq
{
    public static class BebidasDatos
    {
        /// <summary>
        /// Ingresaremos una nueva bebida
        /// </summary>
        /// <param name="bebida">Variable con la cual se agregara la nueva bebida</param>
        /// <returns>La varibale ingresada junto a sus datos</returns>
        public static BebidasEntidad Nuevo(BebidasEntidad bebida)
        {
            BEBIDAS b = new BEBIDAS();
            b.ID_BEB = bebida.IdBebida;
            b.NOM_BEB = bebida.NomBebida;
            b.IMG_BEB = bebida.ImgBebida;
            b.ING_BEB = bebida.IngBebida;
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                contexto.BEBIDAS.InsertOnSubmit(b);
                contexto.SubmitChanges();
            }
            bebida.IdBebida= b.ID_BEB;
            return bebida;
        }
        /// <summary>
        /// So obtendra los datos de la bebida seleccionada
        /// </summary>
        /// <param name="bebida">Variable que identifica la beboda seleccionada</param>
        /// <returns>La bebida que seleccionamos junto a los datos modificados</returns>
        public static BebidasEntidad Actualizar(BebidasEntidad bebida)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {

                    var b = contexto.BEBIDAS.FirstOrDefault(cc => cc.ID_BEB == bebida.IdBebida);
                    b.ID_BEB = bebida.IdBebida;
                    b.NOM_BEB = bebida.NomBebida;
                    b.IMG_BEB = bebida.ImgBebida;
                    b.ING_BEB = bebida.IngBebida;
                    contexto.SubmitChanges();
                }
                return bebida;

            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Se obtendra la bebida seleccionada para eliminarla 
        /// </summary>
        /// <param name="id">Identificador de la bebida seleccionada</param>
        /// <returns>Un boolean que identifica la accion de eliminar la bebida</returns>
        public static bool EliminarBebidas(int id)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var b = contexto.BEBIDAS.FirstOrDefault(cc => cc.ID_BEB== id);
                    contexto.BEBIDAS.DeleteOnSubmit(b);
                    contexto.SubmitChanges();
                    return true;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// Elistara las bebidas ingresadas en la base de datos
        /// </summary>
        /// <returns>La lista de bebidas ingresadas junto a sus datos</returns>
        public static List<BebidasEntidad> DevolverBebidas()
        {
            List<BebidasEntidad> listaBebidas = new List<BebidasEntidad>();
            List<BEBIDAS> listae = new List<BEBIDAS>();
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var res = from c in contexto.BEBIDAS
                              select c;
                    listae = res.ToList();

                }
                foreach (var item in listae)
                {
                    listaBebidas.Add(new BebidasEntidad(
                            item.ID_BEB,
                            item.NOM_BEB,
                            item.IMG_BEB.ToArray(),
                            item.ING_BEB
                        ));

                }
                return listaBebidas;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Obtendra una bebida seleccionada junto a los datos proporcionados 
        /// </summary>
        /// <param name="id">Identificador de la bebida seleccionada</param>
        /// <returns>Nos devuelve la bebida seleccionada con sus respectivos datos </returns>
        public static BebidasEntidad DevolverBebidaPorId(int id)
        {
            BebidasEntidad bebida = new BebidasEntidad();
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                var b = contexto.BEBIDAS.FirstOrDefault(cc => cc.ID_BEB == id);

                bebida.IdBebida = b.ID_BEB;
                bebida.NomBebida = b.NOM_BEB;
                bebida.ImgBebida=b.IMG_BEB.ToArray();
                bebida.IngBebida= b.ING_BEB;
            }
            return bebida;
        }
        /// <summary>
        /// Obtendremos la bebida seleccionada para acceder a sus ingredientes 
        /// </summary>
        /// <param name="id">Identificador de la bebida seleccionada para acceder a sus ingredientes</param>
        /// <returns>La bebida seleccionada</returns>
        public static BebidasEntidad DevolverIngredientesBebidaPorId(int id)
        {
            BebidasEntidad bebida = new BebidasEntidad();
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                var b = contexto.BEBIDAS.FirstOrDefault(cc => cc.ID_BEB == id);

                bebida.IdBebida = b.ID_BEB;
                bebida.IngBebida = b.ING_BEB;
            }
            return bebida;
        }
    }
}
