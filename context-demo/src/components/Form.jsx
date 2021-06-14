import React, { useContext } from 'react'
import MyContext from '../context/MyContext';

const Form = props => {

    const {name, setName} = useContext(MyContext)

    const onSubmitHandler = (e) => {
        e.preventDefault();
        setName(e.target.value)
    }


    return(
    <form onSubmit={onSubmitHandler}>
        <div>
            <label>Your name:</label>
            <input type="text" name="name" onChange={e => setName(e.target.value)} value={name} />
        </div>
        <button>Submit</button>
    </form>
    )
}

export default Form