import React from "react";


export default class SavedRecipes extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            savedRecipes: JSON.parse(localStorage.getItem("Saved recipes")),
            foo: false,
        };
    }



    deleteLocalStorage = () => {
        localStorage.removeItem("Saved recipes");
        this.setState({ savedRecipes: []})
        this.state.savedRecipes = [];

    }

    render() {
        return (
            <main style={{ padding: "1rem 0" }}>
            <h2>Sparade Recept</h2>
                {(this.state.savedRecipes === null)
                    ?
                    <p>Här var det tomt</p>
                    :
                    <><WriteRecipes recipes={this.state.savedRecipes} />
                    <button onClick={this.deleteLocalStorage}>Töm sparade recept!</button></>
                }
                

            </main>
        );
    }
}

function WriteRecipes(props) {

        return (
            props.recipes.map((recipe) => (
                <div key={recipe.number}><p>{recipe.name}</p></div>
            ))
        )
}
