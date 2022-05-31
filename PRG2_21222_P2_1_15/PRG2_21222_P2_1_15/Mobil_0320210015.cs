using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_21222_P2_1_15
{
	class Mobil_0320210015 : Kendaraan_0320210015
	{
		protected string color;

		public Mobil_0320210015(string merk, string color)
		{
			this.MyMerk = merk;
			this.Color = color;
			this.MyType = "Mobil";
			//tipe untuk class ini akan selalu mobil
			//sehingga tidak perlu parameter masukan atau type
			//demikian pula sebenaranya dengan class Motor

			Console.WriteLine("Ini dari class Mobil");
		}

		public string Color
		{
			get
			{
				return color;
			}
			set
			{
				color = value;
			}
		}

	}
}
