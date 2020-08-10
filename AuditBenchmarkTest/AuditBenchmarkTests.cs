using AuditBenchmark.Controllers;
using AuditBenchmark.Model;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;

namespace AuditBenchmarkTest
{
    public class AuditBenchmarkTests
    {

        [Test]
        public void GetAuditBenchmark_ReturnsListOfAuditBenchMark()
        {

              //Act
            AuditBenchmarkController obj = new AuditBenchmarkController();
            var data = obj.GetAuditBenchmark();
            var okResult = data.Result as OkObjectResult;
            int val = ((List<AuditBenchmarkModel>)okResult.Value).Count;

            //Assert
            Assert.AreEqual(200, okResult.StatusCode);
            Assert.AreEqual(2, val);
        }





    }
}
