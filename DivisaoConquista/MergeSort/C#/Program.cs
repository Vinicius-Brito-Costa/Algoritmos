using System;
using System.Collections.Generic;
using System.Linq;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>(){12, 4, 5, 7, 10, 1, 8, 11, 3, 9, 2, 6};
            Console.Write("Lista: ");
            foreach(int item in lista){
                Console.Write(item + ", ");
            }
            Console.Write("\nLista Organizada: ");
            foreach(int item in MergeSort(lista)){
                Console.Write(item + ", ");
            }
            
        }
        static List<int> MergeSort(List<int> lista){
            if(lista.Count <= 1) return lista;
            int meio = lista.Count / 2;
            var direita = MergeSort(lista.Take(meio).ToList());
            var esquerda = MergeSort(lista.Skip(meio).ToList());
            return Merge(direita, esquerda);
        }
        static List<int> Merge(List<int> direita, List<int> esquerda){
            List<int> organizados = new List<int>();
            while(direita.Count > 0 && esquerda.Count > 0){
                if(direita[0] > esquerda[0]){
                    organizados.Add(esquerda[0]);
                    esquerda.RemoveAt(0);
                }
                else{
                    organizados.Add(direita[0]);
                    direita.RemoveAt(0);
                }
            }
            organizados.AddRange(esquerda);
            organizados.AddRange(direita);
            return organizados;
        }
    }
}
