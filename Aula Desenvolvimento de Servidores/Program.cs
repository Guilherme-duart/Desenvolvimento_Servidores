// See https://aka.ms/new-console-template for more information
using Aula_Desenvolvimento_de_Servidores;
using ConsoleApp_Manha;
using System.ComponentModel;
using System.Security.Cryptography;

//Console.WriteLine("Hello, World!");

//Produto p1 = new Produto(1, "mouse sem fio", 59.90M);
//Console.WriteLine(p1.getDescricao() + " " + p1.getValor() );

//cliente p2= new cliente(1,"Guilherme Henrique Duarte", "(16)99876542");
//Console.WriteLine(p2.getId() + p2.getNome() + " " + p2.getTelefone() );

Endereco e1 = new Endereco("maria mizari", "91", "13544778","sobral", "taquaritinga", "Sp");

cliente c2 = new cliente(1, "Guilherme", "9767570", e1);
cliente c3 = new cliente(2, "Eduardo", "9767570", e1);
cliente c4 = new cliente(3, "Renata", "9767570", e1);
cliente c5 = new cliente(4, "Augusto", "9767570", e1);

Console.WriteLine(c2.getEndereco().getRua());
c2.getEndereco().setRua("Prudente de Moraes");

