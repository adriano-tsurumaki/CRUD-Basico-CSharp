using Bogus;
using Bogus.Extensions.Brazil;
using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Email.Model;
using CRUD___Adriano.Features.Endereco.Model;
using CRUD___Adriano.Features.Estados.Enum;
using CRUD___Adriano.Features.Telefone.Enum;
using CRUD___Adriano.Features.Telefone.Model;
using CRUD___Adriano.Features.Usuario.Enum;
using CRUD___Adriano.Features.Utils;
using System;
using System.Collections.Generic;

namespace CRUD___Adriano.Features.Cliente.Dao
{
    public static class GerarClienteRandomico
    {
        public static IList<ClienteModel> RetornarListaDeClientes(int quantidade)
        {
            var enderecoFaker = new Faker<EnderecoModel>("pt_BR")
                .RuleFor(e => e.Cidade, f => f.Address.City())
                .RuleFor(e => e.Numero, f => f.Address.BuildingNumber())
                .RuleFor(e => e.Complemento, f => f.Address.SecondaryAddress())
                .RuleFor(e => e.Logradouro, f => $"{f.Address.StreetSuffix()} {f.Address.StreetName()}")
                .RuleFor(e => e.Bairro, f => f.Address.StreetSuffix())
                .RuleFor(e => e.Uf, f =>
                {
                    Enum.TryParse(f.Address.StateAbbr(), out EstadosBrasilEnum estado);
                    return estado;
                });

            var emailFaker = new Faker<EmailModel>("pt_BR")
                .RuleFor(e => e.Nome, f => f.Person.Email);

            var telefoneFaker = new Faker<TelefoneModel>("pt_BR")
                .RuleFor(t => t.Numero, f => f.Person.Phone.RetornarSomenteNumeros())
                .RuleFor(t => t.Tipo, _ => (TipoTelefoneEnum)new Random().Next(1, 4));

            var clienteFaker = new Faker<ClienteModel>("pt_BR")
                .RuleFor(c => c.Nome, f => f.Person.FirstName)
                .RuleFor(c => c.Sobrenome, f => f.Person.LastName)
                .RuleFor(c => c.DataNascimento, _ => GerarDataNascimentoAleatorio())
                .RuleFor(c => c.ValorLimite, f => new Random().Next(10, 1000).ToString())
                .RuleFor(c => c.Cpf, f => f.Person.Cpf().RetornarSomenteNumeros())
                .RuleFor(c => c.Sexo, f => f.Person.Gender == Bogus.DataSets.Name.Gender.Male ? UsuarioSexoEnum.Masculino : UsuarioSexoEnum.Feminino)
                .RuleFor(c => c.Endereco, f => enderecoFaker)
                .RuleFor(c => c.Emails, f => emailFaker.Generate(new Random().Next(1, 10)))
                .RuleFor(c => c.Telefones, f => telefoneFaker.Generate(new Random().Next(1, 10)));

            return clienteFaker.Generate(quantidade);
        }

        public static DateTime GerarDataNascimentoAleatorio()
        {
            var random = new Random();
            
            var ano = random.Next(1950, DateTime.Now.Year + 1);
            var mes = random.Next(1, 13);
            var dia = random.Next(1, 32);

            if (VerificarSeEAnoBissexto(ano) && mes == 2 && dia > 29)
                dia = 29;
            else if (mes == 2 && dia > 28)
                dia = 28;
            else if (!VerificarSeMesPossui31Dias(mes) && dia > 30)
                dia = 30;

            return new DateTime(ano, mes, dia);
        }

        public static bool VerificarSeEAnoBissexto(int ano) => (ano % 4 == 0 && ano % 100 != 0) || (ano % 4 == 0 && ano % 100 == 0 && ano % 400 == 0);

        public static bool VerificarSeMesPossui31Dias(int mes) =>
            mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12;
    }

    public enum ListaDeNomes
    {

    }
}
