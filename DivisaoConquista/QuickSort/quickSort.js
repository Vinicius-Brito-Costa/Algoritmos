let listaDeNumeros = [4, 5, 7, 10, 1, 8, 11, 3, 9, 2, 6, 6.1, 6.4, 77, -5, 14, 105];

function QuickSort(lista, inicio = 0, fim = null){
    if(fim === null) fim = lista.length - 1;
    if(inicio >= fim) return;
    let pivo = Partition(lista, inicio, fim);
    QuickSort(lista, inicio, pivo - 1);
    QuickSort(lista, pivo + 1, fim);
}
function Partition(lista, inicio, fim){
    let ponto = inicio;
    for(inicio; inicio < fim; inicio++){
        if(lista[inicio] <= lista[fim]){
            [lista[ponto], lista[inicio]] = [lista[inicio], lista[ponto]];
            ponto++;
        }
    }
    [lista[ponto], lista[fim]] = [lista[fim], lista[ponto]]
    return ponto;
}
console.log("Desordenados: " + listaDeNumeros);
QuickSort(listaDeNumeros);
console.log("Ordenados: " + listaDeNumeros);