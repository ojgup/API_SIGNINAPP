using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using API_SIGNINAPP.Models;

namespace API_SIGNINAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {

        // GET api/Classes
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            // sign-in-app.database.windows.net
            // username : milan
            // password : Swinburne1

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] Classes value)
        {
            string query = "INSERT INTO CLASS (CLASSID, DAY, STARTTIME, ENDTIME, NAME, LABEL)" +
                "VALUES ( {0}, '{1}', '{2}')";

            query = string.Format(query, value.ClassID, value.Day, value.StartTime, value.EndTime, value.Name, value.Label);

            SqlConnection conn = DB.GetConnection();
            SqlCommand comm;
            int NumRows = 0;
            string output = "";

            try
            {
                conn.Open();
                comm = new SqlCommand(query, conn);
                NumRows = comm.ExecuteNonQuery();
                output = string.Format("{0} rows inserted", NumRows.ToString());
            }
            catch
            {
                throw new NotImplementedException();
            }
            return output;


        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
