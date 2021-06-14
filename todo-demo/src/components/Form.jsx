import React, { useState } from 'react'

const Form = props => {
    const [newTask, setNewTask] = useState({
        value: "",
        isChecked: false,
        isComplete: false,
    })

    const taskHandler = e => {
        setNewTask({
            ...newTask,
            [e.target.name]: e.target.value
        });
    }

    const submitHandler = (e) => {
        e.preventDefault();
        let task = newTask
        props.addTask(task)
        setNewTask({
            value: "",
        isChecked: false,
        isComplete: false,
        })
    }



    return (
        <>
        <h1 className="text-center mt-3">What do you want to do today?</h1>
        <div className="container">
            <form onSubmit={ submitHandler }>
                <div className="form-group col-sm">
                    <label htmlFor="value">Enter a task:</label>
                    <input type="text" name="value" onChange={taskHandler} value={newTask.value} className="form-control" />
                </div>
                <input type="submit" value="Add Task" className="btn mt-3 btn-success"  />
            </form>
        </div>
        </>
    )
}

export default Form