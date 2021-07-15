using Microsoft.VisualStudio.TestTools.UnitTesting;
using OzonTask;

namespace Tests
{
	[TestClass]
	public class SubArrayFinderTests
	{

		[TestMethod]
		public void TestMethod1()
		{
			var array = new[] { 1, 2, 3 };


			var (left, right) = SubArrayFinder.FindUnsortedSubArray(array);

			Assert.AreEqual(-1, left);
			Assert.AreEqual(-1, right);
		}

		[TestMethod]
		public void TestMethod2()
		{
			var array = new int[0];


			var (left, right) = SubArrayFinder.FindUnsortedSubArray(array);

			Assert.AreEqual(-1, left);
			Assert.AreEqual(-1, right);
		}

		[TestMethod]
		public void TestMethod3()
		{
			var array = new[] { 3, 2, 1 };


			var (left, right) = SubArrayFinder.FindUnsortedSubArray(array);

			Assert.AreEqual(0, left);
			Assert.AreEqual(2, right);
		}

		[TestMethod]
		public void TestMethod4()
		{
			var array = new[] { 1, 2, 1 };


			var (left, right) = SubArrayFinder.FindUnsortedSubArray(array);

			Assert.AreEqual(1, left);
			Assert.AreEqual(2, right);
		}

		[TestMethod]
		public void TestMethod5()
		{
			var array = new[] { 1, 1, 1 };


			var (left, right) = SubArrayFinder.FindUnsortedSubArray(array);

			Assert.AreEqual(-1, left);
			Assert.AreEqual(-1, right);
		}


		[TestMethod]
		public void TestMethod6()
		{
			var array = new[] { 1, 1, 2, 3, 4, 5, 6, 7, 1, 9 };


			var (left, right) = SubArrayFinder.FindUnsortedSubArray(array);

			Assert.AreEqual(2, left);
			Assert.AreEqual(8, right);
		}
	}
}
