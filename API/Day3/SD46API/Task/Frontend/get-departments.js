async function loadDepartments() {
    const response = await fetch("http://localhost:5008/api/department/alldepts");

    const data = await response.json();
    console.log(data.data);
    

    const table = document.querySelector("#deptTable tbody");
    table.innerHTML = "";

    data.data.forEach(dept => {
        const row = `
                    <tr>
                        <td>${dept.id}</td>
                        <td>${dept.name}</td>
                        <td>${dept.phoneNumber}</td>
                        <td>${dept.location}</td>
                        <td>${dept.manager}</td>
                    </tr>
                `;
        table.innerHTML += row;
    });
}