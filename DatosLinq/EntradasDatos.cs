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
        /// Se ingresara una nueva entrada junto a los datos solicitados de la base de datos
        /// </summary>
        /// <param name="entrada">La variable que se debe ingresar</param>
        /// <returns>La entradajunto a los datos ingresados</returns>
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
        /// Se obtendra los datos de las entradas ingresadas para modificarlos
        /// </summary>
        /// <param name="entrada">Variable donde se encuentra los datos ingresados</param>
        /// <returns>Nombre de la varibale la cual hemos modificado</returns>
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
        /// Se obtendra la entrada junto a los datos ingresador para poder eliminar 
        /// </summary>
        /// <param name="id">Identificador de la entrada que ingresamos y seleccionamos </param>
        /// <returns>Se obtiene un boolean que ejecuta la accion de eliminar segun proceda el boton</returns>
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
        /// Se enlistara las entradas ingresadas dentro de la base de datos
        /// </summary>
        /// <returns>Se devuelve todas las variables ingresadas en dicha tabla</returns>
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
        /// Se obtiene la entrada seleccionada por el id para tener en cuenta los datos
        /// </summary>
        /// <param name="id">Identificador de la entrada que seleccionamos </param>
        /// <returns>Devuelve los datos de la entrada seleccionada</returns>
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
        /// Se obtiene la entrada seleccionada por id para tener acceso a los datos de los ingrediente
        /// </summary>
        /// <param name="id">Identificador de la entrada que seleccionamos</param>
        /// <returns>retorna la entrada seleccionada junto a sus datos para poder acceder a los ingrdientes</returns>
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
