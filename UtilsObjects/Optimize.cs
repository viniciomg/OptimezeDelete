
using System;
using System.Collections.Generic;

namespace OptimizeDelete.UtilsObjects
{
	
	public class Optimize
	{
		public Optimize()
		{			
		}
		
		public string Nome { get; set; }
		public string sqlOtimize { get; set; }
		
		public Optimize(string nome, string sqlOtimize)
		{			
			this.Nome = nome;
			this.sqlOtimize = sqlOtimize;
		}
		
		public List<Optimize> listOptimize;
		public string sqlOptimize()
			{
			listOptimize = new List<Optimize>();
			
			listOptimize.Add(new Optimize(Nome ="movment" , sqlOtimize ="Optimize table movment;"));
			listOptimize.Add(new Optimize(Nome ="lote_saida" , sqlOtimize ="Optimize table lote_saida"));
			listOptimize.Add(new Optimize(Nome ="orcament;" , sqlOtimize ="Optimize table orcament;"));
			listOptimize.Add(new Optimize(Nome ="logs" , sqlOtimize ="Optimize table logs;"));
			listOptimize.Add(new Optimize(Nome ="alt_linear" , sqlOtimize ="Optimize table alt_linear;"));
			listOptimize.Add(new Optimize(Nome ="itens_alt_linear" , sqlOtimize ="Optimize table itens_alt_linear;"));
			listOptimize.Add(new Optimize(Nome ="pagar" , sqlOtimize ="Optimize table pagar;"));
			listOptimize.Add(new Optimize(Nome ="pagamentos" , sqlOtimize="Optimize table pagamentos;"));
			listOptimize.Add(new Optimize(Nome ="pedidos" , sqlOtimize ="Optimize table pedidos;"));
			listOptimize.Add(new Optimize(Nome ="pedeletronico" , sqlOtimize ="Optimize table pedeletronico;"));
			listOptimize.Add(new Optimize(Nome ="pedeletronico_arquivos" ,sqlOtimize ="Optimize table pedeletronico_arquivos;"));
			listOptimize.Add(new Optimize(Nome ="preco_medio_custo_historico" , sqlOtimize ="Optimize table preco_medio_custo_historico;"));
			listOptimize.Add(new Optimize(Nome ="remanejamento" , sqlOtimize ="Optimize table remanejamento;"));
			listOptimize.Add(new Optimize(Nome ="relbomdia" , sqlOtimize="Optimize table relbomdia;"));
			listOptimize.Add(new Optimize(Nome ="faltas" , sqlOtimize ="Optimize table faltas;"));
			listOptimize.Add(new Optimize(Nome ="entradas" , sqlOtimize ="Optimize table entradas;"));
			listOptimize.Add(new Optimize(Nome ="entradas_lote" , sqlOtimize ="Optimize table entradas_lote;"));
			listOptimize.Add(new Optimize(Nome ="entradas_lote_temp" , sqlOtimize ="Optimize table entradas_lote_temp;"));
			listOptimize.Add(new Optimize(Nome ="estoque_posterior" , sqlOtimize ="Optimize table estoque_posterior;"));
			listOptimize.Add(new Optimize(Nome ="cheques" , sqlOtimize ="Optimize table cheques;"));
			listOptimize.Add(new Optimize(Nome ="transferencia" , sqlOtimize ="Optimize table transferencia;"));
			listOptimize.Add(new Optimize(Nome ="receber" , sqlOtimize ="Optimize table receber;"));
			listOptimize.Add(new Optimize(Nome ="baixa_adm_det_rec" , sqlOtimize ="Optimize table baixa_adm_det_rec;"));
			listOptimize.Add(new Optimize(Nome ="baixa_adm" , sqlOtimize ="Optimize table baixa_adm;"));
			listOptimize.Add(new Optimize(Nome ="baixa_adm_det" , sqlOtimize ="Optimize table baixa_adm_det;"));
			listOptimize.Add(new Optimize(Nome ="mensagens" , sqlOtimize ="Optimize table mensagens;"));
			listOptimize.Add(new Optimize(Nome ="nfe_det;" , sqlOtimize ="Optimize TABLE nfe_det;"));
			listOptimize.Add(new Optimize(Nome ="nfe_duplicata" , sqlOtimize ="Optimize TABLE nfe_duplicata;"));
			listOptimize.Add(new Optimize(Nome ="nfe_lote" , sqlOtimize ="Optimize TABLE nfe_lote;"));
			listOptimize.Add(new Optimize(Nome ="nfe_pagamento_cab" , sqlOtimize ="Optimize TABLE nfe_pagamento_cab;"));
			listOptimize.Add(new Optimize(Nome ="nfe_pagamento" , sqlOtimize ="Optimize TABLE nfe_pagamento;"));
			listOptimize.Add(new Optimize(Nome ="nfe_cab_xml" , sqlOtimize ="Optimize TABLE nfe_cab_xml;"));
			listOptimize.Add(new Optimize(Nome ="nfe_cab" , sqlOtimize ="Optimize TABLE nfe_cab;"));
			
			return (listOptimize).ToString();
			
		}
	
	}
}
