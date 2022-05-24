import React from "react";
import PropTypes from "prop-types";


export default class WriteSavedRecipes extends React.Component {

    render() {
        return (
            this.props.recipes.map((recipe) => (
                <div key={recipe.number}><p>{recipe.name}</p></div>
            ))
        )
    }
}

WriteSavedRecipes.propTypes = {
    recipes: PropTypes.array
}