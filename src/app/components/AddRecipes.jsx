import React from "react";
import PropTypes from "prop-types";
import { addRecipe } from "../data/apidata";


export default class AddRecipes extends React.Component {
    constructor(props){
        super(props)
        this.state = {
            name: "",
            kcal: 0,
            protein: 0,
            mealType: "",
            ingredients: [],
            error: null,
        }
    }

    handleSubmit = async (event) => {
        console.log(this.state.name, this.state.kcal, this.state.protein, this.state.mealType);
        const [addedRecipe, err] = await addRecipe(this.state.name, this.state.kcal, this.state.protein, this.state.mealType);
        console.log({ addedRecipe });
        if(addedRecipe != null){
            alert("Receptet tillagt")
        }
        /* this.setState({ datarecept: updatedRecipes, updatedRecipesDone: true }); */
        this.setState({ error: err });

        event.preventDefault();
    }

    handleChangeName = (event) => {
        this.setState({ name: event.target.value });
    }
    handleChangeKcal = (event) => {
        this.setState({ kcal: event.target.value });
    }
    handleChangeProtein = (event) => {
        this.setState({ protein: event.target.value });
    }
    handleChangeMealType = (event) => {
        this.setState({ mealType: event.target.value });
    }

    render() {
        return (
            <div>
                <form onSubmit={this.handleSubmit}>
                    <input type="text" placeholder="Namn på recept" value={this.state.name} onChange={this.handleChangeName}></input>
                    <input type="number" placeholder="Kalorier per portion" value={this.state.kcal} onChange={this.handleChangeKcal}></input>
                    <input type="number" placeholder="Protein per portion" value={this.state.protein} onChange={this.handleChangeProtein}></input>
                    <input type="text" placeholder="Vilken sorts måltid" value={this.state.mealType} onChange={this.handleChangeMealType}></input>
                    <input type="submit" value="Lägg till" />
                </form>
            </div>
        )
    }
}

AddRecipes.propTypes = {

}