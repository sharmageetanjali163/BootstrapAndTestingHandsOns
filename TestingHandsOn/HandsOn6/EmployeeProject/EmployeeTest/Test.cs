using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EmployeeProject;
using static EmployeeProject.Program;

namespace EmployeeTest
{
    [TestFixture]
    public class Test
    
    {
        [Test]
        public void AddEmployeeTest()
        {
            EmployeeManager emp = new EmployeeManager();
            Assert.That(emp.HeadCount, Is.EqualTo(0));
            Employee ob = new Employee()
            {
                Id = 101,
                Name = "Raj"
            };
            emp.AddEmployee(ob);
            Assert.That(emp.HeadCount, Is.EqualTo(1));
        }
    }
}
