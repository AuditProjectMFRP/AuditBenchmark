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

            //Assert
            Assert.AreEqual(200, okResult.StatusCode);


        }

        [Test]
        public void GetAuditBenchmark_To_Count_NumberOfElements_ReturnsListOfAuditBenchMark()
        {
            //Arrange
            List<AuditBenchmarkModel> benchmark = new List<AuditBenchmarkModel>
                    {
                       new AuditBenchmarkModel{AuditType="Internal",BenchmarkNoAnswers=3},
                       new AuditBenchmarkModel{AuditType="SOX",BenchmarkNoAnswers=1}
                    };

            //Act
            AuditBenchmarkController obj = new AuditBenchmarkController();
            var data = obj.GetAuditBenchmark();
            var okResult = data.Result as OkObjectResult;
            int val = ((List<AuditBenchmarkModel>)okResult.Value).Count;

            //Assert
            Assert.AreEqual(2, val);
            
        }







    }
}