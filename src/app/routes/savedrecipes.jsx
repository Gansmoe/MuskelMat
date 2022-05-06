import React from "react";
import WriteSavedRecipes from "../components/WriteSavedRecipes.jsx";


export default class SavedRecipes extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            savedRecipes: [],
        };
    }



    deleteLocalStorage = () => {
        localStorage.removeItem("Saved recipes");
        this.setState({ savedRecipes: []});

    }

    componentDidMount() {
        this.setState({savedRecipes: JSON.parse(localStorage.getItem("Saved recipes"))})
    }
    render() {
        return (
            <main className="componentMain">
            <h2>Sparade Recept</h2>
                {(this.state.savedRecipes === null)
                    ?
                    <p>Här var det tomt</p>
                    :
                    <><WriteSavedRecipes recipes={this.state.savedRecipes}/>
                    <button onClick={this.deleteLocalStorage}>Töm sparade recept!</button></>
                }
                

            </main>
        );
    }
}

