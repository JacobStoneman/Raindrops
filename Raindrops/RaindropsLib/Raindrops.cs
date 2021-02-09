namespace RaindropsLib
{
	public class Raindrops
	{
		public string GetDrops(int input)
		{
			string output = string.Empty;

			//If input is a factor of 3 append Pling
			if (input % 3 == 0) output += "Pling";

			//If input is a factor of 5 append Plang
			if (input % 5 == 0) output += "Plang";

			//If input is a factor of 7 append Plong
			if (input % 7 == 0) output += "Plong";

			//If output has not been set return number as string
			if (output == string.Empty) return input.ToString();

			//Otherwise return the generated output
			else return output;
		}
	}
}
