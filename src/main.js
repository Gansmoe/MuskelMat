import * as eventlistners from "./classes/eventlisteners.js";
import { projectIdea } from "./views/project-idea.js";

const projectBtn = document.getElementById("projectBtn");
const businessBtn = document.getElementById("businessBtn");
const contactBtn = document.getElementById("contact");

window.onload = projectIdea.renderPage();

eventlistners.eventBusiness(businessBtn);
eventlistners.eventContact(contactBtn);
eventlistners.eventProject(projectBtn);