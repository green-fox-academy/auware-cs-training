using Microsoft.ViusalStudio.TestTools.UnitTesting;
using Reverse;

namespace Reverse.Tests
{
	[TestClass()]
	public class TestReverse
	{
		[TestMethod()]
		public void TestReverseWithOriginalString()
		{
			string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            string expected = "If the meanings of true and false were switched, this sentence wouldn't be false.";
			Assert.AreEquals(expected, Reverse.Reverse(reversed));
		}
	}
}
