using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flangery_net
{
    public class SongController : Controller
    {
        // GET: SongController
        public static IList<SongModel> songs = new List<SongModel>()
        {
            new SongModel() {songId = 1, artist = "Tchami", title = "Adieu", cover = "https://img.discogs.com/5RdPMVaxnuFQpCtZ-w3_qvGfXAw=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-9772713-1486121978-2280.jpeg.jpg" },
            new SongModel() {songId = 2, artist = "Kyle Watson", title = "Noise & Girls", cover = "https://i1.sndcdn.com/artworks-000064426176-kpc1e7-t500x500.jpg" },
            new SongModel() {songId = 3, artist = "Mercer", title = "Opium (VIP Mix)", cover = "https://is2-ssl.mzstatic.com/image/thumb/Music124/v4/80/42/bf/8042bfce-d7bc-d0aa-66b3-f057dcc73509/1060.jpg/400x400cc.jpg" }
        };

        public ActionResult Index()
        { 
            return View(songs); 
        }

        // GET: SongController/Details/5
        public ActionResult Details(int id)
        {
            return View(songs.FirstOrDefault(song => song.songId == id));
        }

        // GET: SongController/Create
        public ActionResult Create()
        {
            return View(new SongModel());
        }

        // POST: SongController/Create
        [HttpPost]
        public ActionResult Create(SongModel songModel)
        {
            songModel.songId = songs.Count + 1;
            songs.Add(songModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: SongController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SongController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SongModel editedSong)
        {
            SongModel song = songs.FirstOrDefault(song => song.songId == id);
            song.title = editedSong.title;
            song.artist = editedSong.artist;
            song.cover = editedSong.cover;
            return RedirectToAction(nameof(Index));
        }

        // GET: SongController/Delete/5
        public ActionResult Delete(int id)
        {
            SongModel song = songs.FirstOrDefault(song => song.songId == id);
            return View(song);
        }

        // POST: SongController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SongModel deletedSong)
        {
            SongModel song = songs.FirstOrDefault(song => song.songId == id);
            songs.Remove(song);
            return RedirectToAction(nameof(Index));
        }
    }
}
