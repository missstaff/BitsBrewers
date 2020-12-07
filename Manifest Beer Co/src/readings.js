class Readings {

    constructor() {

        this.getDate = this.getDate.bind(this);
        this.getDate();
    }

    getDate() {
        let today = new Date();
        let year = today.getFullYear();
        let month = today.getMonth() + 1;
        let day = today.getDay();
        let date = `
        <div>
        <h1>Brew Readings</h1>
        <br />
        <h2 id="date">${month}/${day}/${year}</h2>
    </div>
    ` ;
        document.getElementById("date").innerHTML = date;

    }

}
let readings;
window.onload = () => { readings = new Readings(); }