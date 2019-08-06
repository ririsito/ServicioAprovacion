using ServicioWeb.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioWebAutorizacionPermisos.Controllers
{

  
    public class PermisosController : ApiController
    {
        PermisosQCTTEntities BD = new PermisosQCTTEntities();

        public IEnumerable<Permisos> Get()
        {
            var listado=BD.Permisos.ToList();
            return listado;
        }

        public IEnumerable<Permisos> GetByID(int Id)
        {
            var listado = BD.Permisos
                .Where(x=>x.Id==Id)
                .ToList();
            return listado;
        }

        //UpdatePermiso
        public void PostModPermiso(int IdPer, int IdEstado)
        {
            Permisos Permiso = BD.Permisos.Single(x => x.Id == IdPer);
            Permiso.IdEstado = IdEstado;
            BD.SaveChanges();
            updateRangoFechas(Permiso, IdEstado);
        }
        //update vacaciones
        public void updateRangoFechas(Permisos permiso, int IdEstado)
        {
            
            var desc = permiso.Descripcion;
            var numero = permiso.Numero;
            var fechaFinal = permiso.FechaRegreso;
            var tipoPermiso = permiso.TipoPermiso;
            var horaSalida = permiso.HoraSalida;
            var listado = BD.Permisos.ToList();

            if (tipoPermiso.Equals("Vacaciones") || tipoPermiso.Equals("Salida y Regreso")|| 
                tipoPermiso.Equals("Incapacidad")||tipoPermiso.Equals("Sin Asistencia"))
            {

                var listadoRango = listado.Where(x => x.Numero == numero && x.Descripcion == desc 
                && x.FechaRegreso == fechaFinal && x.TipoPermiso ==tipoPermiso && x.HoraSalida== horaSalida).ToList();
                for (int i = 0; i < listadoRango.Count; i++)
                {                    
                    var Idpermiso = listadoRango[i].Id;
                    Permisos Permiso = BD.Permisos.Single(x => x.Id == Idpermiso);
                    Permiso.IdEstado = IdEstado;
                    BD.SaveChanges();
                }

            }
        }


    }
}
