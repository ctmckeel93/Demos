import React, {useState} from 'react'

const Todo = props => {
    const {tasks} = props
    console.log(tasks)

    const checkHandler = (e) => {
        
    }
    return (
        <>
        <div className="container">
            {
                tasks ? tasks.map((item, i) => {
                    return (
                    <>
                    <div className="form-check list">
                        <input className="form-check-input" key={i} type="checkbox" onClick={checkHandler} checked={item.isChecked} value={item.value}/>
                        <label className="form-check-label" htmlFor="task">{item.value}</label>
                    </div>
                    <hr/>
                    </>
                    )

                }) : ""
            }
        </div>
        </>
    )
}

export default Todo