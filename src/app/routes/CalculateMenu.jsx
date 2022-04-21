import React from "react";


export default class CalculateMenu extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            kcalInput: 0,
            proteinInput: 0,
        }
    }

    componentDidUpdate() {
        console.log(this.state.kcalInput);
        console.log(this.state.proteinInput);
    }
    onChangeKcal = (e) => {
        this.setState({kcalInput: e.taget.value})
    }

    onChangeProtein = (e) => {
        this.setState({proteinInput: e.taget.value})
    }
    
    render() {
        return (
            <main style={{ padding: "1rem 0" }}>
                <h2>Här fyller du i ditt kalori- och proteinbehov, sedan finns veckomatsedeln under "Veckomatsedel"</h2>
                <input type="text" placeholder="Kalorier/dag" onChange={(e) => this.setState({kcalInput: e.target.value})}></input>
                <input type="text" placeholder="Protein/dag" onChange={(e) => this.setState({proteinInput: e.target.value})}></input>
                <button>Kör!</button>
            </main>
        );
    }
}