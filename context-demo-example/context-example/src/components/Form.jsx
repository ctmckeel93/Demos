import React, {useContext} from 'react'
import MyContext from '../contexts/MyContext'
const Form = (props) => {

    const submitHandler = (e) => {
        e.preventDefault(); 
        setName(e.target.value); 
    }

    const {name, setName, initialState} = useContext(MyContext)
    return (
        <div>
            <form onSubmit={submitHandler}>
                <label >Name:</label>
                <input type="text" onChange={(e) => setName(e.target.value)} value={name}/>
                <button>Submit</button>
            </form>

            User - Name: {initialState.name}, Age: {initialState.age}
        </div>
    )
}

export default Form;