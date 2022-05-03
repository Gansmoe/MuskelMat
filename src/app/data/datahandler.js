


export default class DataHandler {
    
    getData = async () => {
        const response = await fetch("mockdata.json");
        const data = await response.json();
        console.log(data);
        return data;
        
    };
    
    getRecipe(number) {

        return recipes.find(
            (recipe) => recipe.number === number
        );
    }
    
    getRecipeByProtein(protein) {
        return recipes.find(
            (recipe) => recipe.protein === protein
        );
    }
}
