let recipes = [
    {
        name: "Kyckling med broccoli och ris",
        number: 1,
        kcal: 520,
        protein: 38,
        instructions: "Stek kycklingen i ugnen i 30 minuter på 180 grader, under tiden kokar du broccoli och ris."
    },
    {
        name: "Chili con carne",
        number: 2,
        kcal: 732,
        protein: 51,
        instructions: "Gör en chilikonka, servera med ris och grönsaker."
    },
    {
        name: "Proteinpannkakor",
        number: 3,
        kcal: 451,
        protein: 42,
        instructions: "Gör pannkakor med proteinpulver i smeten."
    },
    {
        name: "Grekisk sallad",
        number: 4,
        kcal: 467,
        protein: 25,
        instructions: "Gör en schysst sallad, tillsätt fetaost och grejer."
    },
    {
        name: "Tacofärs med ris",
        number: 5,
        kcal: 612,
        protein: 48,
        instructions: "Stek köttfärs och koka riset."
    },

];

export function getRecipes() {
    return recipes;
}

export function getRecipe(number) {
    return recipes.find(
      (recipe) => recipe.number === number
    );
  }