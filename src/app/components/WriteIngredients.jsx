import React from "react";
import DetailedRecipe from "./DetailedRecipe";
import { getDataRecipeInformation } from "../data/apidata";
import ReadMoreSection from "./ReadMoreSection";
import PropTypes from "prop-types";
import propTypes from "prop-types";


export default class WriteIngredients extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            show: false,
            status: "Läs mer"
        }
    }



    render() {
        return (

            <div className="writeIngredient" key={this.props.recipes.recipesId}><h4>{this.props.recipes.name}</h4>

            {this.props.recipes.ingredients.map((ingredient) => (
                <li key={ingredient.id}>{ingredient.name}</li>
            ))}
            </div>


        )
    }
}
