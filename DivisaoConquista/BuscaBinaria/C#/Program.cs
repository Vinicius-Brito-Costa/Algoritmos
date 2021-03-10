using System;
using System.Collections.Generic;
class App{
    static void Main(){
        List<int> lista = new List<int>(){0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        var linear = BuscaNormal(lista, 21);
        var binaria = BuscaBinaria(lista, 21);
        Console.WriteLine(linear);
        Console.WriteLine(binaria);
    }
    static string BuscaNormal(List<int> lista, int elemento){
        var passos = 0;
        for (int i = 0; i < lista.Count; i++)
        {
            if(lista[i] == elemento){
                return "Busca Linear: O valor " + elemento + " foi encontrado no index: " + i + "\nNumero de passos: " + i;
            }
            else{
                passos = i;
            }
        }
        return "Busca Linear: Valor não encontrado. " + "Numero de passos: " + passos;
    }
    static string BuscaBinaria(List<int> lista, int elemento){
        int inicio, meio, fim, passos;
        passos = 0;
        inicio = 0;
        meio =  (lista.Count - 1) / 2;
        fim = lista.Count - 1;
        while(inicio <= fim){
            passos++;
            meio = (inicio + fim) / 2;
            if(lista[meio] == elemento){
                return "Busca Binária: O valor " + elemento + " foi encontrado no index: " + meio + "\nNumero de passos: " + passos;
            }
            if(lista[meio] < elemento){
                inicio = meio + 1;
            }
            else{
                fim = meio - 1;
            }
        }
        return "Busca Binária: Valor não encontrado. " + "Numero de passos: " + passos;
    }
}