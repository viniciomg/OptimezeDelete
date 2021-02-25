
using System;

namespace OptimizeDelete.UtilsObjects
{
	
	public class Querys
	{
		public Querys()	{}
		
			public string tabela { get; set; }
			public string query { get; set; }
			
			public Querys(string tabela, string query)
			{
				this.tabela = tabela;
				this.query = query;
			}
			
		
	}
}
