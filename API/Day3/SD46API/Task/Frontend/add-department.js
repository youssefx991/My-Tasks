document.getElementById("deptForm").addEventListener("submit", async function (e) {
    e.preventDefault();

    const dept = {
        name: document.getElementById("name").value,
        location: document.getElementById("location").value,
        phoneNumber: document.getElementById("phone").value,
        manager: document.getElementById("manager").value
    };

    const response = await fetch("http://localhost:5008/api/department", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(dept)
    });

    if (response.ok) {
        document.getElementById("msg").innerText = "Department added successfully ✅";
    } else {
        document.getElementById("msg").innerText = "Error adding department ❌";
    }
});