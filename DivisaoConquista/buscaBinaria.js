let log = console.log;
let quantidadeDeItens = 1000;
let list = Array.from({length: (quantidadeDeItens + 1)}, () => Math.floor(Math.random() * (quantidadeDeItens + 1)));
list.sort((a, b) => a - b)
console.log(list)
function buscaNormal(lista, elemento){
    log(lista)
    for(let i = 0; i < lista.length; i++){
        log("Passos da Busca Linear: " + i);
        if(lista[i] === elemento){
            return `O valor ${elemento} foi encontrado no indice: ${i}`;
        }
    }
    return 'Valor não encontrado.';
}
function buscaBinaria(lista, elemento){
    let inicio = 0;
    let meio = 0;
    let final = lista.length - 1;
    let passos = 0;
    for(inicio; inicio <= final;){
        
        log("Passos da Busca Binaria: " + passos)
        passos++;
        meio = Math.round((inicio + final) / 2);

        if(lista[meio] === elemento){
            return `O valor ${elemento} foi encontrado no indice: ${meio}`;
        }
        if(lista[meio] < elemento){
            inicio = meio + 1;
        }
        else{
           final = meio - 1;
        }

    }
    return 'Valor não encontrado.';
}
console.log(buscaNormal(list, 1001));
console.log(buscaBinaria(list, 1001));