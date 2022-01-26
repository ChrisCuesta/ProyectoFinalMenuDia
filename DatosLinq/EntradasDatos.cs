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
