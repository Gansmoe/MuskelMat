const url = "https://localhost:7257/api/recipes/";
const apiKey = "apiKey=1c2c8e8baba1425a9ce29512cf79c67b";

export async function getRecipesByNutrients() {
    try {
        const response = await fetch(url);
        const data = await response.json();
        console.log(data);
        return [data, null];
    }
    catch(err) {

        return [[], err];

    }
};

export async function getDataRecipeInformation(id) {
    try {
        const response = await fetch(url + id);
        const data = await response.json();
        console.log(data);
        return [data, null];
    }
    catch(err) {

        return [[], err];

    }

};
