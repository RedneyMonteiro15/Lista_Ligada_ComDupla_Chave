/*
 * Created by SharpDevelop.
 * User: Redney Monteiro
 * Date: 24/12/2021
 * Time: 17:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;

namespace Listas
{
	class Program
	{
		public static void Main(string[] args)
		{
			string titulo = "REGISTAR";
			
			string[] opcoes = {"Inserir", "Contar", "Pesquisar por Numero", "Pesquisar por Nome", 
								"Listar por Número", "Listar por Nome", "Remover",
								"Gravar em Disco", "Ler do disco", "Sair"};
			string nome, obs, saida;
			DateTime data = new DateTime();
			
			int numero, mes, dia, ano;
			Lista<Info> lista = new Lista<Info>();
			Info info1 = new Info(1, "REDNEY", data, "A dkcw");
			Info info2 = new Info(2, "TATIANA", data, "A dkcw");
			Info info3 = new Info(3, "ALANAH", data, "A dkcw");
			Info info4 = new Info(4, "RYAN", data, "A dkcw");
			Info info5 = new Info(5, "VALENTINA", data, "A dkcw");
			Info info6 = new Info(6, "DANIA", data, "A dkcw");
			Info info7 = new Info(7, "MANUEL", data, "A dkcw");
			Info info8 = new Info(8, "TANIA", data, "A dkcw");
			Info info9 = new Info(9, "VANISIA", data, "A dkcw");
			Info info10 = new Info(10, "KIKI", data, "A dkcw");
			lista.Add(info1);
			lista.Add(info2);
			lista.Add(info3);
			lista.Add(info4);
			lista.Add(info5);
			lista.Add(info6);
			lista.Add(info7);
			lista.Add(info8);
			lista.Add(info9);
			lista.Add(info10);
			
			Info info;
			while(true)
			{
				Menu menu = new Menu(titulo, opcoes);
				int op = menu.ShowMenu();
				if(op==9)
				{
					menu.Linha();
					menu.Center("FIM PROGRAMA", 30);
					menu.Linha();
					break;
				}
				Console.Clear();
				switch(op)
				{
					case 0:
						menu.Linha();
						menu.Center("Listagem por Número", 30);
						menu.Linha();
						Console.Write(" Número: ");
						numero = Convert.ToInt32(Console.ReadLine());
						Console.Write(" Nome: ");
						nome = Console.ReadLine().ToUpper();
						Console.WriteLine(" Data (dd/MM/YYYY)");
						Console.Write("  Dia: ");
						dia = Convert.ToInt32(Console.ReadLine());
						Console.Write("  Mes: ");
						mes = Convert.ToInt32(Console.ReadLine());
						Console.Write("  Ano: ");
						ano = Convert.ToInt32(Console.ReadLine());
						data = new DateTime(ano, mes, dia);
						Console.Write("Observação: ");
						obs = Console.ReadLine();
						info = new Info(numero, nome, data, obs);
						lista.Add(info);
						break;
					case 1:
						menu.Linha();
						menu.Center("Contagem", 30);
						menu.Linha();
						Console.Write("Total de Elementos é ");
						Console.BackgroundColor = ConsoleColor.Green;
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine("{0}", lista.Count);
						Console.ResetColor();
						Console.ReadKey();
						break;
					case 2:
						menu.Linha();
						menu.Center("Pesquisar por Número", 30);
						menu.Linha();
						Console.Write("Número: ");
						numero = Convert.ToInt32(Console.ReadLine());
						info = new Info(numero);
						lista.FindID(info, out saida);
						menu.Linha();
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.WriteLine(saida);
						Console.ResetColor();
						Console.ReadKey();
						break;
					case 3:
						menu.Linha();
						menu.Center("Pesquisar por Nome", 30);
						menu.Linha();
						Console.Write("Nome: ");
						nome = Console.ReadLine().ToUpper();
						Info d = new Info(nome);
						lista.FindName(d, out saida);
						menu.Linha();
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.WriteLine(saida);
						Console.ResetColor();
						Console.ReadKey();
						break;
					case 4:
						menu.Linha();
						menu.Center("Listagem por Número", 30);
						menu.Linha();
						lista.ShowID();
						Console.ReadKey();
						break;
					case 5:
						menu.Linha();
						menu.Center("Listagem por Nome", 30);
						menu.Linha();
						lista.ShowNome();
						Console.ReadKey();
						break;
					case 6:
						menu.Linha();
						menu.Center("Remover Elemento", 30);
						menu.Linha();
						Console.Write("Número: ");
						numero = Convert.ToInt32(Console.ReadLine());
						Console.Write("Nome: ");
						nome = (Console.ReadLine()).ToUpper();
						info = new Info(numero, nome);
						lista.Remove(info, out saida);
						menu.Linha();
						Console.ForegroundColor = ConsoleColor.DarkGray;
						Console.WriteLine(saida);
						Console.ResetColor();
						Console.ReadKey();
						break;
					case 7:
						menu.Linha();
						menu.Center("Gravar os Dados", 30);
						menu.Linha();
						Console.Write("Nome do ficheiro: ");
						nome = Console.ReadLine();
						Lista<Info>.RecordInfo(lista, nome);
						break;
					case 8:
						menu.Linha();
						menu.Center("Ler os Dados", 30);
						menu.Linha();
						Console.Write("Nome do ficheiro: ");
						nome = Console.ReadLine();
						try
						{
							lista = Lista<Info>.ReadInfo(nome);
							Console.ForegroundColor = ConsoleColor.Green;
	 	                 	Console.WriteLine("Ficheiro '{0}' lido com sucesso! ", nome);
	 	                 	Console.ResetColor();
						}
						catch(Exception e)
						{
							Console.ForegroundColor = ConsoleColor.Red;
		 	           		Console.WriteLine("ERRO!!! {0}", e.Message);
		 	           		Console.WriteLine("Ficheiro '{0}' não encontrado!!!", nome);
		 	           		Console.ResetColor();
						}
						Console.ReadKey();
						break;
				}
			}
			Console.ReadKey();
		}		
	}
	
}