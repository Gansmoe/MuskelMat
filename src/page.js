

export class Page {
    constructor(title){
        this.title = title;
        this.content = [];
    }

    createElement(element, classId, text) {
        const el = document.createElement(element);
        el.classList.add(classId);
        el.textContent = text;
        this.content.push(el);
    }

    renderPage() {
        const main = document.getElementById("main");
        while (main.firstChild) {
            main.firstChild.remove();
            console.log("removed");
        }

        for (let element of this.content) {
            main.append(element);
        }

        console.log(this.name, this.content);
    }
}