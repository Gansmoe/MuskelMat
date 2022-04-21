import React from "react";


export default class SavedRecipes extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        const data = localStorage.getItem("Saved recipes");
        const savedRecipes = JSON.parse(data);

        console.log(savedRecipes);
        return (
            <main style={{ padding: "1rem 0" }}>
            <h2>Sparade Recept</h2>
                {(savedRecipes === null)
                    ?
                    <p>Här var det tomt</p>
                    :
                    <WriteRecipes recipes={savedRecipes}/>
                }
                

            </main>
        );
    }
}

class WriteRecipes extends React.Component {
    constructor(props) {
        super(props)
    }
    render() {
        return (
            this.props.recipes.map((recipe) => (
                <div key={recipe.number}><p>{recipe.name}</p></div>
            ))
        )

    }
}
