/*
 * Created by SharpDevelop.
 * User: TANIA
 * Date: 23/12/2021
 * Time: 20:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace lista
{
	/// <summary>
	/// Description of Nodo.
	/// </summary>
	public class Nodo<Info>
	{
		public Info info;
		public Nodo<Info> Next;
		public Nodo<Info> Prev;
		
		public Nodo(Info info)
		{
			this.info = info;
			this.Next = null;
			this.Prev = null;
		}
	}
}
