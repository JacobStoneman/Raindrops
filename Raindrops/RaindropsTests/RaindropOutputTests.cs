using NUnit.Framework;
using RaindropsLib;

namespace RaindropsTests
{
	public class RaindropOutputTests
	{
		Raindrops Raindrops = new Raindrops(); 

		[TestCase(3)]
		[TestCase(-3)]
		[TestCase(6)]
		public void FactorOf3ReturnsPling(int input)
		{
			Assert.That(Raindrops.GetDrops(input), Is.EqualTo("Pling"));
		}

		[TestCase(5)]
		[TestCase(-5)]
		[TestCase(10)]
		public void FactorOf5ReturnsPlang(int input)
		{
			Assert.That(Raindrops.GetDrops(input), Is.EqualTo("Plang"));
		}

		[TestCase(7)]
		[TestCase(-7)]
		[TestCase(14)]
		public void FactorOf7ReturnsPlong(int input)
		{
			Assert.That(Raindrops.GetDrops(input), Is.EqualTo("Plong"));
		}

		[TestCase(15)]
		[TestCase(-15)]
		[TestCase(30)]
		public void FactorOf3And5ReturnsPlingPlang(int input)
		{
			Assert.That(Raindrops.GetDrops(input), Is.EqualTo("PlingPlang"));
		}

		[TestCase(21)]
		[TestCase(-21)]
		[TestCase(42)]
		public void FactorOf3And7ReturnsPlingPlong(int input)
		{
			Assert.That(Raindrops.GetDrops(input), Is.EqualTo("PlingPlong"));
		}

		[TestCase(35)]
		[TestCase(-35)]
		[TestCase(70)]
		public void FactorOf5And7ReturnsPlangPlong(int input)
		{
			Assert.That(Raindrops.GetDrops(input), Is.EqualTo("PlangPlong"));
		}

		[TestCase(105)]
		[TestCase(-105)]
		[TestCase(210)]
		public void FactorOf3And5And7ReturnsPlingPlangPlong(int input)
		{
			Assert.That(Raindrops.GetDrops(input), Is.EqualTo("PlingPlangPlong"));
		}

		[TestCase(34)]
		[TestCase(-34)]
		[TestCase(68)]
		public void NoFactorOf3Or5Or7ReturnsNumberAsString(int input)
		{
			Assert.That(Raindrops.GetDrops(input), Is.EqualTo(input.ToString()));
		}
	}
}