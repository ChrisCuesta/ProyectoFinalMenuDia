using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


///
/// <author> Anthony Paredes
/// 


namespace DatosLinq
{
    public static class SegundosDatos
    {
        /// <summary>
        /// Se ingresara un nuevo segundo 
        /// </summary>
        /// <param name="segundo">Variable donde se ingresa datos del nuevo segundo</param>
        /// <returns>El segundo ingresado</returns>
        public static SegundosEntidad Nuevo(SegundosEntidad segundo)
        {
            SEGUNDOS s = new SEGUNDOS();
            s.ID_SEG = segundo.IdSegundo;
            s.NOM_SEG = segundo.NomSegundo;
            s.IMG_SEG = segundo.ImgSegundo;
            s.ING_SEG = segundo.IngSegundo;
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                contexto.SEGUNDOS.InsertOnSubmit(s);
                contexto.SubmitChanges();
            }
            segundo.IdSegundo = s.ID_SEG;
            return segundo;
        }
        /// <summary>
        /// Se modificar los datos ingresados en algun segundo
        /// </summary>
        /// <param name="segundo">Variable donde esta ingresado los datos del segundo</param>
        /// <returns>Se devuelve el segundo con los datos modificados</returns>
        public static SegundosEntidad Actualizar(SegundosEntidad segundo)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {

                    var s = contexto.SEGUNDOS.FirstOrDefault(cc => cc.ID_SEG == segundo.IdSegundo);
                    s.ID_SEG= segundo.IdSegundo;
                    s.NOM_SEG = segundo.NomSegundo;
                    s.IMG_SEG = segundo.ImgSegundo;
                    s.ING_SEG = segundo.IngSegundo;
                    contexto.SubmitChanges();
                }
                return segundo;

            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Se eliminara el el segundo seleccionado
        /// </summary>
        /// <param name="id">Identicador del segundo seleccionado</param>
        /// <returns>Devuelve un boolean que determinara la accion de eliminar</returns>
        public static bool EliminarSegundo(int id)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var s = contexto.SEGUNDOS.FirstOrDefault(cc => cc.ID_SEG == id);
                    contexto.SEGUNDOS.DeleteOnSubmit(s);
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
        /// Se enlistara los segundos ingresados en la base de datos 
        /// </summary>
        /// <returns>Se devuleve los platos ingresador en la tabla</returns>
        public static List<SegundosEntidad> DevolverSegundos()
        {
            List<SegundosEntidad> listaSegundos = new List<SegundosEntidad>();
            List<SEGUNDOS> listae = new List<SEGUNDOS>();
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var res = from c in contexto.SEGUNDOS
                              select c;
                    listae = res.ToList();

                }
                foreach (var item in listae)
                {
                    listaSegundos.Add(new SegundosEntidad(
                            item.ID_SEG,
                            item.NOM_SEG,
                            item.IMG_SEG.ToArray(),
                            item.ING_SEG
                        ));

                }
                return listaSegundos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Se devuelve el plato seleccionado junto a sus datos
        /// </summary>
        /// <param name="id">Identificador del plato seleccionado</param>
        /// <returns>Devuelve el plato seleccionado con los datos establecidos</returns>
        public static SegundosEntidad DevolverSegundoPorId(int id)
        {
            SegundosEntidad segundo = new SegundosEntidad();
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                var s = contexto.SEGUNDOS.FirstOrDefault(cc => cc.ID_SEG == id);

                segundo.IdSegundo = s.ID_SEG;
                segundo.NomSegundo = s.NOM_SEG;
                segundo.ImgSegundo=s.IMG_SEG.ToArray();
                segundo.IngSegundo = s.ING_SEG;
            }
            return segundo;
        }
        /// <summary>
        /// Se devuelve el plato seleccionado junto a sus datos para acceder a los ingredientes
        /// </summary>
        /// <param name="id">Identificador del plato seleccionado</param>
        /// <returns>Devuelve el plato seleccionado con los datos establecidos para acceder a los ingredientes</returns>
        public static SegundosEntidad DevolverIngredientesSegundosPorId(int id)
        {
            SegundosEntidad segundo = new SegundosEntidad();
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                var s = contexto.SEGUNDOS.FirstOrDefault(cc => cc.ID_SEG == id);

                segundo.IdSegundo = s.ID_SEG;
                segundo.IngSegundo = s.ING_SEG;
            }
            return segundo;
        }
    }
}
