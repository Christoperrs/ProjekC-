using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_21222_P2_1_15
{
	class KendaraanTest_0320210015
	{
		static void Main(string[] args)
		{
			//instansiasi object myKendaraan dari class Kendaraan_0320210015
			Motor_03200210015 kendaraan1 = new Motor_03200210015("Motor", "Honda", "1000");
			//menuliskan state dari Kendaraan ke layar
			Console.WriteLine("Produk Kendaraan 1 adalah type {0} dengan merk {1} berjumlah {2} unit",
				kendaraan1.MyType, kendaraan1.MyMerk, kendaraan1.Quantity);

			//instansiasi class Mobil
			Mobil_0320210015 kendaraan2 = new Mobil_0320210015("Toyota", "Silver");
			Console.WriteLine("Produk Kendaraan 2 adalah type {0} dengan merk {1} bewarna {2}",
				kendaraan2.MyType, kendaraan2.MyMerk, kendaraan2.Color);
		}
	}
}
