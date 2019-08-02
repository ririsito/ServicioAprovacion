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
        }
      

    }
}
