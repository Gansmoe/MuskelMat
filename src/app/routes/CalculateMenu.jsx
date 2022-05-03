import React from "react";
import Recipes from "./recipes";
import DataHandler from "../data/datahandler.js";
import WriteRecipes from "../components/WriteRecipes";
import Mockdata from "../data/mockdata.json";

const url = "https://api.spoonacular.com/recipes/findByNutrients?";
const apiKey = "apiKey=1c2c8e8baba1425a9ce29512cf79c67b";


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

    getData = async () => {
        const response = await fetch(url + apiKey + "&minProtein=" + this.state.proteinInput + "&maxCalories=" + this.state.kcalInput + "&random=true");
        const data = await response.json();
        console.log(data);
        return data;
    };

    handleSubmit = async (event) => {
        console.log("Hej från handle submit");
        console.log(this.state.tempKcalInput);
        console.log(this.state.tempProteinInput);
        this.setState({ kcalInput: this.state.tempKcalInput, proteinInput: this.state.tempProteinInput }, async() => {
            const updatedRecipes = await this.getData();
            this.setState({ datarecept: updatedRecipes });
            console.log("kcalinput " + this.state.kcalInput);
        });

        event.preventDefault();
    }

    handleChangeKcal = (event) => {
        this.setState({ tempKcalInput: event.target.value }, console.log(this.state.tempKcalInput));
    }

    handleChangeProtein = (event) => {
        this.setState({ tempProteinInput: event.target.value }, console.log(this.state.tempProteinInput));
    }



    componentDidUpdate() {
        console.log("Update");
    }



    render() {
        console.log("render");
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
                    <WriteRecipes recipes={this.state.datarecept} />
                }
            </main>
        );
    }
}