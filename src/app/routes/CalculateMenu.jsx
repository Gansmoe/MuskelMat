import React from "react";
import WriteRecipes from "../components/WriteRecipes";
import { getRecipesByNutrients } from "../data/apidata";


export default class CalculateMenu extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            tempKcalInput: 0,
            tempProteinInput: 0,
            kcalInput: 0,
            proteinInput: 0,
            datarecept: [],
        }

    }



    handleSubmit = (event) => {
        this.setState({ kcalInput: this.state.tempKcalInput, proteinInput: this.state.tempProteinInput }, async () => {
            const updatedRecipes = await getRecipesByNutrients(this.state.proteinInput, this.state.kcalInput);
            this.setState({ datarecept: updatedRecipes });
        });

        event.preventDefault();
    }

    handleChangeKcal = (event) => {
        this.setState({ tempKcalInput: event.target.value });
    }

    handleChangeProtein = (event) => {
        this.setState({ tempProteinInput: event.target.value });
    }

    render() {
        return (
            <main className="componentMain">
                <h2>Här fyller du i ditt kalori- och proteinbehov, sedan finns veckomatsedeln under "Veckomatsedel"</h2>
                <form onSubmit={this.handleSubmit}>
                    <input type="number" placeholder="Kalorier/dag" value={this.state.tempKcalInput} onChange={this.handleChangeKcal}></input>
                    <input type="number" placeholder="Protein/dag" value={this.state.tempProteinInput} onChange={this.handleChangeProtein}></input>
                    <input type="submit" value="Kör!" />
                </form>
                {(this.state.datarecept.length === 0)
                    ?
                    <div><h3 >Fyll i kalori- och proteinbehov för att få fram recept</h3></div>
                    :
                    <>
                    {this.state.datarecept.map((recipe) => (
                        <WriteRecipes recipes={recipe} />
                    ))}
                    
                    </>
                }
            </main>
        );
    }
}