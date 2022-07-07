document.getElementById('formulario')
        .addEventListener('submit',function (form) {
            form.preventDefault();

            var termos = document.querySelector('#aceito-termos');

            if(termos.checked) {

                document.getElementById('tabela-dados').classList.remove('d-none');

                document.getElementById('nome-tabela').innerText = document.getElementById('nome').value + " " + document.getElementById('sobrenome').value;
                document.getElementById('email-tabela').innerText = document.getElementById('email').value;
                document.getElementById('login-tabela').innerText = document.getElementById('login').value;
                document.getElementById('senha-tabela').innerText = document.getElementById('senha').value;
                document.getElementById('cep-tabela').innerText = document.getElementById('cep').value;
                document.getElementById('endereco-tabela').innerText = document.getElementById('endereco').value;
                document.getElementById('complemento-tabela').innerText = document.getElementById('complemento').value;
                document.getElementById('bairro-tabela').innerText = document.getElementById('bairro').value;
                document.getElementById('cidade-tabela').innerText = document.getElementById('cidade').value;
                document.getElementById('estado-tabela').innerText = document.getElementById('estado').value;
                document.getElementById('github-tabela').innerText = "https://github.com/" + document.getElementById('github').value;
                document.getElementById('academia-tabela').innerText = document.getElementById('academia').value;
                document.getElementById('professor-tabela').innerText = document.getElementById('professor').value;
                document.getElementById('termos-legais-tabela').innerText = "Termos legais aceitos.";

                var receberEmails = document.querySelector('#receber-email');

                if(receberEmails.checked) {
                    document.getElementById('receber-email-tabela').innerText = "Aceito receber os e-mails.";
                }
                else {
                    document.getElementById('receber-email-tabela').innerText = "Não aceito receber os e-mails.";
                }
                this.reset();
            }
            else{
                alert("Os Termos Legais não foram aceitos!");
            }          
        });

document.getElementById('termos-legais').addEventListener('scroll', habilitarAceite);

document.getElementById('nome').addEventListener('keyup', gerarLogin);

document.getElementById('sobrenome').addEventListener('keyup', gerarLogin);

function gerarLogin() {
    const nome = document.getElementById('nome').value;
    const sobrenome = document.getElementById('sobrenome').value;
    const validaNome = nome.replace(/[^a-zA-Z]/g, '');
    const validaSobrenome = sobrenome.replace(/[^a-zA-Z]/g, '');
    const login = validaNome + "." + validaSobrenome;
    document.getElementById('login').value = login.toLowerCase();
}

function habilitarAceite() {
    var termosLegais = document.getElementById('termos-legais');
    if ((termosLegais.scrollTop + termosLegais.offsetHeight) >= termosLegais.scrollHeight){
        document.getElementById('aceito-termos').removeAttribute('disabled');
    }  
}

function limpa_formulário_cep() {
    //Limpa valores do formulário de cep.
    document.getElementById('endereco').value=("");
    document.getElementById('bairro').value=("");
    document.getElementById('cidade').value=("");
    document.getElementById('estado').value=("")
}

function meu_callback(conteudo) {
if (!("erro" in conteudo)) {
    //Atualiza os campos com os valores.
    document.getElementById('endereco').value=(conteudo.logradouro);
    document.getElementById('bairro').value=(conteudo.bairro);
    document.getElementById('cidade').value=(conteudo.localidade);
    document.getElementById('estado').value=(conteudo.uf);
} //end if.
else {
    //CEP não Encontrado.
    limpa_formulário_cep();
    alert("CEP não encontrado.");
}
}

function pesquisacep(valor) {

//Nova variável "cep" somente com dígitos.
var cep = valor.replace(/\D/g, '');

//Verifica se campo cep possui valor informado.
if (cep != "") {

    //Expressão regular para validar o CEP.
    var validacep = /^[0-9]{8}$/;

    //Valida o formato do CEP.
    if(validacep.test(cep)) {

        //Preenche os campos com "..." enquanto consulta webservice.
        document.getElementById('endereco').value="...";
        document.getElementById('bairro').value="...";
        document.getElementById('cidade').value="...";
        document.getElementById('estado').value="...";

        //Cria um elemento javascript.
        var script = document.createElement('script');

        //Sincroniza com o callback.
        script.src = 'https://viacep.com.br/ws/'+ cep + '/json/?callback=meu_callback';

        //Insere script no documento e carrega o conteúdo.
        document.body.appendChild(script);

    } //end if.
    else {
        //cep é inválido.
        limpa_formulário_cep();
        alert("Formato de CEP inválido.");
    }
} //end if.
else {
    //cep sem valor, limpa formulário.
    limpa_formulário_cep();
}
};

let mybutton = document.getElementById("btn-back-to-top");

// When the user scrolls down 20px from the top of the document, show the button
window.onscroll = function () {
  scrollFunction();
};

function scrollFunction() {
  if (
    document.body.scrollTop > 20 ||
    document.documentElement.scrollTop > 20
  ) {
    mybutton.style.display = "block";
  } else {
    mybutton.style.display = "none";
  }
}
// When the user clicks on the button, scroll to the top of the document
mybutton.addEventListener("click", backToTop);

function backToTop() {
  document.body.scrollTop = 0;
  document.documentElement.scrollTop = 0;
}