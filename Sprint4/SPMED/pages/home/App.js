import { Link } from 'react-router-dom';

import "../../assets/css/flexbox.css";
import "../../assets/css/reset.css";
import "../../assets/css/style.css";
import logo1 from "../../assets/img/logo1.png";
import tf from '../../assets/img/telefone.png'
import end from '../../assets/img/pontm.png'
import hora from '../../assets/img/relogio.png'


function App() {
  return (
    <div>
      <div className="cabecalho">
      <div className="logosite">
      <Link to="/"><img src={logo1} alt="logo1"  className="logo1"/></Link>
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
            <div class="banner">

            </div>
            
        
      

      <div class="footer">
                <div class="fundologoB"> 
                    <div class="LogoB"></div>
                    <span class="nomelogo">SP MEDICAL GROUP</span>
                </div>   
                <div class="mapa"></div> 
            <div class="pontomapa2"></div>
            <span class="avP">AV. PAULISTA N1400 </span>
            <div class="telefone2"></div>
            <span class="numero2">TELEFONE (11) 2255 -7894 (11) 5522-9478</span>
            
        
                
            </div>
                  
      
     
    </div>
  );
}

export default App;
