
import React from 'react';
import './App.css';


function DataFormatada(props){
  return <h2>Horário Atual: {props.date.toLocaleTimeString()}</h2>
};

class Clock extends React.Component{
  constructor(props){
    super(props);
    this.state = {
      date : new Date()
    };
  }

 
  componentDidMount(){
    this.timerID = setInterval(() => {
      this.thick()
    }, 1000);
    console.log("Eu sou o relogio " + this.timerID);
  }
  
  componentWillUnmount(){
    clearInterval(this.timerID);
  }

thick(){
  this.setState({
    date: new Date()
  });
}
pause = () =>{
  clearInterval(this.timerID)
  console.log(`O relogio ${this.timerID} foi pausado`)
}

recomecar = () =>{
  this.timerID = setInterval(() => {
    this.thick()
  }, 1000);

  console.log("relogio retomado!")
  console.log(`agora sou relogio ${this.timerID}`)
  
}

render(){
  return(
    <div id= "render">
      <h1 style={{color : "white", fontStyle: "Italic", fontFamily: "cursive"}} onClick={this.recomecar}>Relógio</h1>
      <DataFormatada date={this.state.date} />
      <button  style={{color : "white", height: '25px', fontWeight: '600', margin:"20px", backgroundColor: "#008000", border: "none" , fontFamily: "cursive"}} onClick={this.pause}>Pausar</button>
      <button style={{color : "white", height: '25px', fontWeight: '600', margin:"20px", backgroundColor: "#B22222",  border: "none" , fontFamily: "cursive"}} onClick={this.recomecar}>Recomeçar</button>
    </div>
  )
}
}
function App() {
  return (
    <div className="App">
      <header className="App-header">
        <Clock />
        <Clock />
      </header>
    </div>
  );
}

export default App;
