using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DatosLinq
{
    public static class SopasDatos
    {
        /// <summary>
        /// Se ingresara una nueva sopa
        /// </summary>
        /// <param name="sopaDia">Variable donde se ingresa los datos de la sopa</param>
        /// <returns>Devuelve la sopa ingresada</returns>
        public static SopasEntidad Nuevo(SopasEntidad sopaDia)
        {
            SOPAS sopa = new SOPAS();
            sopa.ID_SOP = sopaDia.IdSopa;
            sopa.NOM_SOP = sopaDia.NomSopa;
            sopa.IMG_SOP = sopaDia.ImgSopa;
            sopa.ING_SOP = sopaDia.IngSopa;
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                contexto.SOPAS.InsertOnSubmit(sopa);
                contexto.SubmitChanges();
            }
            sopaDia.IdSopa = sopa.ID_SOP;
            return sopaDia;
        }
        /// <summary>
        /// Se modificara los datos de la sopa
        /// </summary>
        /// <param name="sopaDia">Variable donde se guardan los datos</param>
        /// <returns>La sopa con los datos modificados</returns>
        public static SopasEntidad Actualizar(SopasEntidad sopaDia)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var sopa = contexto.SOPAS.FirstOrDefault(cc => cc.ID_SOP == sopaDia.IdSopa);
                    sopa.ID_SOP = sopaDia.IdSopa;
                    sopa.NOM_SOP = sopaDia.NomSopa;
                    sopa.IMG_SOP = sopaDia.ImgSopa;
                    sopa.ING_SOP = sopaDia.IngSopa;
                    contexto.SubmitChanges();
                }
                return sopaDia;

            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Se eliminara la sopa
        /// </summary>
        /// <param name="id">Identificador de la sopa seleccionada</param>
        /// <returns>Se devuelve un boolean que determina la accion</returns>
        public static bool EliminarSopa(int id)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var s = contexto.SOPAS.FirstOrDefault(cc => cc.ID_SOP == id);
                    contexto.SOPAS.DeleteOnSubmit(s);
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
        /// Se enlistara las sopas ingresadas en la base de datos
        /// </summary>
        /// <returns>Devuelve la lista de sopas que estan en la tabla</returns>
        public static List<SopasEntidad> DevolverSopas()
        {
            List<SopasEntidad> listaSopas = new List<SopasEntidad>();
            List<SOPAS> listae = new List<SOPAS>();
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var res = from c in contexto.SOPAS
                              select c;
                    listae = res.ToList();

                }
                foreach (var item in listae)
                {
                    listaSopas.Add(new SopasEntidad(
                            item.ID_SOP,
                            item.NOM_SOP,
                            item.IMG_SOP.ToArray(),
                            item.ING_SOP
                        ));

                }
                return listaSopas;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Se obtendra la sopa junto a los datos seleccionados
        /// </summary>
        /// <param name="id">Identificador de la sopa seleccionada</param>
        /// <returns>Devuelve la sopa seleccionada junto a sus datos</returns>
        public static SopasEntidad DevolverSopasPorId(int id)
        {
            SopasEntidad sopa = new SopasEntidad();
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                var s = contexto.SOPAS.FirstOrDefault(cc => cc.ID_SOP == id);

                sopa.IdSopa = s.ID_SOP;
                sopa.NomSopa = s.NOM_SOP;
                sopa.ImgSopa= s.IMG_SOP.ToArray();
                sopa.IngSopa = s.ING_SOP;
            }
            return sopa;
        }
        /// <summary>
        /// Se obtiene la sopa seleccionada para acceder a sus ingredientes
        /// </summary>
        /// <param name="id">Identificador de la sopa seleccionada</param>
        /// <returns>Se devuelve los datos de la sopa junto al acceso a los ingredientes</returns>
        public static SopasEntidad DevolverIngredientesSopasPorId(int id)
        {
            SopasEntidad sopa = new SopasEntidad();
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                var s = contexto.SOPAS.FirstOrDefault(cc => cc.ID_SOP == id);

                sopa.IdSopa = s.ID_SOP;
                sopa.IngSopa = s.ING_SOP;
            }
            return sopa;
        }
    }
}
