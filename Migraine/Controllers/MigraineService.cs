using Migraine.Models;
using MigraineData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Migraine.Controllers
{
    public class MigraineServiceController : ApiController
    {
        IMigraineDAO _migraineDAO;
        static List<migraine> migranias; 

        public MigraineServiceController() : this(new MigraineDAO())
        {
            if (migranias == null)
                migranias = new List<migraine>();
        }
        public MigraineServiceController(IMigraineDAO migraineDao)
        {
            _migraineDAO = migraineDao;
        }

        // POST api/<controller>
        [HttpPost]
        public IHttpActionResult Post([FromBody]migraine migraine)
        {            
            try
            {
                //addMigrania(migraine);
                byte[] imageBytes = Convert.FromBase64String(migraine.audio_file);
                string FilePath = System.Web.Hosting.HostingEnvironment.MapPath("~/Audio/") + "\\";
                var nameVideo = UniqueIdentifierVideo.getNextIdVideo() + ".mp3";
                string FullFilePath = FilePath + nameVideo;

                if (!File.Exists(FullFilePath))
                {
                    File.WriteAllBytes(FullFilePath, imageBytes);
                }
                migraine.audio_file = FullFilePath;

                _migraineDAO.registerMigraine(migraine);
            }
            catch(Exception ex)
            {
                return BadRequest("Error:" + ex);
            }
            return Ok();
        }

        private void addMigrania(migraine migraine) {
            migranias.Add(migraine);
        }


        public IHttpActionResult GetMigraines()
        {
            var migraines = new List<migraine>();
            try
            {
                migraines = _migraineDAO.getMigraines();
            } catch(Exception ex) {
                return BadRequest("Error:" + ex);
            }
            return Ok(migraines);
        }
        
    }
}