import React, { useState } from 'react'

const Tab = props => {
    const [content, setContent ] = useState("Welcome! Click on any tab to continue")

    const handleTab = e => {
        document.getElementById("fader").className = "fade-out"
        setTimeout(() => {

            switch(e.target.id){
                case "tab-1":
                    setContent("Welcome to the first tab, click the different tabs to see what content is available.")
                    document.getElementById("fader").className = "fade-in"
                    break 
                case "tab-2":
                    setContent("This is the second tab")
                    document.getElementById("fader").className = "fade-in"
                    break 
                case "tab-3":
                    setContent("This is the third tab")
                    document.getElementById("fader").className = "fade-in"
                    break
                default:
                    setContent("Welcome! Click on any tab to continue")
            }
        }, 900)
    }

    return (
        <div id="content">
            <button id="tab-1" className="btn btn-dark" onClick={handleTab}>Tab 1</button>
            <button id="tab-2" className="btn btn-dark" onClick={handleTab}>Tab 2</button>
            <button id="tab-3" className="btn btn-dark" onClick={handleTab}>Tab 3</button>

            <p id="fader" className="fade-out">{ content }</p>
        </div>
    )
}

export default Tab