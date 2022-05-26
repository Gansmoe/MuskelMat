import React from "react";
import { getDataRecipeInformation } from "../data/apidata";
import SavedRecipes from "../routes/savedrecipes";
import UserContext, { UserConsumer } from "../context/UserContext.js";
import PropTypes from "prop-types";


export default class DetailedRecipe extends React.Component {
    constructor(props) {
        super(props)
        this.state = {
            recipe: [],
            done: false,
            savedWeeklyRecipes: [],
            error: null,
        }
    }

    static contextType = UserContext;

    saveRecipe = () => {
        console.log("Kör saveRecipe");
        if (localStorage.getItem("Saved weekly recipes")) {
            this.state.savedWeeklyRecipes = JSON.parse(localStorage.getItem("Saved weekly recipes"));
        }

        let check = this.state.savedWeeklyRecipes.some(
            (obj) => obj.id === this.props.recipeId
        );

        if (!check) {
            this.state.savedWeeklyRecipes.push(this.props.recipeId);
            localStorage.setItem("Saved weekly recipes", JSON.stringify(this.state.savedWeeklyRecipes));
            this.setState({ savedWeeklyRecipes: [] }, () => console.log(this.state.savedWeeklyRecipes))
        }

    }

    componentDidMount() {
        const user = this.context;
        console.log(user);
        this.recipeInfo();
    }

    recipeInfo = async () => {
        const [data, err] = await getDataRecipeInformation(this.props.recipeId);
        console.log(data);
        this.setState({ recipe: data, error: err }, async () => this.setState({ done: true }));
    }

    render() {
        console.log(this.state);
        return (
            <div className="detailedRecipe" key={this.props.recipeId}>
                <div className="dropDown">
                    {(this.state.done == false)
                    ?
                    <h4>Laddar...</h4>
                    :
                    <>
                        {(this.state.error === null)
                            ?
                            <>
                                <h4>Ingredienser: </h4>
                                {this.state.recipe.ingredients.map((ingredients) => (
                                    <p key={ingredients.id}>{ingredients.name}</p>
                                ))}
                                {(this.context.user.isAdmin === true)
                                ?
                                <button>Redigera</button>
                                :
                                <p></p>
                                }
                            </>
                            :
                            <p>Någonting gick fel!</p>
                        }
                    </>
                    }
                </div>
            </div>


        )
    }
}

DetailedRecipe.propTypes = {
    recipeId: PropTypes.number
}