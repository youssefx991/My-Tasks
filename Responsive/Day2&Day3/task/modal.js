const form = document.getElementById('form');

form.addEventListener('input', () => {
    if (form.checkValidity()) {
        document.getElementById('h1_form_submit').textContent = '';
    }
    else 
    {
        document.getElementById('h1_form_submit').textContent = 'Please fill out the form correctly.';
    }
});


form.addEventListener('submit', (e) => {
    e.preventDefault();
    console.log(form.checkValidity());
    if (form.checkValidity()) {
        form.reset();
        document.getElementById('h1_form_submit').textContent = 'Form submitted successfully!';
    }

    
});

