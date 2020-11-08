using CSharp;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class StudentTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void Greet()
        //{
        //    Assert.Pass();
        //}

        //[Test]
        //public void Learn()
        //{

        //}

        [Test]
        public void GetMaxTest()
        {
            int max = BaseLearn.GetMax(new int[] { 2, 7, 10, 203, -2, 0, 16 });
            Assert.AreEqual(203, max);


            Assert.AreEqual(203, BaseLearn.GetMax(new int[] { -203, 2, 7, 10, 203, -2, 0, 16 }));
            Assert.AreEqual(203, BaseLearn.GetMax(new int[] { -203, 2, 7, 10, 203, -2, 0, 16 }));
            Assert.AreEqual(20, BaseLearn.GetMax(new int[] { -203, 2, 7, 10, 20, -2, 0, 20 }));



        }

        [Test]
        public void GetMinTest()
        {
            int min = BaseLearn.GetMin(new int[] { 2, 7, 10, 203, -2, 0, 16 });
            Assert.AreEqual(-2, min);

        }
    }
}