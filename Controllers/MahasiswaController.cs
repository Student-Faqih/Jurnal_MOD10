using Microsoft.AspNetCore.Mvc;

namespace Jurnal_MOD10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mhs = new List<Mahasiswa>();

        private readonly ILogger<MahasiswaController> _logger;

        public MahasiswaController(ILogger<MahasiswaController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return mhs;
        }
        [HttpPost(Name = "PostMahasiswa")]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            mhs.Add(mahasiswa);
        }
        [HttpDelete(Name = "DeleteMahasiswa")]
        public void Delete(int idx)
        {
            if (mhs[idx] != null)
            {
                mhs.RemoveAt(idx);
            }
        }
        [HttpGet("{idx}")]
        public Mahasiswa Get(int idx)
        {
            return mhs[idx];
        }
    }
}
