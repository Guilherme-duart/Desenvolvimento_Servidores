﻿// See https://aka.ms/new-console-template for more information
using Aula_Desenvolvimento_de_Servidores;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, "mouse sem fio", 59.90M);
Console.WriteLine(p1.getDescricao() + " " + p1.getValor() );

Pessoa p2= new Pessoa(3,"Guilherme Henrique Duarte", "(16)99876542");
Console.WriteLine(p2.getId() + p2.getNome() + " " + p2.getTelefone() );

