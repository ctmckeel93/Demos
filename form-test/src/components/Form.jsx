import React, { useState } from 'react'

const Form = props => {
    const [form, setForm] = useState({
        fname: "",
        lname: "",
        email: "",
        password:"",
        password_confirm: "",
        submitted: false
    })
    const [errors, setErrors] = useState({
        fnameError: "",
        lnameError: "",
        emailError: "",
        passwordError: "",
        password_confirmError: ""
    }) 
    const onSubmitHandler = e => {
        e.preventDefault();
        setForm({submitted:true})

    }

    const onChangeHandler = e => {
        const checkAll = (e) => {
            if (e.target.value.length > 0 && e.target.value.length < 3){

                setErrors({...errors, [e.target.name + "Error"]: "All fields are required and must contain at least 3 characters" })
            }
            else setErrors({...errors, [e.target.name + "Error"]: ""})
        }
        setForm({...form, [e.target.name]:e.target.value })
        switch(e.target.name){
            case "fname":
                checkAll(e)
                break 
            case "lname":
                checkAll(e)
                break 
            case "email":
                checkAll(e)
                break 
            case "password":
                checkAll(e)
                if (e.target.value.length < 8 && e.target.value.length > 0){
                    setErrors({...errors, passwordError: "Password must be at least 8 characters"  })
                }
                break 
            case "password_confirm":
                if (e.target.value !== form.password && e.target.value.length > 0){
                    setErrors({...errors, password_confirmError: "Passwords must match"})
                }
                else {
                    setErrors({...errors, password_confirmError: ""})
                }
                break 


        }

    }

    const formMessage = () => {
        if (form.submitted){
            return "Form has been submitted"
        }
        else {
            return "Please fill out and submit the form"
        }
    } 
    return (
        <>
        <form className="p-4" onSubmit={onSubmitHandler} >
            <h3>{formMessage()}</h3>
            <div className="form-group">
                <label htmlFor="fname">First Name:</label>
                <input className="form-control" onChange={onChangeHandler} type="text" value={form.fname} name="fname" />
                <p className="text-danger">{errors.fnameError}</p>
            </div>
            <div className="form-group">
                <label htmlFor="lname">Last Name:</label>
                <input type="text" onChange={onChangeHandler} name="lname" className="form-control" />
                <p className="text-danger">{errors.lnameError}</p>
            </div>
            <div className="form-group">
                <label htmlFor="email">Email</label>
                <input type="text" onChange={onChangeHandler} name="email" className="form-control" />
                <p className="text-danger">{errors.emailError}</p>
            </div>
            <div className="form-group">
                <label htmlFor="password">Password:</label>
                <input type="text" onChange={onChangeHandler} name="password" className="form-control" />
                <p className="text-danger">{errors.passwordError}</p>
            </div>
            <div className="form-group">
                <label htmlFor="password_confirm">Confirm Password:</label>
                <input type="text" onChange={onChangeHandler} name="password_confirm" className="form-control" />
                <p className="text-danger">{errors.password_confirmError}</p>
            </div>
            <div>
                <input type="submit"  className="btn btn-dark" value="Submit" />
            </div>
        </form>

        <div className="text-center">
           <p>First Name: {form.fname}</p>
            <p>Last Name: {form.lname}</p>
            <p>Email: {form.email}</p>
            <p>Password: {form.password}</p>
        </div>
        </>


    )
}

export default Form