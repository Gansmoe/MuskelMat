import React from "react";
import DetailedRecipe from "./DetailedRecipe";
import { getDataRecipeInformation } from "../data/apidata";
import ReadMoreButton from "./ReadMoreButton";


export default class WriteRecipes extends React.Component {
    constructor(props) {
        super(props);
        this.eventHandler = this.eventHandler.bind(this);
        this.state = {
            show: false,
            status: "Läs mer"
        }
    }

    eventHandler(){
        console.log("Hej från handler");
        if(this.state.show === false){

            this.setState({ status: "Mindre", show: true}, () => console.log(status));
        }
        else{
            this.setState({ status: "Läs mer", show: false});
        }
    }

    render() {
        return (

            <div className="writeRecipe" key={this.props.recipes.recipesId}><h4>{this.props.recipes.name}</h4>
                <img src={this.props.recipes.image} alt=""></img>
                <p>Kalorier per portion: {this.props.recipes.kcal}</p>
                <p>Protein per portion: {this.props.recipes.protein}</p>
                {/* <button onClick={() => this.setState({ show: true })}>Läs mer</button> */}
                
                {(this.state.show === true)
                    ?
                    <>
                        <DetailedRecipe recipeId={this.props.recipes.recipesId} />
                    </>
                    :
                    <p></p>
                }
                <ReadMoreButton status={this.state.status} onClick={this.eventHandler} />
            </div>


        )
    }
}