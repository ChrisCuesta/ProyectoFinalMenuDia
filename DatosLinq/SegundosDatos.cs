using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DatosLinq
{
    public static class SegundosDatos
    {
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
