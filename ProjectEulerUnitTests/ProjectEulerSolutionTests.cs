using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectEulerSolutions;

namespace ProjectEulerUnitTests
{
    public class ProjectEulerSolutionTests
    {
        [Test]
        public void SolveProblem1WithExampleData()
        {
            // Act
            int result = Problem1.Solve(10);

            // Assert
            Assert.AreEqual(23, result);
        }

        [Test]
        public void SolveProblem2WithExampleData()
        {
            // Act
            int result = Problem2.Solve(89);

            // Assert
            Assert.AreEqual(44, result);
        }
        
        [Test]
        public void SolveProblem6WithExampleData()
        {
            // Act
            int result = Problem6.Solve(10);

            // Assert
            Assert.AreEqual(2640, result);
        }
    }
}
