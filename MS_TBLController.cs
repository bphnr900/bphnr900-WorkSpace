using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MS_TBLController : Controller
    {
        private MSContext db = new MSContext();

        // GET: MS_TBL
        public async Task<ActionResult> Index()
        {
            return View(await db.MS_TBLs.ToListAsync());
        }

        // GET: MS_TBL/Details/5
        public async Task<ActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_TBL mS_TBL = await db.MS_TBLs.FindAsync(id);
            if (mS_TBL == null)
            {
                return HttpNotFound();
            }
            return View(mS_TBL);
        }

        // GET: MS_TBL/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MS_TBL/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,機体番号,機体名,登場作品")] MS_TBL mS_TBL)
        {
            if (ModelState.IsValid)
            {
                db.MS_TBLs.Add(mS_TBL);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(mS_TBL);
        }

        // GET: MS_TBL/Edit/5
        public async Task<ActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_TBL mS_TBL = await db.MS_TBLs.FindAsync(id);
            if (mS_TBL == null)
            {
                return HttpNotFound();
            }
            return View(mS_TBL);
        }

        // POST: MS_TBL/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,機体番号,機体名,登場作品")] MS_TBL mS_TBL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mS_TBL).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(mS_TBL);
        }

        // GET: MS_TBL/Delete/5
        public async Task<ActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MS_TBL mS_TBL = await db.MS_TBLs.FindAsync(id);
            if (mS_TBL == null)
            {
                return HttpNotFound();
            }
            return View(mS_TBL);
        }

        // POST: MS_TBL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(decimal id)
        {
            MS_TBL mS_TBL = await db.MS_TBLs.FindAsync(id);
            db.MS_TBLs.Remove(mS_TBL);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
