using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DatosLinq
{
    public static class MenuDiaDatos
    {
        /// <summary>
        /// Se ingresara un nuevo menu
        /// </summary>
        /// <param name="menuDia">variable donde se ingresaran los datos del nuevo menu</param>
        /// <returns>Devuelve el menu ingresado junto a sus datos</returns>
        public static MenuDiaEntidad Nuevo(MenuDiaEntidad menuDia)
        {
            MENU_DEL_DIA menu = new MENU_DEL_DIA();
            menu.NUM_MEN = menuDia.NumMen;
            menu.ID_SOP_PER = menuDia.IdSopaPer;
            menu.ID_SEG_PER = menuDia.IdSegPer;
            menu.ID_BEB_PER = menuDia.IdBebPer;
            menu.ID_ENT_PER = menuDia.IdEntPer;
            menu.FEC_MEN = menuDia.FecMen;
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                contexto.MENU_DEL_DIA.InsertOnSubmit(menu);
                contexto.SubmitChanges();
            }
            menuDia.NumMen = menu.NUM_MEN;
            return menuDia;
        }
        /// <summary>
        /// Se obtendra los datos de un menu seleccionado para modificar datos
        /// </summary>
        /// <param name="menuDia">Variable donde se encuentra los datos del menu seleccionado</param>
        /// <returns>Devuelve el menu con los datos actualizados</returns>
        public static MenuDiaEntidad Actualizar(MenuDiaEntidad menuDia)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {

                    var menu = contexto.MENU_DEL_DIA.FirstOrDefault(cc => cc.NUM_MEN == menuDia.NumMen);
                    
                    menu.NUM_MEN = menuDia.NumMen;
                    menu.ID_SOP_PER = menuDia.IdSopaPer;
                    menu.ID_SEG_PER = menuDia.IdSegPer;
                    menu.ID_BEB_PER = menuDia.IdBebPer;
                    menu.ID_ENT_PER = menuDia.IdEntPer;
                    menu.FEC_MEN = menuDia.FecMen;
                    contexto.SubmitChanges();
                }
                return menuDia;

            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Se eliminara el menu seleccionado 
        /// </summary>
        /// <param name="id">Identificador del menu seleccionado</param>
        /// <returns>Se devuelve un boolean que determina la accion realizada</returns>
        public static bool EliminarMenuDia(int id)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var menu = contexto.MENU_DEL_DIA.FirstOrDefault(cc => cc. NUM_MEN == id);
                    contexto.MENU_DEL_DIA.DeleteOnSubmit(menu);
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
        /// Se enlistara los menus ingresados en la base de datos
        /// </summary>
        /// <returns>Devuelve todos los menus que se encuentran en la tabla</returns>
        public static List<MenuDiaEntidad> DevolverMenuDia()
        {
            List<MenuDiaEntidad> listaMenuDiaEntidad = new List<MenuDiaEntidad>();
            List<MENU_DEL_DIA> listaMenuDia = new List<MENU_DEL_DIA>();
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var res = from c in contexto.MENU_DEL_DIA
                              select c;
                    listaMenuDia = res.ToList();

                }
                foreach (var item in listaMenuDia)
                {
                    listaMenuDiaEntidad.Add(new MenuDiaEntidad(
                            item.NUM_MEN,
                            (int)item.ID_SOP_PER,
                            (int)item.ID_SEG_PER,
                            (int)item.ID_BEB_PER,
                            (int)item.ID_ENT_PER,
                            item.FEC_MEN.GetValueOrDefault()
                        ));

                }
                return listaMenuDiaEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Se devuelve los menus seleccionado adjuntando las clases de los paltos correspondientes
        /// </summary>
        /// <returns>Obtenemos los datos de los platos ingresados en los menus</returns>
        public static List<MenuDiaJoin> DevolverMenuDiaJoin()
        {
            List<MenuDiaJoin> listaMenuDiaEntidad = new List<MenuDiaJoin>();
            List<MENU_DEL_DIA> listaMenuDia = new List<MENU_DEL_DIA>();
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var res = from c in contexto.MENU_DEL_DIA
                              select c;
                    listaMenuDia = res.ToList();
                    foreach (var item in listaMenuDia)
                    {
                        var objSopa = (from sopa in contexto.SOPAS
                                       join menu in contexto.MENU_DEL_DIA
                                       on sopa.ID_SOP equals menu.ID_SOP_PER
                                       where item.ID_SOP_PER == sopa.ID_SOP
                                       select new { sopa.NOM_SOP });
                        string sopa1 = null;
                        foreach (var ownerAndPet in objSopa)
                        {
                            sopa1 = ($"{ownerAndPet.NOM_SOP}");

                        }

                        var objSeg = (from seg in contexto.SEGUNDOS
                                       join menu in contexto.MENU_DEL_DIA
                                       on seg.ID_SEG equals menu.ID_SEG_PER
                                       where item.ID_SEG_PER == seg.ID_SEG
                                       select new { seg.NOM_SEG });
                        string segundo = null;
                        foreach (var ownerAndPet in objSeg)
                        {
                            segundo = ($"{ownerAndPet.NOM_SEG}");

                        }

                        var objBeb = (from beb in contexto.BEBIDAS
                                       join menu in contexto.MENU_DEL_DIA
                                       on beb.ID_BEB equals menu.ID_BEB_PER
                                       where item.ID_BEB_PER == beb.ID_BEB
                                       select new { beb.NOM_BEB });
                        string bebida = null;
                        foreach (var ownerAndPet in objBeb)
                        {
                            bebida = ($"{ownerAndPet.NOM_BEB}");

                        }

                        var objEnt = (from ent in contexto.ENTRADAS
                                      join menu in contexto.MENU_DEL_DIA
                                      on ent.ID_ENT equals menu.ID_ENT_PER
                                      where item.ID_ENT_PER == ent.ID_ENT
                                      select new { ent.NOM_ENT});
                        string entrada = null;
                        foreach (var ownerAndPet in objEnt)
                        {
                            entrada = ($"{ownerAndPet.NOM_ENT}");

                        }

                        //agregar a la entidad
                        listaMenuDiaEntidad.Add(new MenuDiaJoin(
                            item.NUM_MEN,
                            sopa1,
                            segundo,
                            bebida,
                            entrada,
                            item.FEC_MEN.GetValueOrDefault()
                        ));
                    }
                    }
                return listaMenuDiaEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Se obtendra un menu seleccionado
        /// </summary>
        /// <param name="id">Identificador del menu seleccionado</param>
        /// <returns>Se devuelve el menu seleccionado junto a los datos</returns>
        public static MenuDiaEntidad DevolverMenuDiaPorId(int id)
        {
            MenuDiaEntidad menuDia = new MenuDiaEntidad();
            using (DataClasses1DataContext contexto = new DataClasses1DataContext())
            {
                var menu = contexto.MENU_DEL_DIA.FirstOrDefault(cc => cc.NUM_MEN == id);

                menuDia.NumMen = menu.NUM_MEN;
                menuDia.IdSopaPer = (int)menu.ID_SOP_PER;
                menuDia.IdSegPer = (int)menu.ID_SEG_PER;
                menuDia.IdBebPer = (int)menu.ID_BEB_PER;
                menuDia.IdEntPer = (int)menu.ID_ENT_PER;
                menuDia.FecMen = menu.FEC_MEN.GetValueOrDefault();
            }
            return menuDia;
        }
        /// <summary>
        /// Se enlistara los menus que son filtrados por una fecha seleccionada 
        /// </summary>
        /// <param name="date">variable que sirve como filtro o condicion </param>
        /// <returns>Devolvera los menus que se encuentran en una fecha establecida</returns>
        public static List<MenuDiaEntidad> DevolverMenuDiaPorFecha(DateTime date)
        {
            List<MenuDiaEntidad> listaMenuDiaEntidad = new List<MenuDiaEntidad>();
            List<MENU_DEL_DIA> listaMenuDia = new List<MENU_DEL_DIA>();
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var res = from c in contexto.MENU_DEL_DIA where c.FEC_MEN == date
                              select c;
                    listaMenuDia = res.ToList();

                }
                foreach (var item in listaMenuDia)
                {
                    listaMenuDiaEntidad.Add(new MenuDiaEntidad(
                            item.NUM_MEN,
                            (int)item.ID_SOP_PER,
                            (int)item.ID_SEG_PER,
                            (int)item.ID_BEB_PER,
                            (int)item.ID_ENT_PER,
                            item.FEC_MEN.GetValueOrDefault()
                        ));

                }
                return listaMenuDiaEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
