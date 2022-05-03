import React from "react";


export default class WriteRecipes extends React.Component {


    render() {
        return (
            this.props.recipes.map((recipe) => (
                <div key={recipe.id}><h4>{recipe.title}</h4>
                <img src={recipe.image} alt=""></img>
                <p>Kalorier per portion: {recipe.calories}</p>
                <p>Protein per portion: {recipe.protein}</p></div>
                
            ))
        )
    }
}