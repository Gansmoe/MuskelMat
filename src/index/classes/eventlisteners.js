import { projectIdea } from "../views/project-idea.js";
import { businessPlan } from "../views/businessplan.js";
import { contact } from "../views/contact.js";

export const eventProject = (projectBtn) => {
    projectBtn.addEventListener("click", () => {
        projectIdea.renderPage();
    });
}

export const eventBusiness = (businessBtn) => {
    businessBtn.addEventListener("click", () => {
        businessPlan.renderPage();
    })
}

export const eventContact = (contactBtn) => {
    contactBtn.addEventListener("click", () => {
        contact.renderPage();
    })
}