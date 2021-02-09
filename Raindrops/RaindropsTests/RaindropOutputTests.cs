using NUnit.Framework;
using RaindropsLib;

namespace RaindropsTests
{
	public class RaindropOutputTests
	{
		Raindrops Raindrops = new Raindrops(); 

		//Test cases check for different configurations of results and edge cases
		[TestCase (28, "Plong")]
		[TestCase (-28, "Plong")]
		[TestCase (30, "PlingPlang")]
		[TestCase (21, "PlingPlong")]
		[TestCase (105, "PlingPlangPlong")]
		[TestCase (34, "34")]
		[TestCase (-34, "-34")]
		public void RaindropsReturnsCorrectOutput(int input, string expected)
		{
			Assert.That(Raindrops.GetDrops(input), Is.EqualTo(expected));
		}
	}
}