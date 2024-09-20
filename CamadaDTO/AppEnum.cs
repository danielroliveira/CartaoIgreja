using System;
using System.Collections.Generic;
using System.Linq;

namespace CamadaDTO
{
	public enum EnumAcessoTipo : byte
	{
		Suporte = 0,
		Administrador = 11,
		Usuario_Senior = 12,
		Usuario_Comum = 13,
		Usuario_Local = 14
	}

	public enum EnumAgendaRecorrencia : int
	{
		Diaria = 1,
		Semanal = 2,
		MensalPorDia = 3,
		MensalPorSemana = 4,
		AnualPorDia = 5,
		AnualPorMesSemana = 6
	}

	public enum EnumMovOrigem : byte
	{
		Contribuicao = 1,
		AReceber = 2,
		APagar = 3,
		CaixaAjuste = 4,
		TransfConta = 5,
		TransfSetor = 6,
		Entrada = 7
	}

	public enum EnumImagemOrigem : byte
	{
		Despesa = 1,
		APagar = 2,
		Movimentacao = 3
	}

	public enum EnumPessoaFormas : byte
	{
		Contribuinte = 1,
		Credor = 2,
		Funcionario = 3,
		Colaborador = 4,
		Voluntario = 5,
		Endereco = 6
	}


	public static class EnumUtil
	{
		/// <summary>
		/// Funcao que retorna uma lista com os itens de um Enum fornecido em T
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns>Uma lista de items do Enum</returns>
		public static IEnumerable<T> GetValues<T>() // USAGE: var values = EnumUtil.GetValues<Foos>();
		{
			return Enum.GetValues(typeof(T)).Cast<T>();
		}

		// RETURN STRING OF DESCRIPTION ENUM
		//------------------------------------------------------------------------------------------------------------
		public static Dictionary<int, string> AgendaRecorrenciaTexto()
		{
			var items = EnumUtil.GetValues<EnumAgendaRecorrencia>();

			var Dic = new Dictionary<int, string>();

			foreach (var item in items)
			{
				switch (item)
				{
					case EnumAgendaRecorrencia.Diaria:
						Dic.Add((int)item, "Diária");
						break;
					case EnumAgendaRecorrencia.Semanal:
						Dic.Add((int)item, "Semanal");
						break;
					case EnumAgendaRecorrencia.MensalPorDia:
						Dic.Add((int)item, "Mensal Por Dia");
						break;
					case EnumAgendaRecorrencia.MensalPorSemana:
						Dic.Add((int)item, "Mensal Por Semana");
						break;
					case EnumAgendaRecorrencia.AnualPorDia:
						Dic.Add((int)item, "Anual Por Dia");
						break;
					case EnumAgendaRecorrencia.AnualPorMesSemana:
						Dic.Add((int)item, "Anual Por Mes e Semana");
						break;
					default:
						break;
				}
			}

			return Dic;
		}
	}
}
