import { getRecipesByNutrients } from "./apidata";

export async function GetDailyRecipes(kcalInput, proteinInput) {

    const [allRecipes, err] = await getRecipesByNutrients();
    const allBreakfasts = [];
    const allDinners = [];
    const allSnacks = [];
    const dailyMenu = [];

    for(let i = 0; i<allRecipes.length; i++){

        if(allRecipes[i].mealType === "Frukost"){
            allBreakfasts.push(allRecipes[i]);
        }
        else if(allRecipes[i].mealType === "Lunch Middag"){
            allDinners.push(allRecipes[i]);
        }
        else if(allRecipes[i].mealType === "Mellanmål"){
            allSnacks.push(allRecipes[i]);
        }
    }

    for(let i = 0; i<allBreakfasts.length; i++){
        if(allBreakfasts[i].kcal < kcalInput*0.2 && allBreakfasts[i].protein > proteinInput*0.2 && dailyMenu.length === 0){
            dailyMenu.push(allBreakfasts[i]);
        }  
    }

    for(let i = 0; i<allDinners.length; i++){
        if(allDinners[i].kcal < kcalInput*0.3 && allDinners[i].protein > proteinInput*0.3 && dailyMenu.length < 3){
            dailyMenu.push(allDinners[i]);
        }
    }

    for(let i = 0; i<allSnacks.length; i++){
        if(allSnacks[i].kcal < kcalInput*0.2 && allSnacks[i].protein > proteinInput*0.2 && dailyMenu.length < 5){
            dailyMenu.push(allSnacks[i]);
        }
    }

    let totalKcal = 0;
    let totalProtein = 0;
    for(let i = 0; i<dailyMenu.length; i++){
        totalKcal += dailyMenu[i].kcal;
        totalProtein += dailyMenu[i].protein;
    }
    

    console.log(dailyMenu);
    console.log("Totalt Protein " + totalProtein);
    console.log("Totalt antal kalorier " + totalKcal);
    console.log(allBreakfasts);
    console.log(allDinners);
    console.log(allSnacks);

}