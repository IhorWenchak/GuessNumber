using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
	public class GuessManager
	{
		private string givenString = String.Empty;
		private int givenNumber;
		private int number;
		Random rnd = new Random();

		public GuessManager()
		{
			number = rnd.Next(0, 101);
		}

		public bool IsNumber
		{
			get {
				if (int.TryParse(GivenString, out givenNumber))
					return true;
				else
					return false;
			}
		}

		public int Number {
			get {
				return number;
			}
			set {
				number = value;
			}
		}

		public string GivenString {
			get {
				return givenString;
			}
			set {
				givenString = value;
			}
		}

		public int GivenNumber {
			get {
				return givenNumber;
			}
			set {
				givenNumber = value;
			}
		}

	}
}
