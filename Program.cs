/*
 * Created by SharpDevelop.
 * User: vinicio.magalhaes
 * Date: 01/02/2021
 * Time: 11:45
 * 
 */
using System;
using System.Windows.Forms;

namespace OptimizeDelete
{
	
	internal sealed class Program
	{
		
		[STAThread]
		private static void Main(string[] args)
		{
			try{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			
			
			
			Application.Run(new Frm.FrmPrincipal());
			}
			
			catch (Exception ex)
			{
				MessageBox.Show("Não foi possivel acessar o banco de dados. \r\n"  + "Banco de dados inativo ou não é um servidor\r\n" + "Menssagem orignal: " +ex.Message ,"Erro" , MessageBoxButtons.OK ,  MessageBoxIcon.Error );
				throw new Exception("Houve uma falha a o recuperar os " +
				                    "dados do banco de dados.\r\n" + "banco de dados Inativo ou não é um servidor. \r\n" +
				                    "Mensagem original: " + ex.Message);
			}
		}
		
	}
 }

