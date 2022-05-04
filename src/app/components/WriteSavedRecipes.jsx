import React from "react";


export default class WriteRecipes extends React.Component {

    render() {
        return (
            this.props.recipes.map((recipe) => (
                <div key={recipe.number}><p>{recipe.name}</p></div>
            ))
        )
    }
}