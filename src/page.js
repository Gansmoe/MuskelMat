

export class Page {
    constructor(title){
        this.title = title;
        this.content = [];
    }

    createElement(element, text) {
        const div = document.createElement("div");
        const el = document.createElement(element);
        el.textContent = text;
        div.appendChild(el)
        this.content.push(div);
    }

    renderPage() {
        const main = document.getElementById("main");
        
        while (main.firstChild) {

            main.firstChild.remove();
        }

        const div = document.createElement("div");

        for (let element of this.content) {
            div.append(element);
        }

        main.appendChild(div);
    }
}