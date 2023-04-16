using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tpmodul9_1302210090
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa : ControllerBase
    {
        public string Nama { get; set; }
        public string Nim { get; set; }

        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Muhammad Irfan Syauqi", Nim = "1302210090" },
            new Mahasiswa { Nama = "Arya Dul Fitra Ashari", Nim = "1302213020" },
            new Mahasiswa { Nama = "Muhammad Burhan", Nim = "1302213109" },
            new Mahasiswa { Nama = "Hasnan Husaini", Nim = "1302210100" },
            new Mahasiswa { Nama = "Tio Haidar Hanif", Nim = "1302210057" },
            new Mahasiswa { Nama = "Chandra Bayu Samudra", Nim = "1302210134"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAllMahasiswa()
        {
            return Ok(mahasiswaList);
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
            {
                return NotFound();
            }
            return Ok(mahasiswaList[index]);
        }

        [HttpPost]
        public ActionResult AddMahasiswa(Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
            {
                return NotFound();
            }
            mahasiswaList.RemoveAt(index);
            return Ok();
        }
    }
}

