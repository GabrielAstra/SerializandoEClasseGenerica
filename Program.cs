using System;
using System.Text.Json.Serialization;
using Ser.Models;
using Newtonsoft.Json;


Pessoa pessoa1 = new Pessoa(123430, "John", 30);

pessoa1.Apresentar();


string json = JsonConvert.SerializeObject(pessoa1, Formatting.Indented);

Console.WriteLine(json);



// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




MeuArray<int> lista = new MeuArray<int>();

lista.AdicionarElementoArray(10);

Console.WriteLine(lista[0]);


//Testando array tipo 'string'


MeuArray<string> lista2 = new MeuArray<string>();

lista2.AdicionarElementoArray("Joao");
Console.WriteLine(lista2[0]);




