let listaDeNumeros = [4, 5, 7, 10, 1, 8, 11, 3, 9, 2, 6.1, 6.4];

function MergeSort(lista){
    if(lista.length <= 1){
        return lista;
    }
    let meio = Math.floor(lista.length / 2);
    let esquerda = MergeSort(lista.slice(0, meio));
    let direita = MergeSort(lista.slice(meio));
    return Merge(esquerda, direita)
}
function Merge(lista1, lista2){
    let organizados = [];
    while(lista1.length && lista2.length){
        if(lista1[0] > lista2[0]){
            organizados.push(lista2.shift());
        }
        else{
            organizados.push(lista1.shift());
        }
    }
    return organizados.concat(lista1.concat(lista2));
}
let resultado = MergeSort(listaDeNumeros);
console.log(resultado);