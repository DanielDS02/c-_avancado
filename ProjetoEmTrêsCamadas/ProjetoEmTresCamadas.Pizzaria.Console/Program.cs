﻿// See https://aka.ms/new-console-template for more information
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio;
using ProjetoEmTresCamadas.Pizzaria.DAO;

PizzaDAO pizzaDAO = new PizzaDAO(); 
var cliente = new Cliente();
var pedido = new Pedido();


Console.WriteLine("Bem vindo a nossa pizzaria");
Console.WriteLine("Qual o seu nome?");
var nome = Console.ReadLine();
cliente.Nome = nome;
Console.WriteLine("Gostaria de uma pizza, S para sim e N para não");
var resposta = Console.ReadLine();
Console.WriteLine(resposta);



if (resposta == "S")
{
    var pizza = new Pizza();
    Console.WriteLine("Qual o sabor de pizza, calabresa 'C' , frango 'F' ?");
    var sabor = Console.ReadLine();
    Console.WriteLine($"O sabor escolhido foi {pizza.DefinirSabor(sabor)}");
    Console.WriteLine("Qual o tamanho da pizza, pequeno 'P', médio 'M', grande 'G'?");
    var tamanho = Console.ReadLine();
    Console.WriteLine($"O tamanho escolhido foi {pizza.DefinirTamanho(tamanho)}");


    pedido.ClienteId = cliente.Id;
    pedido.PizzaId = pizza.Id;



    pizzaDAO.CriaPizza(pizza);
    Console.WriteLine($"Sua pizza é {pizza.ToString()}");

    
}



Console.WriteLine("Fim");

