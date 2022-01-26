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
