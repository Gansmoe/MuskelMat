import React from "react";

export default class LogIn extends React.Component {

    constructor(props) {
        super(props)
        this.state = {
            username: "",
            password: "",
            loggedin: false,
        }
    }

    handleChangeName = (event) => {
        this.setState({ username: event.target.value }, () => console.log(this.state.username));
    }

    handleChangePsw = (event) => {
        this.setState({ password: event.target.value }, () => console.log(this.state.password));
    }


    handleSubmit = () => {
        if (this.state.username === "User" && this.state.password === "Password") {
            this.setState({ loggedin: true }, () => localStorage.setItem("loggedin", JSON.stringify(this.state.loggedin)))
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