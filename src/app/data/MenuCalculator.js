import { getRecipesByNutrients } from "./apidata";

export async function GetDailyRecipes(kcalInput, proteinInput) {

    const [allRecipes, err] = await getRecipesByNutrients();
    const allBreakfasts = [];
    const allDinners = [];
    const allSnacks = [];
    const dailyMenu = [];

    for (let i = 0; i < allRecipes.length; i++) {

        if (allRecipes[i].mealType === "Frukost") {
            allBreakfasts.push(allRecipes[i]);
        }
        else if (allRecipes[i].mealType === "Lunch Middag") {
            allDinners.push(allRecipes[i]);
        }
        else if (allRecipes[i].mealType === "Mellanmål") {
            allSnacks.push(allRecipes[i]);
        }
    }

    const breakfastGoalKcal = kcalInput * 0.2;
    const breakfastGoalProtein = proteinInput * 0.2;


    console.log(breakfastGoalKcal, " " + breakfastGoalProtein);

    let allBreakfastKcal = [];
    let allBreakfastProtein = [];

    for(let i =0; i<allBreakfasts.length; i++)
    {
        allBreakfastKcal.push(allBreakfasts[i].kcal)
        allBreakfastProtein.push(allBreakfasts[i].protein)
    }

    console.log("allt frukostkcal: " + allBreakfastKcal);
    console.log("allt frukostprotein: " + allBreakfastProtein);

    const breakfastKcalOutput = allBreakfastKcal.reduce((prev, curr) => Math.abs(curr - breakfastGoalKcal) < Math.abs(prev - breakfastGoalKcal) ? curr : prev);
    const breakfastProteinOutput = allBreakfastProtein.reduce((prev, curr) => Math.abs(curr - breakfastGoalProtein) < Math.abs(prev - breakfastGoalProtein) ? curr : prev);

    console.log("Närmaste kcal: " + breakfastKcalOutput);
    console.log("Närmaste protein: " + breakfastProteinOutput);

    for (let i = 0; i < allBreakfasts.length; i++) {
        if (allBreakfasts[i].kcal === breakfastKcalOutput && allBreakfasts[i].protein === breakfastProteinOutput && dailyMenu.length === 0) {
            dailyMenu.push(allBreakfasts[i]);
        }
    }
    console.log(dailyMenu);

    /* for (let i = 0; i < allDinners.length; i++) {
        if (allDinners[i].kcal < kcalInput * 0.3 && allDinners[i].protein >= proteinInput * 0.3 && dailyMenu.length < 3) {
            dailyMenu.push(allDinners[i]);
        }
    }

    for (let i = 0; i < allSnacks.length; i++) {
        if (allSnacks[i].kcal < kcalInput * 0.2 && allSnacks[i].protein >= proteinInput * 0.2 && dailyMenu.length < 5) {
            dailyMenu.push(allSnacks[i]);
        }
    }

    let totalKcal = 0;
    let totalProtein = 0;
    for (let i = 0; i < dailyMenu.length; i++) {
        totalKcal += dailyMenu[i].kcal;
        totalProtein += dailyMenu[i].protein;
    }


    
    console.log("Totalt Protein " + totalProtein);
    console.log("Totalt antal kalorier " + totalKcal);
    console.log(allBreakfasts);
    console.log(allDinners);
    console.log(allSnacks);
 */
}

function closest(num, arr) {
    var curr = arr[0];
    var diff = Math.abs(num - curr);
    for (var val = 0; val < arr.length; val++) {
        var newdiff = Math.abs(num - arr[val]);
        if (newdiff < diff) {
            diff = newdiff;
            curr = arr[val];
        }
    }
    return curr;
}

