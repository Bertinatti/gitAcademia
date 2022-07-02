document.getElementById('formulario')
        .addEventListener('submit',function (form){
            form.preventDefault();
            console.log('Submetido')
        });

document.getElementById('nome').addEventListener('keyup', gerarLogin);
document.getElementById('sobrenome').addEventListener('keyup', gerarLogin);

function gerarLogin(){
    const nome = document.getElementById('nome').value;
    const sobrenome = document.getElementById('sobrenome').value;
    const login = nome + "." + sobrenome;
    document.getElementById('login').value = login.toLowerCase();
}

function validarDados()
{
    const validacao = document.getElementById('formulario').addEventListener('submit', ValidityState);
    console.log("Validou");
}