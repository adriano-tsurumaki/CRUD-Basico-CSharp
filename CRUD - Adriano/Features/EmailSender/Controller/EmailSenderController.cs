using CRUD___Adriano.Features.Entidades.Email.Model;
using CRUD___Adriano.Features.ValueObject.Precos;
using System.Net;
using System.Net.Mail;

namespace CRUD___Adriano.Features.Email.Controller
{
    public class EmailSenderController
    {
        public static SmtpClient ConfiguracaoDoSmtpClient() =>
            new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Timeout = 10000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("crudfashiontest@gmail.com", "ASDjuki258/*-")
            };

        public static MailMessage ConfiguracaoDaMensagem(string titulo, string corpo) =>
            new MailMessage()
            {
                From = new MailAddress("crudfashiontest@gmail.com"),
                Subject = titulo,
                Body = corpo
            };

        public static void EnviarConfirmacaoDaCompra(string nomeCliente, Preco valorDaCompra, EmailModel emailModel)
        {
            var cliente = ConfiguracaoDoSmtpClient();
            var mensagem = ConfiguracaoDaMensagem
                ("Venda efetuada com sucesso! (TESTE)", 
                $@"Olá {nomeCliente}! Obrigado por comprar na loja Augusto Fashion. O valor total da compra foi de {valorDaCompra.Formatado}");

            mensagem.To.Add(emailModel.Nome);
            cliente.Send(mensagem);
        }
    }
}
