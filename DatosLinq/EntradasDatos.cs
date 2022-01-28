using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace DatosLinq
{
    public static class EntradasDatos
    {
        /// <summary>
        /// Se ingresara una nueva entrada
        /// </summary>
        /// <param name="entrada">Variable donde se ingresara la nueva entrada</param>
        /// <returns>Devolvera la entrada ingresada</returns>
        public static EntradasEntidad Nuevo( EntradasEntidad entrada)
        {
            ENTRADAS e = new ENTRADAS();
            e.ID_ENT = entrada.IdEntrada;
            e.NOM_ENT = entrada.NomEntrada;
            e.IMG_ENT = entrada.ImgEntrada;
            e.ING_ENT = entrada.IngEntrada;
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                contexto.ENTRADAS.InsertOnSubmit(e);
                contexto.SubmitChanges();
            }
            entrada.IdEntrada = e.ID_ENT;
            return entrada;
        }
        /// <summary>
        /// Se obtendra los datos de las entradas ingresadas o seleccionadas
        /// </summary>
        /// <param name="entrada">Variable donde se encuentran los datos de la entrada </param>
        /// <returns>Devolver la entrada con los datos modificados </returns>
        public static EntradasEntidad Actualizar(EntradasEntidad entrada)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {

                    var e = contexto.ENTRADAS.FirstOrDefault(cc => cc.ID_ENT == entrada.IdEntrada);
                    e.ID_ENT = entrada.IdEntrada;
                    e.NOM_ENT = entrada.NomEntrada;
                    e.IMG_ENT = entrada.ImgEntrada;
                    e.ING_ENT = entrada.IngEntrada;
                    contexto.SubmitChanges();
                }
                return entrada;

            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Se eliminara una entrada seleccionada 
        /// </summary>
        /// <param name="id">Identificador de la entrada que seleccionamos</param>
        /// <returns>Devuelve un boolean que determina la accion realizada es decir la eliminacion de la entrada</returns>
        public static bool EliminarEntrada(int id)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var e = contexto.ENTRADAS.FirstOrDefault(cc => cc.ID_ENT == id);
                    contexto.ENTRADAS.DeleteOnSubmit(e);
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
        /// Se enlistara las bebidas ingresadas en la base de datos 
        /// </summary>
        /// <returns>La lista de bebidas que tenemos en la tabla</returns>
        public static List<EntradasEntidad> DevolverEntradas()
        {
            List<EntradasEntidad> listaEntradas= new List<EntradasEntidad>();
            List<ENTRADAS> listae = new List<ENTRADAS>();
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var res = from c in contexto.ENTRADAS
                              select c;
                    listae = res.ToList();

                }
                foreach (var item in listae)
                {
                    listaEntradas.Add(new EntradasEntidad(
                            item.ID_ENT,
                            item.NOM_ENT,
                            item.IMG_ENT.ToArray(),
                            item.ING_ENT
                        ));

                }
                return listaEntradas;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Se obtendra la entrada seleccionada con los datos identificadas 
        /// </summary>
        /// <param name="id">Identificador de la entrada seleccionada</param>
        /// <returns>Devuelve la entrada seleccionada junto a los datos ingresados</returns>
        public static EntradasEntidad DevolverEntradaPorId(int id)
        {
            EntradasEntidad entrada = new EntradasEntidad();
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                var e = contexto.ENTRADAS.FirstOrDefault(cc => cc.ID_ENT == id);

                entrada.IdEntrada=e.ID_ENT;
                entrada.NomEntrada= e.NOM_ENT;
                entrada.ImgEntrada=e.IMG_ENT.ToArray();
                entrada.IngEntrada=e.ING_ENT;
            }
            return entrada;
        }
        /// <summary>
        /// Se accede a una entrada seleccionada para obtener datos de los ingredientes
        /// </summary>
        /// <param name="id">Identificador de la entrada seleccionada</param>
        /// <returns>retorna la entrada seleccionada junto a los ingredientes</returns>
        public static EntradasEntidad DevolverIngredientesEntradaPorId(int id)
        {
            EntradasEntidad entrada = new EntradasEntidad();
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                var e = contexto.ENTRADAS.FirstOrDefault(cc => cc.ID_ENT == id);

                entrada.IdEntrada = e.ID_ENT;
                entrada.IngEntrada = e.ING_ENT;
            }
            return entrada;
        }
    }
}
