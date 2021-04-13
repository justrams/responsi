using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;


namespace ResponsiPemrograman3375
{
	public class Responsi
	{
		public string Nama { get; set; }
		public string Gaji { get; set; }
		
		public void Data()
		{
			Console.Writeline("Silahkan mengisi Nama dan Gaji :)");
			Console.Writeline("Nama: {0}", Nama);
			Console.Writeline("Gaji: {0}", Gaji);
			Console.Writeline("------------------");
		}
		
		public void KenaikanGaji
		{
			Console.Writeline("Gaji tambah 10%");
		}
	
	}
}