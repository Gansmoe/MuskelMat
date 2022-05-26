import React from "react";
import DetailedRecipe from "./DetailedRecipe";
import { getDataRecipeInformation } from "../data/apidata";
import ReadMoreSection from "./ReadMoreSection";
import PropTypes from "prop-types";
import propTypes from "prop-types";


export default class WriteRecipes extends React.Component {
    constructor(props) {
        super(props);
        this.eventHandler = this.eventHandler.bind(this);
        this.state = {
            show: false,
            status: "Läs mer"
        }
    }



    render() {
        return (

            <div className="writeRecipe" key={this.props.recipes.recipesId}><h4>{this.props.recipes.name}</h4>
                <img src={this.props.recipes.image} alt=""></img>
                <p>Kalorier per portion: {this.props.recipes.kcal}</p>
                <p>Protein per portion: {this.props.recipes.protein}</p>
                <ReadMoreSection>
                    <DetailedRecipe recipeId={this.props.recipes.recipesId}/>
                </ReadMoreSection>
            </div>


        )
    }
}

WriteRecipes.propTypes = {
    recipes: PropTypes.object
}