/*
 * Created by SharpDevelop.
 * User: TANIA
 * Date: 23/12/2021
 * Time: 20:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace lista
{
	/// <summary>
	/// Description of Info.
	/// </summary>
	public struct Info : IComparable<Info>
	{
		public int numero;
		public string nome, obs;
		public DateTime data;
		public Info(int numero, string nome, DateTime data, string obs)
		{
			this.numero = numero;
			this.nome = nome;
			this.data = data;
			this.obs = obs;
		}
		public override string ToString()
		{
			return "Identificação: "+this.numero+"\nNome: "+this.nome+"\nData: "+this.data+"\nObservação: "+this.obs;
		}
		public int CompareTo(Info info)
		{
			return this.numero-info.numero;
		}
	}
}

