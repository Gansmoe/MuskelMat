

export class Page {
    constructor(title){
        this.title = title;
        this.content = [];
    }

    createElement(element, classId, text) {
        const div = document.createElement("div");
        // Fortsätt här med att skapa en div att stoppa elementet i
        const el = document.createElement(element);
        el.classList.add(classId);
        el.textContent = text;
        div.appendChild(el)
        this.content.push(div);
    }

    renderPage() {
        const main = document.getElementById("main");
        while (main.firstChild) {
            main.firstChild.remove();
            console.log("removed");
        }
        const div = document.createElement("div");

        for (let element of this.content) {
            div.append(element);
        }

        main.appendChild(div);
        console.log(this.name, this.content);
    }
}