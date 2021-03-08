using System;
using System.Collections.Generic;
class App{
    static void Main(){
        List<int> lista = new List<int>(){0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        var resultado = BuscaNormal(lista, 20);
        Console.Write(resultado);
    }
    static string BuscaNormal(List<int> lista, int elemento){
        var passos = 0;
        for (int i = 0; i < lista.Count; i++)
        {
            if(lista[i] == elemento){
                return "O valor " + elemento + " foi encontrado no index: " + i + "\nNumero de passos: " + i;
            }
            else{
                passos = i;
            }
        }
        return "Valor não encontrado. " + "Numero de passos: " + passos;
    }
    static string BuscaBinaria(List<int> lista, int elemento){
        return null;
    }
}