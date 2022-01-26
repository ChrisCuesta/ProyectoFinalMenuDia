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
