/*
 * Created by SharpDevelop.
 * User: Redney Monteiro
 * Date: 24/12/2021
 * Time: 13:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Listas
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public class Menu
	{
		string titulo;
		string[] opcoes;
		int select;
		public  Menu(string titulo, string[] opcoes)
		{
			this.titulo = titulo;
			this.opcoes = opcoes;
			this.select = 0;
			
		}
		public  Menu()
		{}
		public void Show()
		{
			Linha();
			Center(titulo.ToUpper(), 30);
			Linha();
			for(int i = 0; i < opcoes.Length; i++)
			{
				if(select == i)
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.Green;
					Console.WriteLine(" - {0}  ", opcoes[i].ToUpper());
				} 
				else
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.Black;
					Console.WriteLine(" - {0}  ", opcoes[i]);
				}
				
				Console.ResetColor();
			}
		}
		public int ShowMenu()
		{
			ConsoleKeyInfo key;
			do
			{
				Console.Clear();
				Show();
				key = Console.ReadKey();
				if(key.Key == ConsoleKey.UpArrow )
				{
					this.select--;
				}
				if(key.Key == ConsoleKey.DownArrow)
				{
					this.select++;
				}
				if(select<0)
				{
					select = opcoes.Length-1;
				}
				if(select>opcoes.Length-1)
				{
					select = 0;
				}
			} while(key.Key != ConsoleKey.Enter);
			return select;
		}
		public void Linha(){
            Console.WriteLine("------------------------------");
        }
        public void Center(string titulo, int num){
            int total, direita;
            total = num - titulo.Length;
            direita = (total / 2) + titulo.Length;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", titulo.PadLeft(direita, ' '));
            Console.ResetColor();
        }
	}
}
