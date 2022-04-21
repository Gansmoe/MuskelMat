import { useParams } from "react-router-dom";
import { getRecipe } from "../data/mockdata.js";

let savedRecipes = [];

export default function Recipe() {
    let params = useParams();
    let recipe = getRecipe(parseInt(params.recipeId, 10));

    

    return (
        <main style={{ padding: "1rem" }}>
            <h2>{recipe.name}</h2>
            <p>
                Totalt antal kalorier: {recipe.kcal}
            </p>
            <p>
                Gram protein: {recipe.protein}
            </p>
            <h4>Instruktioner</h4>
            <p>{recipe.instructions}</p>
            <button onClick={ () => saveRecipe(recipe)}>Spara recept!</button>
        </main>
    );
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
        console.log(savedRecipes);
    }

}