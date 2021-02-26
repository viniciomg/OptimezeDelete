
using System;
using System.Data;
using System.Text;
using MySql4.Data.MySqlClient;
// using MySql.Data.MySqlClient;
using OptimizeDelete;
using OptimizeDelete.Utils;

namespace OptimizeDelete.AcessoDados
{
	/// <summary>
	/// Description of AcessoDadosMysql.
	/// </summary>
	
		
	public class AcessoDadosMysql
	{
		string HextoString(string hexString)
		{
			if (hexString == null || (hexString.Length & 1) == 1)
			{
				throw new ArgumentException();
			}
			var sb = new StringBuilder();
			for (var i = 0; i < hexString.Length; i += 2)
			{
				var hexChar = hexString.Substring(i, 2);
				sb.Append((char)Convert.ToByte(hexChar, 16));
			}
			return sb.ToString();
		}
		
		private MySqlConnection CriarConexao()
		{
			MySqlConnection conn = new MySqlConnection();
			Utils.IniFile objIniFile = new Utils.IniFile();
			string strFilePath = objIniFile.filePath("connection.conf");
			string local = objIniFile.IniReadString("connection","DatabaseIP", strFilePath).ToString();
			string database = objIniFile.IniReadString("connection","Databasename", strFilePath).ToString();
			string usuario = objIniFile.IniReadString("connection","Usuario", strFilePath).ToString();
			string senha = objIniFile.IniReadString("connection","Senha", strFilePath).ToString();
			string cgc = objIniFile.IniReadString("connection" ,"Cnpj" , strFilePath).ToString();
			
			local = HextoString(local);
			database = HextoString(database);
			usuario = HextoString(usuario);
			senha = HextoString(senha);
			cgc = HextoString(cgc);
			
			
			var bancoDados = BancoDados.Instancia;
			var tabelas =  Tabelas.Instancia;
			tabelas.Cgc = cgc;
			tabelas.database = database;
			bancoDados.Banco=database;
						
			conn.ConnectionString =@"server=" + local + ";database=" + database + ";userid=" + usuario + ";password=" + senha + "; convert zero datetime = True";


			if (conn.State != ConnectionState.Open)
				conn.Open();
			return conn;
		}
		
		
			private MySqlParameterCollection sqlParameterCollection =
			new MySqlCommand().Parameters;

		public void LimparParametros()
		{
			sqlParameterCollection.Clear();
		}
		
		public void AdicionarParametros(string nomeParametro,
		                                object valorParametro)
		{
			sqlParameterCollection.Add(
				new MySqlParameter(nomeParametro, valorParametro));
		}

		public int ExecutarManipulacao(CommandType commandType,
		                               string nomeStoredProcedureOuTextoSql)
		{
			try
			{
				MySqlConnection sqlConnection = CriarConexao();
				MySqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlCommand.CommandType = commandType;
				sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;

				foreach (MySqlParameter sqlParameter in sqlParameterCollection)
				{
					sqlCommand.Parameters.Add(new
					                          MySqlParameter(sqlParameter.ParameterName,
					                                         sqlParameter.Value));
				}

				return sqlCommand.ExecuteNonQuery();
				
			}
			catch (Exception ex)
			{
				throw new Exception("Houve uma falha ao executar o " +
				                    "comando no banco de dados.\r\n" +
				                    "Mensagem original: " + ex.Message);
			}
		}



		public object ExecutarConsultaScalar(CommandType commandType,
											 string nomeStoredProcedureOuTextoSql)
		{
			try
			{
					MySqlConnection sqlConnection = CriarConexao();
					MySqlCommand sqlCommand = sqlConnection.CreateCommand();

					sqlCommand.CommandType = commandType;
					sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;

					foreach (MySqlParameter sqlParameter in sqlParameterCollection)
					{
						sqlCommand.Parameters.Add(new
												  MySqlParameter(sqlParameter.ParameterName,
																 sqlParameter.Value));
					}

					return sqlCommand.ExecuteScalar();
				
			}
			catch (Exception ex)
			{
				throw new Exception("Houve uma falha ao executar o " +
									"comando no banco de dados.\r\n" +
									"Mensagem original: " + ex.Message);

			}
		}
		void cancelarExecucao()
		{
			//myCommand.Cancel();
		}
		public DataTable ExecutarConsulta(CommandType commandType,
		                                  string nomeStoredProcedureOuTextoSql)
		{
			try
			{
				MySqlConnection sqlConnection = CriarConexao();
				MySqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlCommand.CommandType = commandType;
				sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;

				foreach (MySqlParameter sqlParameter in sqlParameterCollection)
				{
					sqlCommand.Parameters.Add(new
					                          MySqlParameter(sqlParameter.ParameterName,
					                                         sqlParameter.Value));
				}
				//return sqlCommand.ExecuteNonQuery();
				
				MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();

				sqlDataAdapter.Fill(dataTable);
				sqlConnection.Close();

				return dataTable;
			}
			catch (Exception ex)
			{
				throw new Exception("Houve uma falha a o recuperar os " +
				                    "dados do banco de dados.\r\n" +
				                    "Mensagem original: " + ex.Message);
			}
		}
		
		
		public MySqlDataReader ExecutarReader(CommandType commandType,
		                                  string nomeStoredProcedureOuTextoSql)
		{
			try
			{
				MySqlConnection sqlConnection = CriarConexao();
				MySqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = commandType;
				sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
				foreach (MySqlParameter sqlParameter in sqlParameterCollection)
				{
					sqlCommand.Parameters.Add(new
					                          MySqlParameter(sqlParameter.ParameterName,
					                                         sqlParameter.Value));
				}
				MySqlDataReader dr = sqlCommand.ExecuteReader();
				return dr;
			}
			catch (Exception ex)
			{
				throw new Exception("Houve uma falha a o recuperar os " +
				                    "dados do banco de dados.\r\n" +
				                    "Mensagem original: " + ex.Message);
			}
		}
		
		public MySqlConnection PegaFilial(){
			MySqlConnection conn = new MySqlConnection();
			Utils.IniFile objIniFile = new Utils.IniFile();
			string strFilePath = objIniFile.filePath("connection.conf");
			string filial_id  =  objIniFile.IniReadString("connection" ,"CodFisica" , strFilePath).ToString();
			filial_id = HextoString(filial_id);
			var tabelas =  Tabelas.Instancia;
			tabelas.id_filial =  filial_id;
			
			return conn;
		}
	}

}

