using System;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			

		
			

			Console.WriteLine("==== Bem vindo ao brk ==== \n 1 - Escolher seu combo \n 2 - Sair");
			string opcao = Console.ReadLine();

			if (opcao == "1")
			{
				Console.Clear();
				bool sair = true;
				string lancheSelecionado = "";
				string bebidaSelecionado = "";
				string batataSelecionado = "";
				string doceSelecionado = "";
				int precoLanche = 0;
				int precoBebida = 0;
				int precoBatata = 0;
				int precoDoce = 0;
				do
				{
					
					Console.WriteLine("Qual lanche você irá escolher? ");
					Console.WriteLine(" 1 - X salada R$15,00 \n 2 - X tudo R$25,00 \n 3 - X Egg R$17,00 \n 4 - Sair");
					
					int lanche = Convert.ToInt32(Console.ReadLine());

					switch (lanche)
					{
						case 1 : lancheSelecionado = "X-Salada";
							precoLanche = 15;
							sair = false;
							break;
						case 2: lancheSelecionado = "X-Tudo";
							precoLanche = 25;
							sair = false;
							break;
						case 3: lancheSelecionado = "X-Egg";
							precoLanche = 17;
							sair = false;
							break;
						default: sair = false;
							break;
					}


					Console.Clear();
				} while (sair);

				do
				{
					
					Console.WriteLine("Qual bebida você irá escolher?");
					Console.WriteLine(" 1 - Coca Cola R$5,00 \n 2 - Guarana R$3,00 \n 3 - Chá gelado R$4,00 \n 4 - Sair");

					int bebida = Convert.ToInt32(Console.ReadLine());
					switch (bebida)
					{
						case 1:
							bebidaSelecionado = "Coca Cola";
							precoBebida = 5;
							sair = false;
							break;
						case 2:
							bebidaSelecionado = "Guarana";
							precoBebida = 3;
							break;
						case 3:
							bebidaSelecionado = "Chá gelado";
							precoBebida = 4;
							break;
						default:
							sair = false;
							break;
					}


					Console.Clear();
				} while (sair);
				do
				{
					
					Console.WriteLine("Qual Batata você irá escolher?");
					Console.WriteLine(" 1 - Pequena R$7,00 \n 2 - Media R$10,00 \n 3 - Grande R$12,00 \n 4 - Sair");

					int batata = Convert.ToInt32(Console.ReadLine());
					switch (batata)
					{
						case 1:
							batataSelecionado = "Pequena";
							precoBatata = 7;
							sair = false;
							break;
						case 2:
							batataSelecionado = "Media";
							precoBatata = 10;
							break;
						case 3:
							batataSelecionado = "Grande";
							precoBatata = 12;
							break;
						default:
							sair = false;
							break;
					}


					Console.Clear();
				} while (sair);
				do
				{
					
					Console.WriteLine("Qual Batata você irá escolher?");
					Console.WriteLine(" 1 - Brigadeiro R$5,00 \n 2 - Beijinho R$5,00 \n 3 - Maçã R$3,00 \n 4 - Sair");

					int doce = Convert.ToInt32(Console.ReadLine());
					switch (doce)
					{
						case 1:
							doceSelecionado = "Brigadeiro";
							precoDoce = 5;
							sair = false;
							break;
						case 2:
							doceSelecionado = "Beijinho";
							precoDoce = 5;
							break;
						case 3:
							doceSelecionado = "Maçã";
							precoDoce = 3;
							break;
						default:
							sair = false;
							break;
					}


					Console.Clear();
				} while (sair);

				Console.WriteLine("======= COMANDA =======");
				Console.WriteLine("Lanche: {0}   -- Preço: {1}", lancheSelecionado , precoLanche);
				Console.WriteLine("-------------------------------");
				Console.WriteLine("Bebida: {0}   -- Preço: {1}", bebidaSelecionado, precoBebida);
				Console.WriteLine("-------------------------------");
				Console.WriteLine("Batata: {0}   -- Preço: {1}", batataSelecionado, precoBatata);
				Console.WriteLine("-------------------------------");
				Console.WriteLine("Doce: {0}     -- Preço: {1}", doceSelecionado, precoDoce);
				Console.WriteLine("------------ TOTAL ------------");
				Console.WriteLine("O valora total a pagar é de {0}", precoLanche + precoDoce + precoBebida + precoBatata +"Reais");


			}
			else
			{
				Console.WriteLine("Até a proxima !!");
			}
			



			


			}
	}
}
