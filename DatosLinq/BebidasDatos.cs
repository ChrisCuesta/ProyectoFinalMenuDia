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
        /// Se registra los datos de las bebidas que ingresara en la base de datos
        /// </summary>
        /// <param name="bebida">Nombre de la variable que debe obtener</param>
        /// <returns>El ingreso de una nueva bebida</returns>

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
        /// Se obtiene los datos de las bebidas que se han ingresado
        /// </summary>
        /// <param name="bebida">Nombre de la variable que se obtiene junto a los datos que estan ingresados</param>
        /// <returns>Los datos de la variable que buscamos</returns>
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
        /// Se obtiene el identificar de la bebida que buscamos o seleccionamos para eliminarla
        /// </summary>
        /// <param name="id">El identificador de los datos que seleccionamos</param>
        /// <returns>Un boolean para determinar si la accion que realizamos es la correcta</returns>
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
        /// Se obtiene una lista de los datos que han sido ingresados en la tabla de la base de datos que buscamos
        /// </summary>
        /// <returns>La lista de los datos de la tabla bebidas</returns>
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
        /// Devuelve la lista de los datos ingresados en la tabla de la bebida que buscamos con su identificador
        /// </summary>
        /// <param name="id">Identificador numerico donde estan los datos de la bebida que buscamos</param>
        /// <returns>la bebida junto a los datos  buscamos de dicha bebida</returns>
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
        /// Cada alimento ingresado cuenta con una lista de ingredientes los cuales solicitamos aqui 
        /// </summary>
        /// <param name="id">Indentificador de la bebida que vamos a buscar sus ingredientes</param>
        /// <returns>La bebida que seleccionamos junto a sus datos para buscar la lista de ingredientes</returns>
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
