import './App.css';
import MyContext from './context/MyContext'
import Test from './components/Form';
import React, { useState } from 'react'
import FormWrapper from './components/FormWrapper';
import Wrapper from './components/Wrapper';
import Navbar from './components/Navbar';


function App() {
  return (
    <>
      <div className="App">
          <Wrapper>
            <Navbar />
            <FormWrapper />
          </Wrapper>
      </div>
    </>
  );
}

export default App;
