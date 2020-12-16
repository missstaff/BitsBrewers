class Index {
    constructor() {
        this.url = 'https://localhost:44394/api/recipes/name/';

        /*this.recipe = {
            name: "",
            style: "",
            version: 0,
            ibu: 0,
            abv: 0,
            date: null
        };*/
        //array for find recipes list
        //can't add recipes with the same name and I am not ready to search by
        //version or style to verify that multiple recipes are displayed when approriate
        this.recipes = [
            {
                name: "",
                style: "",
                version: 0,
                ibu: 0,
                abv: 0,
                date: null
            },
        ];

        if (!localStorage["RECIPES"]) {
            this.schedule = [
                {
                    name: "test brew",
                    style: "test",
                    version: 9,
                    ibu: 8,
                    abv: 7,
                    date: null
                },
            ];
        } else 
            this.scheduled.recipes = JSON.parse(localStorage["RECIPES"]);
            this.fillScheduledRecipesList = this.fillScheduledRecipesList.bind(this);
            this.fillScheduledRecipesList();


        this.renderRecipe = this.renderRecipe.bind(this);

        document.getElementById('search-add-button').ontouchend = this.onFormSubmit.bind(this);

    }

    onFormSubmit(event) {
        event.preventDefault();
        let rName = document.getElementById('search-add').value;
        fetch(this.url + `${rName}`)
            .then(response => response.json())
            .then(data => {
                this.recipes.name = data[0].name;
                this.recipes.style = data[0].style.name;
                this.recipes.version = data[0].version;
                this.recipes.ibu = data[0].style.ibuMax;
                this.recipes.abv = data[0].estimatedAbv;
                this.recipes.date = data[0].date;
                this.renderRecipe(this.recipes)
            })
            .catch(error => {
                alert("There was a problem getting recipe information!");
            });
        document.getElementById('search-add').value = "";
    }
    //note to self use calendar icon in lower table to put in array and display at top of page~do not use brew schedule page yet!

    //displays recipe(s) in the search for recipe table~these get added to the schedule table by pressing the calendar button//
    renderRecipe(recipe, index) {
        let name = recipe.name;
        let style = recipe.style;
        let version = recipe.version;
        let ibu = recipe.ibu;
        let abv = recipe.abv;
        let date = recipe.date;

        this.recipe = `
            <tbody id="brew">
            <tr>
                <td>${name}</td>
                <td>${style}</td>
                <td>${version}</td>
                <td>${ibu}</td>
                <td>${abv}</td>
                <td>${date}</td>
                <td>Y/N</td>
                <td><a class="btn btn-default button1" href="">QOH</a></td>
                <td><a class="btn btn-default button1" href="history.html">History</a></td>
                <td><a class="btn btn-default button1" href="ingredients.html">Ingredients</a></td>
                <!--ideally this icon would display expected date of completion(red) or start(green)-->
                <td><a class="btn btn-default button2 ml-3" href="">
                        <svg width="2.5em" height="2.5em" viewBox="0 0 16 16" class="bi bi-calendar" fill="currentColor"
                            xmlns="http://www.w3.org/2000/svg">
                            <path fill-rule="evenodd"
                                d="M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM1 4v10a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4H1z" />
                        </svg>
                    </a>
                </td>
            </tr>
            </tbody>
             `
            ;

        document.getElementById("brew").innerHTML = this.recipe;
        document.getElementById('search-add').value = "";
    }

    fillScheduledRecipesList() {

        localStorage.setItem("RECIPES", JSON.stringify(this.schedule));
 
        let recipeHtml = this.schedule.reduce(
            (html, recipe, index) => html += this.generateRecipeHtml(recipe, index),
            '');
        document.getElementById("brew").innerHTML = recipeHtml;
    }

}
let index;
window.onload = () => { index = new Index(); }