/*
 * Created by SharpDevelop.
 * User: TANIA
 * Date: 23/12/2021
 * Time: 19:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ListasComDuplaChave
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.DateTimePicker txtData;
		private System.Windows.Forms.ComboBox caixa;
		private System.Windows.Forms.Button exec;
		private System.Windows.Forms.TextBox txtObs;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label result;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtData = new System.Windows.Forms.DateTimePicker();
			this.txtObs = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.caixa = new System.Windows.Forms.ComboBox();
			this.exec = new System.Windows.Forms.Button();
			this.result = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(191, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Regista-se";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(37, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Identificação";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(37, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nome";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(37, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Data";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(37, 249);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Observação";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(114, 137);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(138, 20);
			this.txtID.TabIndex = 5;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(114, 173);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(138, 20);
			this.txtNome.TabIndex = 6;
			// 
			// txtData
			// 
			this.txtData.Location = new System.Drawing.Point(114, 211);
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(138, 20);
			this.txtData.TabIndex = 10;
			// 
			// txtObs
			// 
			this.txtObs.Location = new System.Drawing.Point(114, 249);
			this.txtObs.Multiline = true;
			this.txtObs.Name = "txtObs";
			this.txtObs.Size = new System.Drawing.Size(138, 55);
			this.txtObs.TabIndex = 14;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// caixa
			// 
			this.caixa.DisplayMember = "Inserir";
			this.caixa.FormattingEnabled = true;
			this.caixa.Items.AddRange(new object[] {
			"Inserir",
			"Contar",
			"Pesquisar por ID",
			"Pesquisar por Nome",
			"Listar por ID",
			"Listar por Nome",
			"Remover",
			"Gravar no disco",
			"Ler do disco"});
			this.caixa.Location = new System.Drawing.Point(37, 82);
			this.caixa.Name = "caixa";
			this.caixa.Size = new System.Drawing.Size(121, 21);
			this.caixa.TabIndex = 11;
			this.caixa.ValueMember = "Inserir";
			// 
			// exec
			// 
			this.exec.BackColor = System.Drawing.SystemColors.HotTrack;
			this.exec.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.exec.Location = new System.Drawing.Point(181, 75);
			this.exec.Name = "exec";
			this.exec.Size = new System.Drawing.Size(83, 32);
			this.exec.TabIndex = 12;
			this.exec.Text = "Execute";
			this.exec.UseVisualStyleBackColor = false;
			this.exec.Click += new System.EventHandler(this.ExecClick);
			// 
			// result
			// 
			this.result.Location = new System.Drawing.Point(294, 75);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(291, 250);
			this.result.TabIndex = 15;
			this.result.Text = "Lista Vazia...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(597, 334);
			this.Controls.Add(this.result);
			this.Controls.Add(this.txtObs);
			this.Controls.Add(this.exec);
			this.Controls.Add(this.caixa);
			this.Controls.Add(this.txtData);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "ListasComDuplaChave";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
