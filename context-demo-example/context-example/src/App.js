import logo from './logo.svg';
import React, {useContext} from 'react';
import Wrapper from './components/Wrapper'
import FormWrapper from './components/FormWrapper'
import Navbar from './components/Navbar'
import './App.css';

function App() {

  return (
    <div className="App">
      <Wrapper>
        <FormWrapper/>
        <Navbar />
      </Wrapper>
    </div>
  );
}

export default App;
