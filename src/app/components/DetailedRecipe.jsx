import React from "react";
import { getDataRecipeInformation } from "../data/apidata";
import SavedRecipes from "../routes/savedrecipes";


export default class DetailedRecipe extends React.Component {
    constructor(props) {
        super(props)
        this.state = {
            recipe: [],
            done: false,
            savedWeeklyRecipes: [],
        }
    }

    saveRecipe = () => {
        console.log("Kör saveRecipe");
        if(localStorage.getItem("Saved weekly recipes")) {
            this.state.savedWeeklyRecipes = JSON.parse(localStorage.getItem("Saved weekly recipes"));
        }
    
        let check = this.state.savedWeeklyRecipes.some(
            (obj) => obj.id === this.props.recipeId
        );
    
        if (!check) {
            this.state.savedWeeklyRecipes.push(this.props.recipeId);
            localStorage.setItem("Saved weekly recipes",JSON.stringify(this.state.savedWeeklyRecipes));
            this.setState({savedWeeklyRecipes: []}, () => console.log(this.state.savedWeeklyRecipes))
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
                <>
                <h4>Ingredienser: </h4>
                {this.state.recipe.ingredients.map((ingredients) => (
                    <p>{ingredients.name}</p>
                ))}
                <button onClick={() => this.saveRecipe()}>Spara recept</button>
                </>
                }
                
            </div>


        )
    }
}