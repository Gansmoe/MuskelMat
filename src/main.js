import * as eventlistners from "./classes/eventlisteners.js";

const projectBtn = document.getElementById("projectBtn");
const businessBtn = document.getElementById("businessBtn");
const contactBtn = document.getElementById("contact");


eventlistners.eventBusiness(businessBtn);
eventlistners.eventContact(contactBtn);
eventlistners.eventProject(projectBtn);
