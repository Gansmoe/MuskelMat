import React from "react";


let savedRecipes = [];

export default class Contact extends React.Component {
    

    render() {
        return (
            <div className="recipeBody">
            <main style={{ padding: "1rem" }}>
                <h2>{props.recipe.name}</h2>
                <p>
                    Totalt antal kalorier: {props.recipe.kcal}
                </p>
                <p>
                    Gram protein: {props.recipe.protein}
                </p>
                <h4>Instruktioner</h4>
                <p>{props.recipe.instructions}</p>
                <button onClick={ () => saveRecipe(props.recipe)}>Spara receptet</button>
            </main>
            </div>
        );
    }
}



function saveRecipe(recipe) {

    if(localStorage.getItem("Saved recipes")) {
        savedRecipes = JSON.parse(localStorage.getItem("Saved recipes"));
    }

    let check = savedRecipes.some(
        (obj) => obj.number === recipe.number
    );

    if (!check) {
        savedRecipes.push(recipe);
        localStorage.setItem("Saved recipes",JSON.stringify(savedRecipes));
        savedRecipes = [];
    }

}