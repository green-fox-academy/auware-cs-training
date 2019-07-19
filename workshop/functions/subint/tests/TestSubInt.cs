using Microsoft.ViusalStudio.TestTools.UnitTesting;
using SubInt;

namespace SubInt.Tests
{
	[TestClass()]
	public class TestSubInt
	{
		[TestMethod()]
		public void TestSubIntHappyCase()
		{
			Assert.AreEqual({0, 1, 4}, SubInt.SubInt(1, {1, 11, 34, 52, 61}));
		}

		[TestMethod()]
		public void TestSubIntSadCase()
		{
			Assert.AreEqual({}, SubInt.SubInt(9, {1, 11, 34, 52, 61}));
		}
	}
}
