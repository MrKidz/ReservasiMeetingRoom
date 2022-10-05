using ReservasiMeetingRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservasiMeetingRoom.Controllers
{
    public class HomeController : Controller
    {
        MDKAReservasiEntities mDKAReservasiEntities = new MDKAReservasiEntities();
        public ActionResult Index()
        {
            return View(mDKAReservasiEntities.tblM_Ruangan.ToList());
        }

        public ActionResult EditReservasi()
        {
            return View(mDKAReservasiEntities.tblM_Ruangan.Where(p => p.Status_FK == 2).ToList());
        }

        [HttpPost]
        public ActionResult SaveEditReservasi(tblT_Reservasi reservasi)
        {
            try
            {
                // TODO: Add insert logic here
                var ruangan = mDKAReservasiEntities.tblM_Ruangan.Where(p => p.Ruangan_PK == reservasi.Ruangan_FK).FirstOrDefault();
                ruangan.Status_FK = 1;
                mDKAReservasiEntities.tblT_Reservasi.Add(reservasi);
                mDKAReservasiEntities.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult SaveNewReservasi(tblT_Reservasi reservasi)
        {
            try
            {
                // TODO: Add insert logic here
                mDKAReservasiEntities.tblT_Reservasi.Add(reservasi);
                mDKAReservasiEntities.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult NewReservasi()
        {
            return View(mDKAReservasiEntities.tblM_Ruangan.Where(p => p.Status_FK == 2).ToList());
        }
    }
}