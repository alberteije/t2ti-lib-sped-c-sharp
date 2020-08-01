using System;
using T2TiERPFenix.Services;

namespace T2TiLibSpedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			// gera sped fiscal
			SpedFiscalService spedFiscal = new SpedFiscalService();
			String filterEFD = "2020-01-01|2020-12-12|0|0|0|1|0|1"; // filtro recebido da aplicação cliente
			Console.WriteLine(spedFiscal.GerarSpedFiscal(filterEFD));

			// gera sped contabil
			SpedContabilService spedContabil = new SpedContabilService();
			String filterECD = "2020-01-01|2020-12-12|0|0"; // filtro recebido da aplicação cliente
			Console.WriteLine(spedContabil.GerarSpedContabil(filterECD));
		}
	}
}
