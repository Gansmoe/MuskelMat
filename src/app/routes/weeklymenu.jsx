import React from "react";
import WriteRecipes from "../components/WriteRecipes.jsx";

export default class WeeklyMenu extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            savedWeeklyRecipes: [],
        }
    }

        componentDidMount() {
            this.setState({savedWeeklyRecipes: JSON.parse(localStorage.getItem("Saved weekly recipes"))})
        }

    render() {
        return (
            <main className="componentMain">
                <h2>Veckomatsedel (Ej färdig, kommer i v4.0)</h2>
                {(this.state.savedWeeklyRecipes === null)
                    ?
                    <p>Här var det tomt! Gå till <b>Få din Veckomatsedel</b> för att fylla på här!</p>
                    :
                    <><WriteRecipes recipes={this.state.savedWeeklyRecipes}/></>}
            </main>
        );
    }
}
