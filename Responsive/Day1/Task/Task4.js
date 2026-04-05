
document.addEventListener('DOMContentLoaded', () => {

    let table
    async function getData() {
        let url = 'https://dummyjson.com/products'
        try {
            let response = await fetch(url)
            if (!response.ok)
                throw new Error(`Response status: ${response.status}`);
            let result = await response.json();
            console.log(response.ok)
            console.log(response.status)
            console.log(result.products)
            fillTable(result.products)
        } catch (error) {
            console.log(error.message);
        }
    }



    function initTable() {
        table = document.createElement('table')
        let tr = document.createElement('tr')
        let th_id = document.createElement('th')
        let th_title = document.createElement('th')
        let th_description = document.createElement('th')
        th_id.innerText = 'Product ID'
        th_title.innerText = 'Product Title'
        th_description.innerText = 'Product Description'

        tr.appendChild(th_id)
        tr.appendChild(th_title)
        tr.appendChild(th_description)

        table.appendChild(tr)

        document.body.appendChild(table)

    }

    function fillTable(products)
    {
        for (let product of products) {
            let tr = document.createElement('tr')
            let id = product.id
            let title = product.title;
            let description = product.description;
            tr.innerHTML = `<td>${id}</td> <td>${title}</td> <td>${description}</td>`
            table.appendChild(tr)
            console.log(product.id)
            console.log(product.title)
        }
    }
    
    initTable()
    getData()
})