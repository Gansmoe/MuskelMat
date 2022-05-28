import React from "react";
import WriteRecipes from "../components/WriteRecipes.jsx";
import { getRecipeById } from "../data/apidata.js";

export default class WeeklyMenu extends React.Component {
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
                <h2>Veckomatsedel</h2>
                {(this.state.savedWeeklyRecipes === null)
                    ?
                    <p>Här var det tomt! Gå till <b>Få din Veckomatsedel</b> för att fylla på här!</p>
                    :
                    <>
                        {this.state.allSavedrecipes.map((recipe) => (
                            <WriteRecipes key={recipe.recipesId} recipes={recipe} />
                        ))
                        }
                    </>
                }

            </main>
        );
    }
}


