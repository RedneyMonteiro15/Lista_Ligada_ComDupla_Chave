/*
 * Created by SharpDevelop.
 * User: Redney Monteiro
 * Date: 24/12/2021
 * Time: 17:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Listas
{
	/// <summary>
	/// Description of Nodo.
	/// </summary>
	[Serializable]
	public class Nodo<T>
	{
		public T info;
		public Nodo<T> Next{get; set;}
		public Nodo<T> Prev{get; set;}
		
		public Nodo(T info)
		{
			this.info = info;
			this.Next = null;
			this.Prev = null;
		}
	}
}
