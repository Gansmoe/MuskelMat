import React from "react";
import DetailedRecipe from "./DetailedRecipe";
import { getDataRecipeInformation } from "../data/apidata";


export default class WriteRecipes extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            show: false,
        }
    }

    render() {
        return (

            <div className="writeRecipe" key={this.props.recipes.id}><h4>{this.props.recipes.title}</h4>
                <img src={this.props.recipes.image} alt=""></img>
                <p>Kalorier per portion: {this.props.recipes.calories}</p>
                <p>Protein per portion: {this.props.recipes.protein}</p>
                <button onClick={() => this.setState({ show: true })}>Läs mer</button>
                {(this.state.show === true)
                    ?
                    <>
                        <DetailedRecipe recipeId={this.props.recipes.id} />
                        <button onClick={() => this.setState({ show: false })}>Mindre</button>
                    </>
                    :
                    <p></p>
                }
            </div>


        )
    }
}