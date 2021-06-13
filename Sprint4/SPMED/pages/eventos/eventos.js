import { React, Component } from 'react';
import axios from 'axios';
import logo1 from "../../assets/img/logo1.png";
import tf from '../../assets/img/telefone.png'
import end from '../../assets/img/pontm.png'
import hora from '../../assets/img/relogio.png'
import user from "../../assets/img/user.png"
import { Link } from 'react-router-dom';
import { parseJwt, usuarioAutenticado } from '../../services/auth';

export default class Eventos extends Component {
    constructor(props){
        super(props);
        this.state = {
            titulo : '',
            descricao : '',
            dataEvento : new Date(),
            acessoLivre : 0,
            idTipoEvento : 0,
            idInstituicao : 0,
            listaTiposEventos : [],
            listaInstituicoes : [],
            listaEventos : [],
            isLoading : false
        }
    };

    // Função responsável por fazer a requisição e trazer a lista de tipos eventos
    buscarTiposEventos = () => {
        // Faz a chamada para a API usando o axios
        axios('http://localhost:5000/api/tiposeventos', {
            headers : {
                'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
            }
        })
        .then(resposta => {
            // Caso a requisição retorne um status code 200
            if (resposta.status === 200) {
                // atualiza o state listaTiposEventos com os dados obtidos
                this.setState({ listaTiposEventos : resposta.data })
                // e mostra no console do navegador a lista de tipos eventos
                console.log(this.state.listaTiposEventos)
            }
        })
        // Caso ocorra algum erro, mostra no console do navegador
        .catch(erro => console.log(erro));
    };

    // Função responsável por fazer a requisição e trazer a lista de instituições
    buscarInstituicoes = () => {
        // Faz a chamada para a API usando o axios
        axios('http://localhost:5000/api/instituicoes', {
            headers : {
                'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
            }
        })
        .then(resposta => {
            // Caso a requisição retorne um status code 200
            if (resposta.status === 200) {
                // atualiza o state listaInstituicoes com os dados obtidos
                this.setState({ listaInstituicoes : resposta.data })
                // e mostra no console do navegador a lista de instituições
                console.log(this.state.listaInstituicoes)
            }
        })
        // Caso ocorra algum erro, mostra no console do navegador
        .catch(erro => console.log(erro));
    };

    // Função responsável por fazer a requisição e trazer a lista de eventos
    buscarEventos = () => {
        // Faz a chamada para a API usando o axios
        axios('http://localhost:5000/api/eventos', {
            headers : {
                'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
            }
        })
        .then(resposta => {
            // Caso a requisição retorne um status code 200
            if (resposta.status === 200) {
                // atualiza o state listaEventos com os dados obtidos
                this.setState({ listaEventos : resposta.data })
                // e mostra no console do navegador a lista de eventos
                console.log(this.state.listaEventos)
            }
        })
        // Caso ocorra algum erro, mostra no console do navegador
        .catch(erro => console.log(erro));
    };

    // Chama as funções assim que a tela é renderizada
    componentDidMount(){
        this.buscarTiposEventos();
        this.buscarInstituicoes();
        this.buscarEventos();
    };

    // Função que faz a chamada para a API para cadastrar um evento
    cadastrarEvento = (event) => {
        // Ignora o comportamento padrão do navegador
        event.preventDefault();
        // Define que a requisição está em andamento
        this.setState({ isLoading : true })

        // Define um evento que recebe os dados do state
        // É necessário converter o acessoLivre para int, para que o back-end consiga converter para bool ao cadastrar
        // Como o navegador envia o dado como string, não é possível converter para bool implicitamente
        let evento = {
            nomeEvento : this.state.titulo,
            descricao : this.state.descricao,
            dataEvento : new Date( this.state.dataEvento ),
            acessoLivre : parseInt( this.state.acessoLivre ),
            idTipoEvento : this.state.idTipoEvento,
            idInstituicao : this.state.idInstituicao
        };

        // Define a URL e o corpo da requisição
        axios.post('http://localhost:5000/api/eventos', evento, {
            headers : {
                'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
            }
        })

        // Verifica o retorno da requisição
        .then(resposta => {
            // Caso retorne status code 200,
            if (resposta.status === 201) {
                // exibe no console do navegador a mensagem abaixo
                console.log('Evento cadastrado!')
                // e define que a requisição terminou
                this.setState({ isLoading : false })
            }
        })

        // Caso haja algum erro, exibe este erro no console do navegador
        .catch(erro => {
            console.log(erro);
            // e define que a requisição terminou
            this.setState({ isLoading : false });
        })

        // Então, atualiza a lista de Eventos
        // sem o usuário precisar executar outra ação
        .then(this.buscarEventos)
    };

    // Função genérica que atualiza o state de acordo com o input
    // pode ser reutilizada em vários inputs diferentes
    atualizaStateCampo = (campo) => {
        this.setState({ [campo.target.name] : campo.target.value })
    };

    render(){
        return(
            <div>
          
           <body>
           <div className="cabecalho">
             <div className="logosite">
               <img src={logo1} className="logo1" alt="teste"></img>
                 <span class="nomesp">SP <br></br> MEDICAL <br></br> GROUP<br></br></span>
             </div>
           </div>
           
                 <div className="contatos">
                   <img src={tf} className="tf" alt="telefone"></img>
                     <span className="telefone1">TELEFONE (11) 2255 -7894</span>
                     <img src={end} className="end" alt="teste"></img>
                     <span className="avP1">AV. PAULISTA N1401 </span>
                     <img src={hora} className="hora" alt="teste"></img>
                     <span className="horario">SEG - SEX 9H até 17H SAB 10H até 17H</span>
                 </div>
       
                 <div class="menu">
                    <Link className="home1" to="/">HOME</Link>
                    <Link className="login" to="login" >Login</Link>
                   </div>
                   
                   <div class="menuEsquerda">
                         <img className="user" src={user} alt=""></img>
                 </div>
           </body>
          </div>
        );
    };
};