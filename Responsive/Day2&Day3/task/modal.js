const form = document.getElementById('form');

form.addEventListener('input', () => {
    if (form.checkValidity()) {
        document.getElementById('h1_form_submit').textContent = '';
        document.getElementById('h1_form_submit').classList.remove('text-danger');
    }
    else 
    {
        document.getElementById('h1_form_submit').textContent = 'Please fill out the form correctly.';
        document.getElementById('h1_form_submit').classList.add('text-danger');
    }
});


form.addEventListener('submit', (e) => {
    e.preventDefault();
    console.log(form.checkValidity());
    if (form.checkValidity()) {
        form.reset();
        document.getElementById('h1_form_submit').textContent = 'Form submitted successfully!';
        document.getElementById('h1_form_submit').classList.remove('text-danger');
        document.getElementById('h1_form_submit').classList.add('text-success');
    }

    
});

