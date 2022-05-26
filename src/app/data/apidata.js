const recipeUrl = "https://localhost:7257/api/recipes/";
const apiKey = "apiKey=1c2c8e8baba1425a9ce29512cf79c67b";

export async function getRecipesByNutrients() {
    try {
        const response = await fetch(recipeUrl);
        const data = await response.json();
        console.log(data);
        return [data, null];
    }
    catch (err) {

        return [[], err];
    }
};

export async function getDataRecipeInformation(id) {
    try {
        const response = await fetch(recipeUrl + id);
        const data = await response.json();
        console.log(data);
        return [data, null];
    }
    catch (err) {

        return [[], err];

    }
};

export async function addRecipe(name, kcal, protein, mealType) {
    try {
        const response = await fetch(recipeUrl, {
            method: 'POST',
            body: JSON.stringify({
                Name: name,
                Kcal: kcal,
                Protein: protein,
                MealType: mealType
            }),
            headers: {
                'Content-Type': 'application/json; charset=UTF-8',
            },
        });
        const data = await response.json();
        console.log(data);
        return [data, null];
    }
    catch (err) {

        return [[], err];

    }
}
