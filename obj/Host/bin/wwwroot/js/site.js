const Status = [
    {
        id: 1,
        nome: "Situacao1",
        quantidade: "40",
        situacao: "NÃO INICIADOS"

    },
    {
        id: 2,
        nome: "Situacao2",
        quantidade: "40",
        situacao: "NÃO INICIADOS"

    },
    {
        id: 3,
        nome: "Situacao3",
        quantidade: "40",
        situacao: "NÃO INICIADOS"

    },
    {
        id: 3,
        nome: "Situacao4",
        quantidade: "40",
        situacao: "NÃO INICIADOS"

    },
    {
        id: 4,
        nome: "Situacao5",
        quantidade: "40",
        situacao: "NÃO INICIADOS"

    },

]

const criarCard  = (elemento) =>{

    const card = document.createElement('div')
    card.classList.add('card')
    card.innerHTML = 
    `

    <span class="card-descricao">
        ${elemento.quantidade}
    </span>

    <span class="card-preco">
        ${elemento.situacao}
    </span>

    `
    return card
}
const carregarProdutos = (produtos)=>{
    const container = document.querySelector('.card-container')
    const cards = produtos.map(criarCard)

    container.replaceChildren(...cards)
}
carregarProdutos(Status);
