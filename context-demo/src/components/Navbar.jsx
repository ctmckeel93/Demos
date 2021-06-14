import React, { useContext } from 'react'
import MyContext from '../context/MyContext'

const Navbar = props => {
    const {name} = useContext(MyContext)
    return(
        <nav>
            Hello {name}
        </nav>
    )
}

export default Navbar