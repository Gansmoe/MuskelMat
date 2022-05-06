const url = "https://api.spoonacular.com/recipes/";
const apiKey = "apiKey=1c2c8e8baba1425a9ce29512cf79c67b";

export async function getRecipesByNutrients(proteinInput, kcalInput) {
    const response = await fetch(url + "findByNutrients?" + apiKey + "&minProtein=" + proteinInput + "&maxCalories=" + kcalInput + "&random=true");
    const data = await response.json();
    console.log(data);
    return data;
};

export async function getDataRecipeInformation(id) {
    const response = await fetch(url + id + "/information?" + apiKey + "&includeNutrition=false");
    const data = await response.json();
    console.log(data);
    return data;
};
