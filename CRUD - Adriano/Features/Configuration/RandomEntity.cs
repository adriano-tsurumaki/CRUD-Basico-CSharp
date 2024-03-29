﻿using Bogus;
using Bogus.Extensions.Brazil;
using CRUD___Adriano.Features.Cadastro.Produto.Model;
using CRUD___Adriano.Features.Colaborador.Enum;
using CRUD___Adriano.Features.Colaborador.Model;
using CRUD___Adriano.Features.Entidades.DadosBancarios.Model;
using CRUD___Adriano.Features.Entidades.Email.Model;
using CRUD___Adriano.Features.Entidades.Endereco.Model;
using CRUD___Adriano.Features.Entidades.Telefone.Enum;
using CRUD___Adriano.Features.Entidades.Telefone.Model;
using CRUD___Adriano.Features.Estados.Enum;
using CRUD___Adriano.Features.Fornecedor.Dao;
using CRUD___Adriano.Features.Fornecedor.Model;
using CRUD___Adriano.Features.IoC;
using CRUD___Adriano.Features.Produto.Model;
using CRUD___Adriano.Features.Usuario.Enum;
using CRUD___Adriano.Features.Utils;
using CRUD___Adriano.Features.ValueObject.Cnpj;
using CRUD___Adriano.Features.Vendas.Controller;
using CRUD___Adriano.Features.Vendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD___Adriano.Features.Configuration
{
    public static class RandomEntity
    {
        public static IList<ClienteModel> RetornarListaDeClientes(int quantidade)
        {
            var enderecoFaker = RetornarFakerEnderecoModel();

            var emailFaker = RetornarFakerEmailModel();

            var telefoneFaker = RetornarFakerTelefoneModel();

            var clienteFaker = new Faker<ClienteModel>("pt_BR")
                .RuleFor(c => c.Nome, f => f.Person.FirstName)
                .RuleFor(c => c.Sobrenome, f => f.Person.LastName)
                .RuleFor(c => c.DataNascimento, _ => GerarDataNascimentoAleatorio())
                .RuleFor(c => c.ValorLimite, f => new Random().Next(10, 1000).ToString())
                .RuleFor(c => c.Cpf, f => f.Person.Cpf().RetornarSomenteTextoEmNumeros())
                .RuleFor(c => c.Sexo, f => f.Person.Gender == Bogus.DataSets.Name.Gender.Male ? UsuarioSexoEnum.Masculino : UsuarioSexoEnum.Feminino)
                .RuleFor(c => c.Endereco, f => enderecoFaker)
                .RuleFor(c => c.Emails, f => emailFaker.Generate(new Random().Next(1, 10)))
                .RuleFor(c => c.Telefones, f => telefoneFaker.Generate(new Random().Next(1, 10)));

            return clienteFaker.Generate(quantidade);
        }

        public static IList<ColaboradorModel> RetornarListaDeColaboradores(int quantidade)
        {
            var enderecoFaker = RetornarFakerEnderecoModel();

            var emailFaker = RetornarFakerEmailModel();

            var telefoneFaker = RetornarFakerTelefoneModel();

            var dadosBancariosFaker = new Faker<DadosBancariosModel>("pt_BR")
                .RuleFor(d => d.Agencia, _ => new Random().Next(1000, 10000))
                .RuleFor(d => d.Conta, _ => new Random().Next(1000, 10000))
                .RuleFor(d => d.TipoConta, _ => (TipoContaEnum)new Random().Next(1, 4))
                .RuleFor(d => d.Banco, f => f.Company.CompanyName());

            var colaboradorFaker = new Faker<ColaboradorModel>("pt_BR")
                .RuleFor(c => c.Nome, f => f.Person.FirstName)
                .RuleFor(c => c.Sobrenome, f => f.Person.LastName)
                .RuleFor(c => c.DataNascimento, _ => GerarDataNascimentoAleatorio())
                .RuleFor(c => c.Cpf, f => f.Person.Cpf().RetornarSomenteTextoEmNumeros())
                .RuleFor(c => c.Sexo, f => f.Person.Gender == Bogus.DataSets.Name.Gender.Male ? UsuarioSexoEnum.Masculino : UsuarioSexoEnum.Feminino)
                .RuleFor(c => c.DadosBancarios, _ => dadosBancariosFaker)
                .RuleFor(c => c.Salario, _ => new Random().Next(900, 2500).ToString())
                .RuleFor(c => c.Comissao, _ => Math.Round(new Random().NextDouble(), 2))
                .RuleFor(c => c.Endereco, _ => enderecoFaker)
                .RuleFor(c => c.Emails, _ => emailFaker.Generate(new Random().Next(1, 10)))
                .RuleFor(c => c.Telefones, _ => telefoneFaker.Generate(new Random().Next(1, 10)));

            return colaboradorFaker.Generate(quantidade);
        }

        public static IList<FornecedorModel> RetornarListaDeFornecedores(int quantidade)
        {
            var enderecoFaker = RetornarFakerEnderecoModel();

            var emailFaker = RetornarFakerEmailModel();

            var telefoneFaker = RetornarFakerTelefoneModel();

            var fornecedorFaker = new Faker<FornecedorModel>("pt_BR")
                .RuleFor(c => c.Nome, f => f.Person.FirstName)
                .RuleFor(c => c.Sobrenome, f => f.Person.LastName)
                .RuleFor(c => c.DataNascimento, _ => GerarDataNascimentoAleatorio())
                .RuleFor(c => c.Cpf, f => f.Person.Cpf().RetornarSomenteTextoEmNumeros())
                .RuleFor(c => c.Cnpj, f => GerarCnpjAleatoriamente())
                .RuleFor(c => c.Sexo, f => f.Person.Gender == Bogus.DataSets.Name.Gender.Male ? UsuarioSexoEnum.Masculino : UsuarioSexoEnum.Feminino)
                .RuleFor(c => c.Endereco, _ => enderecoFaker)
                .RuleFor(c => c.Emails, _ => emailFaker.Generate(new Random().Next(1, 10)))
                .RuleFor(c => c.Telefones, _ => telefoneFaker.Generate(new Random().Next(1, 10)));

            return fornecedorFaker.Generate(quantidade);
        }

        public static IList<ProdutoModel> RetornarListaDeProdutos(int quantidade)
        {

            var produtoFaker = new Faker<ProdutoModel>("pt_BR")
                .RuleFor(p => p.Fornecedor, _ => RetornarFakerFornecedorId())
                .RuleFor(p => p.Nome, f => f.Commerce.Product())
                .RuleFor(p => p.CodigoBarras, _ => GerarCodigoDeBarrasAleatorio())
                .RuleFor(p => p.Ativo, _ => true)
                .RuleFor(p => p.PrecoBruto, f => f.Commerce.Price(10, 1000, 2))
                .RuleFor(p => p.Lucro, f => f.Random.Double())
                .RuleFor(p => p.Quantidade, f => f.Random.Int(5, 500));
                
            return produtoFaker.Generate(quantidade);
        }

        private static Faker<FornecedorModel> RetornarFakerFornecedorId()
        {
            var listaDeIds = ConfigNinject.ObterInstancia<FornecedorDao>().ListarTodosOsFornecedoresSomenteIdENome().Select(x => x.Id).ToList();

            return new Faker<FornecedorModel>()
                .RuleFor(c => c.Id, _ => listaDeIds[new Random().Next(listaDeIds.Count)]);
        }

        public static Faker<EnderecoModel> RetornarFakerEnderecoModel() =>
            new Faker<EnderecoModel>("pt_BR")
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

        public static Faker<EmailModel> RetornarFakerEmailModel() =>
            new Faker<EmailModel>("pt_BR")
                .RuleFor(e => e.Nome, f => f.Person.Email);

        public static Faker<TelefoneModel> RetornarFakerTelefoneModel() =>
            new Faker<TelefoneModel>("pt_BR")
                .RuleFor(t => t.Numero, f => f.Person.Phone.RetornarSomenteTextoEmNumeros())
                .RuleFor(t => t.Tipo, _ => (TipoTelefoneEnum)new Random().Next(1, 4));

        // TODO: Fazer um gerador de cnpj!
        // precisa validar se já existe o cnpj gerado no banco!
        public static MeuCnpj GerarCnpjAleatoriamente()
        {
            return new Random().Next(1, 1_000_000_000).ToString();
        }

        // TODO: Fazer o gerador de código de barras!
        public static string GerarCodigoDeBarrasAleatorio()
        {
            return $"789{new Random().Next(10000, 99999)}{new Random().Next(1000, 9999)}{new Random().Next(1, 9)}";
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

        public static IList<VendaModel> RetornarListaDeVenda(int quantidade)
        {
            var vendaFaker = new Faker<VendaModel>();

            return vendaFaker.Generate(quantidade);
        }

        public static IList<VendaProdutoModel> RetornarListaDeVendaProduto(int quantidade)
        {
            var vendaProdutoFaker = new Faker<VendaProdutoModel>();

            return vendaProdutoFaker.Generate(quantidade);
        }
    }
}
