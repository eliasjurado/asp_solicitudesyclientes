using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio.Core.Entities;
using Dominio.MainModule;

namespace EF_JURADO.Controllers
{
    public class NegociosController : Controller
    {
        ClienteManager clim = new ClienteManager();
        SolicitudManager solm = new SolicitudManager();

        public ActionResult Index()
        {
            return View(solm.ListaSolicitudes());
        }

        public ActionResult AgregarSolicitud()
        {
            ViewBag.clientes = new SelectList(clim.ListaClientes(),"idcliente","nombrecia");
            return View(new Solicitud());
        }

        [HttpPost]
        public ActionResult AgregarSolicitud(Solicitud reg)
        {
            if (!ModelState.IsValid)
            {
                return View(reg);
            }
            ViewBag.mensaje = solm.AgregarCliente(reg);
            ViewBag.clientes = new SelectList(clim.ListaClientes(), "idcliente", "nombrecia",reg.idcliente);
            return View(reg);
        }
    }
}