import React from "react";
import WriteRecipes from "../components/WriteRecipes.jsx";

import { getRecipesByNutrients } from "../data/apidata";
import { GetDailyRecipes } from "../data/MenuCalculator";


export default class CalculateMenu extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            kcalInput: 0,
            proteinInput: 0,
            datarecept: [],
            error: null,
            updatedRecipesDone: false,
        }
    }



    handleSubmit = async (event) => {
        console.log("Hejhej från submit");
        const [updatedRecipes, err] = await getRecipesByNutrients();
        console.log({ updatedRecipes });
        this.setState({ datarecept: updatedRecipes, updatedRecipesDone: true });
        this.setState({ error: err });
        GetDailyRecipes(this.state.kcalInput, this.state.proteinInput);

        event.preventDefault();
    }

    handleChangeKcal = (event) => {
        this.setState({ kcalInput: event.target.value });
    }

    handleChangeProtein = (event) => {
        this.setState({ proteinInput: event.target.value });
    }

    render() {
        return (
            <main className="componentMain">
                <h2>Här fyller du i ditt kalori- och proteinbehov, sedan finns veckomatsedeln under "Veckomatsedel"</h2>
                <form onSubmit={this.handleSubmit}>
                    <p>Kalorier/dag</p>
                    <input type="number" placeholder="Kalorier/dag" value={this.state.kcalInput} onChange={this.handleChangeKcal}></input>
                    <p>Protein/dag</p>
                    <input type="number" placeholder="Protein/dag" value={this.state.proteinInput} onChange={this.handleChangeProtein}></input>
                    <input type="submit" value="Kör!" />
                </form>
                {(this.state.updatedRecipesDone === false)
                    ?
                    <div><h3 >Fyll i kalori- och proteinbehov för att få fram recept</h3></div>
                    :

                    <>
                        {(this.state.error === null)
                            ?
                            <>
                                {
                                    this.state.datarecept.map((recipe) => (
                                        <WriteRecipes key={recipe.recipesId} recipes={recipe} />
                                    ))
                                }
                            </>
                            :
                            <p>Någonting blev fel när recepten skulle hämtas, försök igen eller skicka ett meddelande till hjälp@muskelmat.se</p>

                        }


                    </>
                }
            </main>
        );
    }
}
