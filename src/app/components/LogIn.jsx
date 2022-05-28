import React from "react";
import UserContext from "../context/UserContext";

export default class LogIn extends React.Component {

    constructor(props) {
        super(props)
        this.state = {
            username: "",
            password: "",
            loggedin: false,
        }
    }

    static contextType = UserContext;

    handleChangeName = (event) => {
        this.setState({ username: event.target.value }, () => console.log(this.state.username));
    }

    handleChangePsw = (event) => {
        this.setState({ password: event.target.value }, () => console.log(this.state.password));
    }


    handleSubmit = () => {
        const {setUser} = this.context;
        if (this.state.username === "User" && this.state.password === "Password") {
            this.setState({ loggedin: true }, () => {
                localStorage.setItem("loggedin", JSON.stringify(this.state.loggedin))
                localStorage.setItem("isAdmin", JSON.stringify(false))
            });
            const newUser = { name: this.state.username, isAdmin: false};
            setUser(newUser);
        }
        else if (this.state.username === "Admin" && this.state.password === "Password") {
            this.setState({ loggedin: true}, () => {
                localStorage.setItem("loggedin", JSON.stringify(this.state.loggedin))
                localStorage.setItem("isAdmin", JSON.stringify(true))
            });
            const newUser = { name: this.state.username, isAdmin: true};
            setUser(newUser);
        }
        
    }

    render() {
        return (
            <div className="logIn">
                <form onSubmit={this.handleSubmit}>
                    <input type="text" placeholder="Användarnamn" value={this.state.username} onChange={this.handleChangeName}></input>
                    <input type="password" placeholder="Lösenord" value={this.state.password} onChange={this.handleChangePsw}></input>
                    <input type="submit" value="Logga in!" />
                </form>
            </div>
        )
    }
}