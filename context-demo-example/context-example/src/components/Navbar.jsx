import React, {useContext} from 'react'; 
import MyContext from '../contexts/MyContext';
const Navbar = (props) => {
    const {name} = useContext(MyContext)
    return (
        <nav>
            Hello, {name}
        </nav>
    )
}

export default Navbar;