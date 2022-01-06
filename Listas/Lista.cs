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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Listas
{
	[Serializable]
	public class Lista<T> where T : IComparable<T>, IComparer<T>
	{
		Nodo<T> fristID;
		Nodo<T> fristName;
		int count;
		public Lista()
		{
			fristID = null;
			fristName = null;
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
		public Nodo<T> AddFrist(T info, Nodo<T> frist)
		{
			Nodo<T> novo = new Nodo<T>(info);
			Nodo<T> aux = frist;
			novo.Next = aux;
			novo.Prev = null;
			frist = novo;
			return frist;
		}
		public void AddOrden(T info)
		{
			if(fristID.info.CompareTo(info) == 0 || fristName.info.Compare(fristName.info, info)==0)
			{
				return;
			}
			Nodo<T> auxID = this.fristID;
			Nodo<T> auxName = this.fristName;
			while(auxID.Next != null && auxID.Next.info.CompareTo(info) < 0)
			{
				auxID = auxID.Next;
			}
			
			while(auxName.Next != null && auxName.Next.info.Compare(auxName.Next.info, info) < 0)
			{
				auxName = auxName.Next;
			}
			if(auxID.Next != null)
				if(auxID.Next.info.CompareTo(info)==0)
				{
					return;
				}
			if(auxName.Next != null)
				if(auxName.Next.info.CompareTo(info)==0)
				{
					return;
				}
			Nodo<T> novoID = new Nodo<T>(info);
			Nodo<T> novoName = new Nodo<T>(info);
			if(auxID.info.CompareTo(info) > 0)
			{
				fristID = AddFrist(info, fristID);
			}else{
				
				novoID.Next =auxID.Next;
				novoID.Prev = auxID;
				auxID.Next = novoID;
				if(novoID.Next != null)
				{
					(novoID.Next).Prev = novoID;
				}
			}
			if(fristName.info.Compare(fristName.info, info) > 0)
			{
				fristName = AddFrist(info, fristName);
			}else{
				novoName.Next =auxName.Next;
				novoName.Prev = auxName;
				auxName.Next = novoName;
				if(novoName.Next != null)
				{
					(novoName.Next).Prev = novoName;
				}
			}
			
			this.count++;
		}
		public void Add(T info)
		{
			if(EmptyList)
			{
				fristID = AddFrist(info, fristID);
				fristName = AddFrist(info, fristName);
				this.count++;
				return;
			}
			AddOrden(info);
		}
		
		public void FindID(T info, out string saida)
		{
			saida = "<NÃO REGISTADO>";
			if(EmptyList)
			{
				return;
			}
			Nodo<T> aux = this.fristID;
			while(aux != null && aux.info.CompareTo(info)<0)
			{
				aux = aux.Next;
			}
			if(aux != null && aux.info.CompareTo(info)==0)
			{
				saida = aux.info.ToString();
			}
			
		}
		public void FindName(T info, out string saida)
		{
			saida = "<NÃO REGISTADO>";
			if(EmptyList)
			{
				return;
			}
			Nodo<T> aux = this.fristName;
			while(aux != null && aux.Next.info.Compare(aux.Next.info, info)<0)
			{
				aux = aux.Next;
			}
			if(aux != null && aux.Next.info.Compare(aux.Next.info, info)==0)
			{
				saida = aux.info.ToString();
			}
		}
		public Nodo<T> RemoveFrist(Nodo<T> frist)
		{
			frist = frist.Next;
			if(frist !=  null)
			{
				frist.Prev = null;
			}
			return frist;
		}
		public void RemoveOrdem(T info, out string saida)
		{
			saida = "<NÃO REGISTADO>";
			Nodo<T> auxID = this.fristID;
			Nodo<T> auxName = this.fristName;
			while(auxID != null && auxID.info.CompareTo(info) < 0)
			{
				auxID = auxID.Next;
			}
			while(auxName != null && auxName.info.Compare(auxName.info, info) < 0)
			{
				auxName = auxName.Next;
			}
			if(auxID == null || auxName == null)
			{
				return;
			}
			if(auxID.info.Equals(auxName.info))
			{
				if(info.CompareTo(this.fristID.info)==0)
				{
					saida = this.fristID.info.ToString();
					fristID = RemoveFrist(fristID);
				}else{
					saida = auxID.info.ToString();
					auxID.Prev.Next =auxID.Next;
					if(auxID.Next != null)
					{
						auxID.Next.Prev = auxID.Prev;
					}
				}
				if(info.Compare(info, this.fristName.info)==0)
				{
					saida += fristName.info.ToString();
					fristName = RemoveFrist(fristName);
				}else{
					saida += auxName.info.ToString();
					auxName.Prev.Next =auxName.Next;
					if(auxName.Next != null)
					{
						auxName.Next.Prev = auxName.Prev;
					}
				}
			}
		}
		public void Remove(T info, out string saida)
		{
			saida = "<LISTA VAZIA>";
			if(EmptyList)
			{
				return;
			}
			RemoveOrdem(info, out saida);
		}
		public void ShowID()
		{
			Nodo<T> aux = this.fristID;
			while(aux != null)
			{
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine(aux.info.ToString());
				Console.ResetColor();
				Console.WriteLine("------------------------------");
				aux = aux.Next;
			}
		}
		public void ShowNome()
		{
			Nodo<T> aux = this.fristName;
			while(aux != null)
			{
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine(aux.info.ToString());
				Console.ResetColor();
				Console.WriteLine("------------------------------");
				aux = aux.Next;
			}
		}
		
		public static void RecordInfo(Lista<T> lista, string name)
		{
			BinaryFormatter format = new BinaryFormatter();
			FileStream file = new FileStream(name, FileMode.Create);
			format.Serialize(file, lista);
			file.Close();
	    }
		public static Lista<T> ReadInfo(string name)
		{
			Lista<T> lista = new Lista<T>();
			BinaryFormatter format = new BinaryFormatter();
			FileStream file = new FileStream(name, FileMode.Open);
			lista = (Lista<T>)format.Deserialize(file);
			file.Close();
			return lista;
		}
		
	}
}
