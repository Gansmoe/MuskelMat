import React from "react";


export default class WriteRecipes extends React.Component {
    
    constructor(props) {
        super(props);
        console.log(props);
    }

    render() {
        return (
            this.props.recipes.map((recipe) => (
                <div key={recipe.number}><p>{recipe.name}</p></div>
            ))
        )
    }
}