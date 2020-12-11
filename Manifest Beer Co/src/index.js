class Index {
    constructor() {
        this.url = 'https://localhost:44394/api/recipes/name/';

        this.recipe = {
            name: "",
            style: "",
            version: 0,
            ibu: 0,
            abv: 0,
            date: null
        };

        this.renderRecipesList = this.renderRecipesListItem.bind(this);

        document.getElementById('search-add-button').onclick = this.onFormSubmit.bind(this);

    }

    onFormSubmit(event) {
        event.preventDefault();
        let rName = document.getElementById('search-add').value;
        fetch(this.url + `${rName}`)
            .then(response => response.json())
            .then(data => {
                this.recipe.name = data[0].name;
                this.recipe.style = data[0].style.name;
                this.recipe.version = data[0].version;
                this.recipe.ibu = data[0].style.ibuMax;
                this.recipe.abv = data[0].estimatedAbv;
                this.recipe.date = data[0].date;
                this.renderRecipesListItem(this.recipe)
            })
            .catch(error => {
                alert("There was a problem getting recipe information!");
            });
        document.getElementById('search-add').value = "";
    }
    //note to self use calendar icon in lower table to put in array and display at top of page~do not use brew schedule page yet!


    /*renderRecipeList(recipe) {
        const recipesHTML = recipe.map((recipe, index) => this.renderRecipeListItem(recipe, index)).join('');
        document.getElementById("brew").innerHTML = recipesHTML;
        let recipes = document.getElementsByClassName("brew");
        for (let i = 0; i < items.length; i++) {
            recipes[i].ontouch = this.renderCurrentRecipe.bind(this, i);
        }
    }*/

    renderRecipesListItem(recipe) {
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
                <td>QOH</td>
                <td><a class="btn btn-default button1" href="history.html">History</a></td>
                <td><a class="btn btn-default button1" href="ingredients.html">Ingredients</a></td>
                <!--ideally this icon would display expected date of completion(red) or start(green)-->
                <td><a class="btn btn-default button2 ml-3" href="./schedule.html">
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

}
let index;
window.onload = () => { index = new Index(); }