using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JaggedArraySort1;

namespace JaggedArraySortInt.Tests
{
    [TestClass]
    public class JaggedArraySortTest
    {
        
        [TestMethod]
        public void BubbleSortTest()
        {
            int[][] arrayTest = new int[4][];
            arrayTest[0] = new[] { 10, 20 };
            arrayTest[1] = new[] { 1, 2, 8, 12 };
            arrayTest[2] = new[] { 5, 10, 16 };
            arrayTest[3] = new[] { 18, 1, 5, 6, 8 };
            
           

            int[][] arrayTest1 = new int[4][];
            arrayTest1[0] = new[]{ 1, 2, 8, 12 };
            arrayTest1[1] = new[] { 10, 20 };
            arrayTest1[2] = new[] { 5, 10, 16 };
            arrayTest1[3] = new[] { 18, 1, 5, 6, 8 };

            
;
            Assert.IsTrue(arrayTest1.SequenceEqual(JaggedArraySort.Sort(arrayTest, new AscendingSumSort())));
                   
           
        }
    }
}
