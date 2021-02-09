using NUnit.Framework;
using RaindropsLib;

namespace RaindropsTests
{
	public class RaindropOutputTests
	{
		Raindrops Raindrops = new Raindrops(); 

		[TestCase (28, "Plong")]
		[TestCase (30, "PlingPlang")]
		[TestCase (34, "34")]
		public void RaindropsReturnsCorrectOutput(int input, string expected)
		{
			Assert.That(Raindrops.GetDrops(input), Is.EqualTo(expected));
		}
	}
}