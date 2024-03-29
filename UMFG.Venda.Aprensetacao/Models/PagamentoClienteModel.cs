using System;
using System.ComponentModel.DataAnnotations;

namespace UMFG.Venda.Aprensetacao.Models
{
	public class PagamentoClienteModel
	{
		[Required(ErrorMessage = "O nome do cliente é obrigatório.")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O número do cartão é obrigatório.")]
		[CreditCard(ErrorMessage = "O número do cartão é inválido.")]
		public string NumeroCartao { get; set; }

		[Required(ErrorMessage = "A data de vencimento é obrigatória.")]
		[RegularExpression(@"^(0[1-9]|1[0-2])\/((20)\d{2})$", ErrorMessage = "Formato de data inválido. Use MM/yyyy.")]
		public string DataVencimento { get; set; }

		[Required(ErrorMessage = "O CVV é obrigatório.")]
		[RegularExpression(@"^\d{3}$", ErrorMessage = "O CVV deve conter exatamente 3 dígitos.")]
		public string CVV { get; set; }
	}
}
