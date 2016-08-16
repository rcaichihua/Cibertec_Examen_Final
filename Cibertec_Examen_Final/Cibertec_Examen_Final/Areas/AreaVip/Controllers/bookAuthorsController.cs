using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cibertec_Examen_Final.DataAccess;
using Cibertec_Examen_Final.model;

namespace Cibertec_Examen_Final.Areas.AreaVip.Controllers
{
    public class bookAuthorsController : Controller
    {
        private book2010 db = new book2010();

        // GET: AreaVip/bookAuthors
        public ActionResult Index()
        {
            var bookAuthor = db.bookAuthor.Include(b => b.authors).Include(b => b.books);
            return View(bookAuthor.ToList());
        }

        // GET: AreaVip/bookAuthors/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bookAuthor bookAuthor = db.bookAuthor.Find(id);
            if (bookAuthor == null)
            {
                return HttpNotFound();
            }
            return View(bookAuthor);
        }

        // GET: AreaVip/bookAuthors/Create
        public ActionResult Create()
        {
            ViewBag.au_id = new SelectList(db.authors, "au_id", "au_lname");
            ViewBag.title_id = new SelectList(db.books, "title_id", "title");
            return View();
        }

        // POST: AreaVip/bookAuthors/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "au_ord,au_id,title_id,royaltyper")] bookAuthor bookAuthor)
        {
            if (ModelState.IsValid)
            {
                db.bookAuthor.Add(bookAuthor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.au_id = new SelectList(db.authors, "au_id", "au_lname", bookAuthor.au_id);
            ViewBag.title_id = new SelectList(db.books, "title_id", "title", bookAuthor.title_id);
            return View(bookAuthor);
        }

        // GET: AreaVip/bookAuthors/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bookAuthor bookAuthor = db.bookAuthor.Find(id);
            if (bookAuthor == null)
            {
                return HttpNotFound();
            }
            ViewBag.au_id = new SelectList(db.authors, "au_id", "au_lname", bookAuthor.au_id);
            ViewBag.title_id = new SelectList(db.books, "title_id", "title", bookAuthor.title_id);
            return View(bookAuthor);
        }

        // POST: AreaVip/bookAuthors/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "au_ord,au_id,title_id,royaltyper")] bookAuthor bookAuthor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookAuthor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.au_id = new SelectList(db.authors, "au_id", "au_lname", bookAuthor.au_id);
            ViewBag.title_id = new SelectList(db.books, "title_id", "title", bookAuthor.title_id);
            return View(bookAuthor);
        }

        // GET: AreaVip/bookAuthors/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bookAuthor bookAuthor = db.bookAuthor.Find(id);
            if (bookAuthor == null)
            {
                return HttpNotFound();
            }
            return View(bookAuthor);
        }

        // POST: AreaVip/bookAuthors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            bookAuthor bookAuthor = db.bookAuthor.Find(id);
            db.bookAuthor.Remove(bookAuthor);
            db.SaveChanges();
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
