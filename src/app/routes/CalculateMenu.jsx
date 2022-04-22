import React from "react";
import Recipes from "./recipes";
import DataHandler from "../data/datahandler.js";
import WriteRecipes from "../components/WriteRecipes";
import Mockdata from "../data/mockdata.json";


export default class CalculateMenu extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            kcalInput: 0,
            proteinInput: 0,
            recipeArray: [],
            recipe: null,
            mounted: false,
            datarecept: null,
        }
        console.log("Constructor", Mockdata);

    }

    getData() {
        setTimeout(() => {
            this.setState({
                datarecept: Mockdata,
            }, () => console.log(this.state.datarecept))
        }, 2000)
    };

    componentDidMount() {
        this.getData();
        console.log("Mount");
    }


    render() {
        console.log("render");
        return (
            <main className="componentMain">
                <h2>Här fyller du i ditt kalori- och proteinbehov, sedan finns veckomatsedeln under "Veckomatsedel"</h2>
                <input type="number" placeholder="Kalorier/dag" onChange={(e) => this.setState({ kcalInput: e.target.value })}></input>
                <input type="number" placeholder="Protein/dag" onChange={(e) => this.setState({ proteinInput: e.target.value })}></input>
                {(this.state.datarecept === null)
                    ?
                    <div className="loading"><h3 >Laddar...</h3></div>
                    :
                    <WriteRecipes recipes={this.state.datarecept} />
                }



            </main>
        );
    }
}