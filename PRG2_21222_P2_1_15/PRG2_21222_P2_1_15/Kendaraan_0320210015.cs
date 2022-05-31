using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_21222_P2_1_15
{
	class Kendaraan_0320210015
	{
		//deklarasi data
		private string myType;
		private string myMerk;

		//deklarasi method, constructor
		public Kendaraan_0320210015()
		{

		}		
	
		//method overloading
		public Kendaraan_0320210015(string type, string merk)
		{
			this.myType = type;
			this.myMerk = merk;
		}

		//properti dari variabel myType
		public string MyType
		{
			get
			{
				return myType;
			}
			set
			{
				myType = value;
			}
		}

		public string MyMerk
		{
			get
			{
				return myMerk;
			}
			set
			{
				myMerk = value;
			}
		}
	}
}

