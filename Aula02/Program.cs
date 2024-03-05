//  Trabalhando com váriaveis C#

using System;
//strings
//Declarando cariável sem inicialização
string message1 = null;
//Inicializar a váriavel com nulo 
string message2 = null;
//Inicializar string vazia
string message3 = System.String.Empty; //"";
//Declarar uma string com valor implícito
var message4 = "Uma mensagem aleatória";

Console.WriteLine( message4 );

//Concatenando Strings
string concat = (message1 == null ? "" : message1) +
                 " " + message2 + " " +
                message3 + " " + message4;
Console.WriteLine( "\n" + concat );

Console.WriteLine(
    "A Temperatura hoje {0:D} é {1}°C"
    , DateTime.Now
    , 23
);

string nome = string.Empty;
Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();
string resultado = $"Oi, {nome}! Pare de jaguarice!";
Console.WriteLine(resultado);

//Escreva um programa em C# que sirva como uma ficha cadastral. Tente caprichar no layout, essa ficha cadastral deve coletar alguns dados do usuário: 
//Nome; 
//Email; 
//Data de nascimento;
//sexo ou genero;
//Endereço: cep, rua, número, bairro, cidade, UF e pais.
//Ao coletar os dados monte um texto exibindo a ficha cadastral do usuário.