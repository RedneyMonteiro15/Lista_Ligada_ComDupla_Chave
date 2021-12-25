/*
 * Created by SharpDevelop.
 * User: TANIA
 * Date: 23/12/2021
 * Time: 20:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace lista
{
	/// <summary>
	/// Description of ListaComDuplaChave.
	/// </summary>
	public class ListaComDuplaChave<T> where T : IComparable<T>
	{
		
		Nodo<T> frist;
		int count;
		public ListaComDuplaChave()
		{
			frist = null;
			count = 0;
		}
		
		public int Count
		{
			get
			{
				return count;
			}
		}
		
		public bool EmptyList
		{
			get
			{
				if(this.Count == 0)
				{
					return true;
				}
				return false;
			}
		}
		
		public void AddFrist(T info)
		{
			Nodo<T> novo = new Nodo<T>(info);
			Nodo<T> aux = this.frist;
			novo.Next = aux;
			novo.Prev = null;
			this.frist = novo;
			this.count++;
		}
		
		public void Add(T info)
		{
			if(EmptyList || info.CompareTo(this.frist.info)<0)
			{
				AddFrist(info);
				return;
			}
			Nodo<T> aux = this.frist;
			Nodo<T> novo = new Nodo<T>(info);
			while(aux.Next != null && aux.Next.info.CompareTo(info)<0)
			{
				aux = aux.Next;
			}
			novo.Next =aux.Next;
			novo.Prev = aux;
			aux.Next = novo;
			if(aux.Next != null)
			{
				(aux.Next).Prev = novo;
				
			}
			this.count++;
		}
		
		public bool Find(T info, out string saida)
		{
			saida = "";
			if(EmptyList)
			{
				return false;
			}
			Nodo<T> aux = this.frist;
			while(aux != null && aux.info.CompareTo(info)<0)
			{
				aux = aux.Next;
			}
			if(aux != null)
			{
				saida = aux.info.ToString();
				return true;
			}
			return false;
		}
		
		public void RemoveFrist()
		{
			this.frist = this.frist.Next;
			this.frist.Prev = null;
			this.count--;
		}
		public bool Remove(T info)
		{
			if(EmptyList)
			{
				return false;
			}
			if(info.CompareTo(this.frist.info)==0)
			{
				RemoveFrist();
				return true;
			}
			Nodo<T> aux = this.frist;
			while(aux.Next != null && info.CompareTo(aux.Next.info)!=0)
			{
				aux = aux.Next;
			}
			if(aux == null)
			{
				return false;
			}
			aux.Next = aux.Next.Next;
			if(aux.Next != null)
			{
				aux.Next.Prev = aux;
			}
			this.count--;
			return true;
		}
		public string ListarId()
		{
			return RetornarID(this.frist);
		}
		
		public string RetornarID(Nodo<T> aux)
		{
			
			if(aux == null)
			{
				return "";
			}
			return aux.info.ToString() + "\n" + RetornarID(aux.Next);
		}
			
	}
}
