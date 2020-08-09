using AuditBenchmark.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AuditBenchmark.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditBenchmarkController : ControllerBase
    {
        readonly log4net.ILog _log4net;

        public AuditBenchmarkController()
        {
            _log4net = log4net.LogManager.GetLogger(typeof(AuditBenchmarkController));
        }

        [HttpGet]
        public ActionResult<List<AuditBenchmarkModel>> GetAuditBenchmark()
        {
            _log4net.Info(" Http GET request");

            List<AuditBenchmarkModel> benchmark = new List<AuditBenchmarkModel>
                    {
                       new AuditBenchmarkModel{AuditType="Internal",BenchmarkNoAnswers=3},
                       new AuditBenchmarkModel{AuditType="SOX",BenchmarkNoAnswers=1}
                    };
            return Ok(benchmark);



        }

    }
}