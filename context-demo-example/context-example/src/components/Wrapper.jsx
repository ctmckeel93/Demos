import React, { useState } from 'react'
import MyContext from '../contexts/MyContext';

const Wrapper = ({children}) => {
    const [name, setName] = useState("");
    const initialState = {
        name: "Corey Mckeel",
        age: 27, 
    }

    return (
        <MyContext.Provider value={{name, setName, initialState}}>
            {children}
        </MyContext.Provider>
    )
}

export default Wrapper;