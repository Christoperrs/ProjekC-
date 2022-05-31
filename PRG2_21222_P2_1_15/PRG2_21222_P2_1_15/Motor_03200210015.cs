using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_21222_P2_1_15
{
	class Motor_03200210015 : Kendaraan_0320210015
	{
		//deklarasi variabel dengan access modifier protected
		protected string quantity;

		// berikut ini merupakan construktor untuk class Motor
		// constructor ini meng-override construktor dari class induknya


		//cara memanggil constructor dari class induk, dengan keyword base
		public Motor_03200210015(string type, string merek, string quantity)
			: base(type, merek)
		{
			this.quantity = quantity;
		}

		//property dari variabel quantity
		public string Quantity
		{
			get
			{
				return quantity;
			}
			set
			{
				quantity = value;
			}
		}
	}
}
