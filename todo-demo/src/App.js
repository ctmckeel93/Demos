import './App.css';
import Form from './components/Form';
import Todo from './components/Todo';
import React, { useState, useEffect } from 'react'


function App() {

  const [tasks, setTasks] = useState([])

  useEffect(() => {
    setTasks(JSON.parse(localStorage.getItem("tasks")))
  }, [])

  const addTask = (task) => {
    setTasks([...tasks, task]);
    addToLocalStorage(tasks);
  }

  const addToLocalStorage = (savedTasks) => {
    localStorage.setItem("tasks", JSON.stringify(savedTasks));
  }  

  return (
    <>
    <div className="App">
      <Form addTask={addTask} />
      <Todo tasks={tasks} />
    </div>
    
    </>
  );
}

export default App;
