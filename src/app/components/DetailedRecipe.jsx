import React from "react";
import { getDataRecipeInformation } from "../data/apidata";


export default class DetailedRecipe extends React.Component {
    constructor(props) {
        super(props)
        this.state = {
            recipe: [],
            done: false,
        }
    }

    componentDidMount(){
        this.recipeInfo();
    }

    recipeInfo = async() =>{
        const data = await getDataRecipeInformation(this.props.recipeId);
        this.setState({recipe: data}, async () => this.setState({done: true}));
    }

    render() {
        return (
            <div className="detailedRecipe" key={this.props.recipeId}>
                {(this.state.done === false)
                ?
                <h4>Laddar...</h4>
                :
                this.state.recipe.instructions
                }
                


            </div>


        )
    }
}