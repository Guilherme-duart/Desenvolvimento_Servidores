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

cliente c1 = new cliente(1, "Guilherme", "9767570", e1);
cliente c2 = new cliente(2, "Eduardo", "9767570", e1);
cliente c3 = new cliente(3, "Renata", "9767570", e1);
cliente c4 = new cliente(4, "Augusto", "9767570", e1);

Console.WriteLine(c1.getEndereco().getRua());
c1.getEndereco().setRua("Prudente de Moraes");
Console.WriteLine(c1.getEndereco().getRua());
Console.WriteLine(c1.getEndereco().getEnderecoCompleto());

Carro car = new Carro();
car.Marca = "VW";
car.numeroPortas = 4;
car.numeroRodas = 4;
car.cor = "Vermelho";
car.PagaImposto = true;


aviao aviao = new aviao();
aviao.portasInternas = 10;
aviao.numeroPortas = 8;
aviao.numeroRodas = 2;
aviao.cor = "branco";
aviao.quantidadeAcentos = 500;
aviao.PagaImposto = false;


Bike bicicleta = new Bike();
bicicleta.PagaImposto = false;


Console.WriteLine(aviao.ExibirDados());
Console.WriteLine(car.ExibirDados());

List<Veiculos> listaveiculos = new List<Veiculos>();
listaveiculos.Add(aviao);
listaveiculos.Add(car);
listaveiculos.Add(bicicleta);

List<cliente> listacliente = new List<cliente>();
listacliente.Add(c1);
listacliente.Add(c2);
listacliente.Add(c3);
listacliente.Add(c4);

foreach (var item in listacliente)
{
    Console.WriteLine(item.getNome());
}