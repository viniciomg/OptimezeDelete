/*
 * Created by SharpDevelop.
 * User: vinicio.magalhaes
 * Date: 01/02/2021
 * Time: 11:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using OptimizeDelete;
using OptimizeDelete.AcessoDados;
using OptimizeDelete.UtilsObjects;

namespace OptimizeDelete.Frm
{

	public partial class FrmPrincipal : Form

	{

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		public string retorno;
		public string resultado;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		static List<TabelasSelecionadas> tabelasSelecionadas;
		static List<FilialSelecionadas> filialSelecionadas;
		static DataTable dtfilial = new DataTable();
		





		public FrmPrincipal()
		{

			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			 
			dtpinicio.Value = DateTime.Now;

			dtpfinal.Value = DateTime.Now;

			CarregarGridTabelas();

		}

		public void CarregarGridTabelas()
		{

			AcessoDadosMysql acessodados = new AcessoDadosMysql();
			string query = "SHOW tables";
			dtfilial = acessodados.ExecutarConsulta(CommandType.Text, query);

			DataGridViewTextBoxColumn txtc1 = new DataGridViewTextBoxColumn();
			txtc1.Name = "Tabelas";
			txtc1.HeaderText = "Tabelas";
			var banco = BancoDados.Instancia;
			string nome = "Tables_in_" + banco.Banco;
			txtc1.DataPropertyName = nome;
			txtc1.Width = 180;

			DataGridViewTextBoxColumn txtc2 = new DataGridViewTextBoxColumn();
			txtc2.Name = "Marcado";
			txtc2.HeaderText = "Marcado";
			txtc2.Resizable = DataGridViewTriState.False;
			txtc2.Visible = true;
			txtc2.ReadOnly = false;
			// txtc2.Resizable=false;
			txtc2.MinimumWidth = 2;
			txtc2.Width = 2;


			dataGridView1.AutoGenerateColumns = false;
			// Adicionamos as colunas ao DGV.
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtc1, txtc2 });

			dataGridView1.DataSource = dtfilial;

			//return dt;
		}
		public DataTable selectFiliais()
		{
			AcessoDadosMysql acessoDados = new AcessoDadosMysql();
			var tab = Tabelas.Instancia;
			string query = "Select filial_id,  nome from filial where apagado ='N' and filial_id > 1 and escritorio <>'S'and filial_id <> " + tab.id_filial + " order by filial_id asc";


			DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, query);

			if(dataTable.Rows.Count == 0)
            {
				MessageBox.Show("Loja única não será possível executar a função Deletes" ,"Atenção",MessageBoxButtons.OK, MessageBoxIcon.Information);
				Delete.Enabled = false;
            }
			return dataTable;
		}

		public DataTable selectDataInicio()
		{
			AcessoDadosMysql AcessoDados = new AcessoDadosMysql();
			var tab = Tabelas.Instancia;
			string query = "Select data_hora from movment where apagado='N' and filial_id=" + tab.id_filial + " order by data_hora asc limit 1";

			DataTable dataTable = AcessoDados.ExecutarConsulta(CommandType.Text, query);
			string res = string.Join(Environment.NewLine,
			dataTable.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
			tab.DataInicioBanco = res;
			return dataTable;
		}
		void Panel3MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}

		}

		void BtnFecharClick(object sender, EventArgs e)
		{
			Close();
		}

		void BtnMinimizarClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		void DataGridView1KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.F5)
			{

				if (this.dataGridView1.CurrentRow.Cells[0].Value == null || this.dataGridView1.CurrentRow.Cells[0].Value == "N")
				{

					dataGridView1.CurrentRow.Cells[0].Value = "S";
					dataGridView1.UpdateCellValue(0, dataGridView1.CurrentRow.Index);


					listaTabelas();

				}
				else
				{
					dataGridView1.CurrentRow.Cells[0].Value = "N";
					dataGridView1.UpdateCellValue(0, dataGridView1.CurrentRow.Index);
					tabelasSelecionadas.RemoveAt(0);

				}
			}


			if (e.KeyCode == Keys.F6)
			{
				tabelasSelecionadas.Clear();
				for (int i = 0; i < dataGridView1.Rows.Count; i++)
				{
					dataGridView1.Rows[i].Cells[0].Value = "S";
					dataGridView1.UpdateCellValue(0, i);

					if (i == dataGridView1.Rows.Count)
						tabelasSelecionadas.RemoveAt(i);

					var tabela = dataGridView1.Rows[i].Cells[1].Value.ToString();
					tabelasSelecionadas.Add(new TabelasSelecionadas(tabela));

				}
			}
			if (e.KeyCode == Keys.F7)
			{
				for (int i = 0; i < dataGridView1.Rows.Count; i++)
				{
					dataGridView1.Rows[i].Cells[0].Value = "N";
					dataGridView1.UpdateCellValue(0, i);
					tabelasSelecionadas.Clear();
				}
			}

		}
		void DtgvFilialKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{

				if (this.dtgvFilial.CurrentRow.Cells[0].Value == null || this.dtgvFilial.CurrentRow.Cells[0].Value == "N")
				{

					dtgvFilial.CurrentRow.Cells[0].Value = "S";
					dtgvFilial.UpdateCellValue(0, dtgvFilial.CurrentRow.Index);
					addFilial();

				}
				else
				{
					dtgvFilial.CurrentRow.Cells[0].Value = "N";
					dtgvFilial.UpdateCellValue(0, dtgvFilial.CurrentRow.Index);

				}
			}


			if (e.KeyCode == Keys.F6)
			{
				filialSelecionadas.Clear();
				for (int i = 0; i < dtgvFilial.Rows.Count; i++)
				{
					dtgvFilial.Rows[i].Cells[0].Value = "S";
					dtgvFilial.UpdateCellValue(0, i);

					if (i == dtgvFilial.Rows.Count)
						filialSelecionadas.RemoveAt(i);

					var tabela = dtgvFilial.Rows[i].Cells[1].Value.ToString();
					filialSelecionadas.Add(new FilialSelecionadas(tabela));

				}
			}
			if (e.KeyCode == Keys.F7)
			{
				for (int i = 0; i < dtgvFilial.Rows.Count; i++)
				{
					dtgvFilial.Rows[i].Cells[0].Value = "N";
					dtgvFilial.UpdateCellValue(0, i);
					filialSelecionadas.Clear();

				}
			}

		}

		void DataGridView1CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value != null && e.Value.Equals("S"))
			{
				dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkOrange; //nao selecionado
				dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White; //selecionado
			}
			if (e.Value != null && e.Value.Equals("N"))
			{
				dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black; //
				dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));

			}
		}

		public void listaTabelas()
		{

			var teste = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
			tabelasSelecionadas.Add(new TabelasSelecionadas(teste));

		}
		public void addFilial()
		{

			var teste = this.dtgvFilial.CurrentRow.Cells[1].Value.ToString();
			filialSelecionadas.Add(new FilialSelecionadas(teste));


		}

		public void addfilialString()
		{
			var tab = Tabelas.Instancia;
			foreach (var item in filialSelecionadas)
			{
				tab.filialMarcada = tab.filialMarcada + item.filial.ToString() + ",";
			}
		}



		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
			var banco = BancoDados.Instancia;
			string filterfild = "Tables_in_" + banco.Banco;
			dtfilial.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterfild, textBox1.Text);
			
		}

		void Label6MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}

		}

		void Label4MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		void FrmPrincipalLoad(object sender, EventArgs e)
		{
			tabelasSelecionadas = new List<TabelasSelecionadas>();
			filialSelecionadas = new List<FilialSelecionadas>();
			AcessoDadosMysql acessados = new AcessoDadosMysql();
			acessados.PegaFilial();
			var tab = Tabelas.Instancia;
			lbbanco.Text = "Banco de dados: " + tab.database;
			lblFilial.Text = "Executando na filial_id: " + tab.id_filial;
			selectDataInicio();
			lbldtiniciobanco.Text = "    Movimentação inicial: " + tab.DataInicioBanco;

			DataGridViewTextBoxColumn txtc1 = new DataGridViewTextBoxColumn();
			txtc1.Name = "marcado";
			txtc1.HeaderText = "marcado";
			txtc1.Resizable = DataGridViewTriState.False;
			txtc1.Visible = true;
			txtc1.ReadOnly = false;
			// txtc2.Resizable=false;
			txtc1.MinimumWidth = 2;
			txtc1.Width = 2;

			DataGridViewTextBoxColumn txtc2 = new DataGridViewTextBoxColumn();
			txtc2.Name = "filial_id";
			txtc2.HeaderText = "filial_id";
			txtc2.DataPropertyName = "filial_id";
			txtc2.Width = 40;
			DataGridViewTextBoxColumn txtc3 = new DataGridViewTextBoxColumn();
			txtc3.Name = "nome";
			txtc3.HeaderText = "nome";
			txtc3.DataPropertyName = "nome";
			txtc3.Width = 370;

			dtgvFilial.AutoGenerateColumns = false;
			// Adicionamos as colunas ao DGV.
			dtgvFilial.Columns.AddRange(new DataGridViewColumn[] { txtc1, txtc2, txtc3 });


			DataTable da = new DataTable();
			da = selectFiliais();
			dtgvFilial.DataSource = da;

		}

		void DeleteClick(object sender, EventArgs e)
		{
			FrmLoad frmLoad = new FrmLoad();



			var tab = Tabelas.Instancia;
			if (tab.usuario_id == 0 || tab.usuario_id == null)
			{
				ForceComunic.FrmLogin login = new ForceComunic.FrmLogin();
				var veiodeoutro = "OptimizeDelete";
				login.veiodeoutroprojeto(veiodeoutro);
				login.ShowDialog();
				tab.usuario_id = ForceComunic.FrmLogin.UserID;
				
			}
			if (tab.usuario_id != 0 || tab.usuario_id == null)
			{
				
				Querys query = new Querys();
				Deletes deletes = new Deletes();
				addfilialString();

				if (tabelasSelecionadas.Count > 0 && filialSelecionadas.Count > 0)
				{

					

					foreach (var item in tabelasSelecionadas)
					{
						deletes.sqlDeletes(query);
						foreach (var sql in deletes.listQuery)
						{
							if (sql.tabela == item.Nome.ToString())
							{
								
								frmLoad.adicionarSqlLista(sql.tabela,sql.query);
									
								
							}
						}
					}


					frmLoad.ShowDialog();


				}

				




				/*
				Querys query = new Querys();
				Deletes deletes = new Deletes();
				addfilialString();

				if (tabelasSelecionadas.Count > 0 && filialSelecionadas.Count > 0)
				{
					MessageBox.Show("Aguarde a mensagem de concluido!", "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

					foreach (var item in tabelasSelecionadas)
					{
						deletes.sqlDeletes(query);
						foreach (var sql in deletes.listQuery)
						{
							if (sql.tabela == item.Nome.ToString())
							{
								AcessoDadosMysql acessoDados = new AcessoDadosMysql();
								Delete.Enabled = false;

								acessoDados.ExecutarConsulta(CommandType.Text, sql.query);

							}

						}
					}
				}*/
			
				
				
				if (filialSelecionadas.Count == 0)
					MessageBox.Show("Marque ao menos uma filial!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else if (tabelasSelecionadas.Count == 0)
					MessageBox.Show("Marque ao menos uma tabela!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
				{
					MessageBox.Show("Concluido!", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
					tabelasSelecionadas.Clear();
					for (int i = 0; i < dataGridView1.Rows.Count; i++)
					{
						dataGridView1.Rows[i].Cells[0].Value = "N";
						dataGridView1.UpdateCellValue(0, i);
					}
					filialSelecionadas.Clear();


					for (int i = 0; i < dtgvFilial.Rows.Count; i++)
					{		
						dtgvFilial.Rows[i].Cells[0].Value = "N";
						dtgvFilial.UpdateCellValue(0, i);
					}

				}
			
			
			}
		
			Delete.Enabled = true;
			tab.filialMarcada = null;
		}
	
		
		

		void DtpinicioValueChanged(object sender, EventArgs e)
		{
			if (dtpinicio.Value > DateTime.Now)
			{
				MessageBox.Show("Data inicial maior que data atual", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				dtpinicio.Value = DateTime.Now;
			}
			else
			{
				var tabelas = Tabelas.Instancia;
				DateTime data = dtpinicio.Value;
				tabelas.dtInicial = data.ToString("yyyy/MM/dd 00:00:00"); 
			}

		}

		void DtpfinalValueChanged(object sender, EventArgs e)
		{
			if (dtpfinal.Value < dtpinicio.Value)
			{
				MessageBox.Show("Data final menor que data inicial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				dtpfinal.Value = DateTime.Now;
			}
			else
			{
				var tabelas = Tabelas.Instancia;
				DateTime data = dtpfinal.Value;
				tabelas.dtFinal = data.ToString("yyyy/MM/dd 23:59:59"); ;
			}


		}




		void OptimezeClick(object sender, EventArgs e)
		{
			Optimize optimize = new Optimize();

			if (tabelasSelecionadas.Count > 0 && filialSelecionadas.Count > 0)
				MessageBox.Show("Aguarde a mensagem de concluido!", "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			foreach (var item in tabelasSelecionadas)
			{

				optimize.sqlOptimize();

				foreach (var sql in optimize.listOptimize)
				{
					if (sql.Nome == item.Nome.ToString())
					{
						AcessoDadosMysql acessoDados = new AcessoDadosMysql();


						acessoDados.ExecutarConsulta(CommandType.Text, sql.sqlOtimize);
					}

				}

			}
			if (tabelasSelecionadas.Count == 0)
				MessageBox.Show("Marque ao menos uma tabela!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("Concluido!", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);




		}




		void DtgvFilialCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{

			if (e.Value != null && e.Value.Equals("S"))
			{
				dtgvFilial.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkOrange; //nao selecionado
				dtgvFilial.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White; //selecionado
			}
			if (e.Value != null && e.Value.Equals("N"))
			{
				dtgvFilial.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black; //
				dtgvFilial.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));

			}
		}

		void Label6Click(object sender, EventArgs e)
		{

		}

		void Panel4MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}

		}

        #region mouse_hover_down 

        private void Delete_MouseHover(object sender, EventArgs e)
        {
			Delete.ForeColor = Color.White;
			Delete.BackColor = Color.FromArgb(40, 10, 60);
		}

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
			Delete.ForeColor = Color.Black;
			Delete.BackColor = Color.Transparent;
		}

        private void Optimeze_MouseLeave(object sender, EventArgs e)
        {
			Optimeze.ForeColor = Color.Black;
			Optimeze.BackColor = Color.Transparent;
		}

        private void Optimeze_MouseHover(object sender, EventArgs e)
        {
			Optimeze.ForeColor = Color.White;
			Optimeze.BackColor = Color.FromArgb(40, 10, 60);
		}

        #endregion
    }
}

