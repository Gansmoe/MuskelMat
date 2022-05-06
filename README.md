# MuskelMat

## Bundler

-> Parcel is used for bundling and transpiling.

## Install

-> Clone repo <br>
-> In terminal, navigate to MuskelMat-folder <br>
-> run 'npm ci' 

## Start

-> run 'npm start' <br>
-> your browser should open automatically <br>
-> to get to app, click the 'App' button in index.html <br>

## Login

-> Username: User
-> Password: Password



## Externa bibliotek

-> Parcel är byggsystemet och används för transpilering
-> React används för att göra komponenter/views på ett smidigare sätt (jämfört med traditionell javascript)
-> React Router används för routing i appen. Det används även för sökfunktionen i recipes/recipe-komponenten av appen.
-> React Cookie Consent används för att göra en enkel och smidig "jag accepterar kakor"-popup.

## Tjänster

-> De webb-APIer som används är mot spoonacular. I sökfunktionen där man skriver in sitt kalori- och proteinbehov görs ett GET-anrop till spoonaculars /recipes/findByNutrients där dom inmatade värderna skickas med. Detta görs i CalculateMenu som i sin tur använder funktionen getRecipesByNutrients som ligger i filen apidata.js. Detta görs för att få fram recept med ett kaloriinnehåll under, och ett proteininnehåll över, det användaren har matat in. 
-> Det andra stället där ett API-anrop görs är i DetailedRecipe. Här används IDt ifrån ett recept för att få fram mer detaljerad information om receptet. Detta anropet görs mot spoonaculars recipes/{ID}/information med hjälp av funktionen getDataRecipeInformation som finns i filen apidata.js. Anropet till den funktionen görs i DetailedRecipe's funktionen recipeInfo.

