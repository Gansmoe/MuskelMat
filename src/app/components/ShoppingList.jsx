import React from "react";
import { getRecipeById } from "../data/apidata.js";
import WriteIngredients from "./WriteIngredients.jsx";

export default class ShoppingList extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            savedWeeklyRecipes: [],
            allSavedrecipes: [],
            error: null,
        }
    }

    componentDidMount() {
        this.setState({ savedWeeklyRecipes: JSON.parse(localStorage.getItem("Saved weekly recipes")) }, () => this.getSavedRecipes())

    }

    getSavedRecipes = async () => {
        let tempRecipes = [];
        const savedRecipes = JSON.parse(localStorage.getItem("Saved weekly recipes"));
        console.log(savedRecipes);

        for (let i = 0; i < savedRecipes.length; i++) {

            const [data, err] = await getRecipeById(savedRecipes[i]);
            tempRecipes.push(data);

            if (err) {
                this.setState({ error: err });
            }
        }

        this.setState({ allSavedrecipes: tempRecipes });
    }

    render() {
        return (
            <main className="componentMain">
                <h2>Inköpslista</h2>
                {(this.state.savedWeeklyRecipes === null)
                    ?
                    <p>Här var det tomt! Gå till <b>Få din Veckomatsedel</b> för att fylla på här!</p>
                    :
                    <>
                        {this.state.allSavedrecipes.map((recipe) => (
                            <WriteIngredients key={recipe.recipesId} recipes={recipe} />
                        ))
                        }</>}

            </main>
        );
    }
}