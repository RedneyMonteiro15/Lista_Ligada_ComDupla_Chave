/*
 * Created by SharpDevelop.
 * User: Redney Monteiro
 * Date: 24/12/2021
 * Time: 17:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Listas
{
	/// <summary>
	/// Description of Info.
	/// </summary>
	[Serializable]
	public struct Info :  IComparer<Info>, IComparable<Info>
	{
		int numero;
		string nome, obs;
		DateTime data;
		public Info(int numero, string nome, DateTime data, string obs)
		{
			this.numero = numero;
			this.nome = nome;
			this.data = data;
			this.obs = obs;
		}
		public Info(int numero)
		{
			this.numero = numero;
			this.nome = null;
			this.data = new DateTime();
			this.obs = null;
		}
		public Info(string nome)
		{
			this.numero = -1;
			this.nome = nome;
			this.data = new DateTime();
			this.obs = null;
		}
		public Info(int numero, string nome)
		{
			this.numero = numero;
			this.nome = nome;
			this.data = new DateTime();
			this.obs = null;
		}
		
		public override string ToString()
		{
			return "   Identificação: "+this.numero+"\n   Nome: "+this.nome+"\n   Data: "+this.data+"\n   Observação: "+this.obs;
		}
		public int CompareTo(Info info)
		{
			return this.numero-info.numero;
		}
		public int Compare(Info info1, Info info2)
	    {
			return info1.nome.CompareTo(info2.nome);
	    }
		public bool Equals(Info info)
		{
			if(this.nome == info.nome && this.numero==info.numero)
			{
				return true;
			}
			return false;
		}
	}
}
