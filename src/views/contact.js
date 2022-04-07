import { Page } from "../page.js";

export const contact = new Page("Contact");

contact.createElement("h1", "title", "Kontakt");
contact.createElement("h4", "email", "Email: ");
contact.createElement("h5", "emailInfo", "Isac@gansmoe.se");
contact.createElement("h4", "github", "Github: ");
contact.createElement("h5", "githubInfo", "https://github.com/Gansmoe");