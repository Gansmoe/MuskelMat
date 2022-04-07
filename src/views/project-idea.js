import { Page } from "../page.js";

export const projectIdea = new Page("Productidea");

projectIdea.createElement("h1", "title", "Projektidén");
projectIdea.createElement("p", "text", "Projektet består i att göra en prototyp-app där man ska kunna få fram en veckomatsedel baserad på användarens protein- och kaloribehov. Publika APIer kommer användas för recept i början men om tid finns över vill jag använda egna APIer.");