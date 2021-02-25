
using System;

namespace OptimizeDelete
{
	
	public sealed class Tabelas
	{
		static Tabelas _instancia;
		public static Tabelas Instancia{
			get {return _instancia ?? (_instancia = new Tabelas()); }
			
		}
		private Tabelas(){}
		
		public  string  dtInicial {get; set;}
		public  string  dtFinal {get; set;}	 
		public string Cgc { get; set; }
		public int Persistencia { get; set; }		
		public string database{get;set;}
		public string filial_id { get; set; }
		public string id_filial { get; set; }
		public string filialMarcada {get;set;}
		public string DataInicioBanco {get; set;}
        public int usuario_id { get; set; }




    }
}
