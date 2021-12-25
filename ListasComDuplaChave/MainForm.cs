/*
 * Created by SharpDevelop.
 * User: TANIA
 * Date: 23/12/2021
 * Time: 19:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using lista;


namespace ListasComDuplaChave
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		ListaComDuplaChave<Info> lista = new ListaComDuplaChave<Info>();
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Inserir(object sender, EventArgs e)
		{
		}
		void ExecClick(object sender, EventArgs e)
		{
			if(this.caixa.Text == "Inserir")
			{
				Inserir();
			}
			if(this.caixa.Text == "Contar")
			{
				this.result.Text = "Total de "+lista.Count+" registo(s)";
			}
			if(this.caixa.Text == "Remover")
			{
				this.txtNome.Text = "Remover";
			}
			if(this.caixa.Text == "Pesquisar por ID")
			{
				this.PesquisarID();
			}
			if(this.caixa.Text == "Pesquisar por Nome")
			{
				this.txtNome.Text = "Pesquisar por Nome";
			}
			if(this.caixa.Text == "Listar por ID")
			{
				this.ListaPorID();
				this.txtNome.Text = "Listar por ID";
			}
			if(this.caixa.Text == "Listar por Nome")
			{
				this.txtNome.Text = "Listar por Nome";
			}
			if(this.caixa.Text == "Remover")
			{
				this.Remove();
			}
		}
		void ListaPorID()
		{
			if(!lista.EmptyList)
				this.result.Text = lista.ListarId();
		}
		void Inserir()
		{
			
			int id = 0;
			string nome, obs;
			DateTime data;
			if(this.txtID.Text == "" || this.txtNome.Text == "" || this.txtData.Text == "")
			{
				MessageBox.Show("Preencha todos os campos","ATENÇÃO...", MessageBoxButtons.OK);
			  	return;
			}
			int.TryParse(this.txtID.Text, out id);
			//string.TryParse(this.txtID.Text, out nome);
			nome = "redney";
			DateTime.TryParse(this.txtID.Text, out data);
			//string.TryParse(this.txtID.Text, out obs);
			obs = "ALguma coisa";
			Info dado = new Info(id, nome, data, obs);
			string saida;
			if(lista.Find(dado, out saida))
			{
				MessageBox.Show("Aluno já inserido", "ERRO...", MessageBoxButtons.OK);
				return;
			}
			lista.Add(dado);
			MessageBox.Show("Aluno inserido com sucesso", "Sucesso...", MessageBoxButtons.OK);
			this.txtID.Clear();
			this.txtNome.Clear();
			this.txtObs.Clear();
		}
		void Remove()
		{
			int id = 0;
			DateTime data = new DateTime();
			if(this.txtID.Text == "")
			{
				MessageBox.Show("Preencha o campo IDENTIFICAÇÃO","ATENÇÃO...", MessageBoxButtons.OK);
				this.txtID.Focus();
				return;
			}
			Info dado = new Info(id, "", data, "");
			if(lista.Remove(dado))
			{
				MessageBox.Show("Removido com sucesso","SUESSO", MessageBoxButtons.OK);
				return;
			}
			MessageBox.Show("Aluno não existe","ERRO...", MessageBoxButtons.OK);
		}
		void PesquisarID()
		{
			int id = 0;
			DateTime data = new DateTime();
			if(this.txtID.Text == "")
			{
				MessageBox.Show("Preencha o campo IDENTIFICAÇÃO","ATENÇÃO...", MessageBoxButtons.OK);
				this.txtID.Focus();
				return;
			}
			Info dado = new Info(id, "", data, "");
			string saida;
			bool res = lista.Find(dado, out saida);
			if(res)
			{
				this.result.Text = saida;
				return;
			}
			MessageBox.Show("Aluno não existe","ERRO...", MessageBoxButtons.OK);
		}
	}
}
