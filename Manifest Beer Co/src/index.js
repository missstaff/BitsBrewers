class Index {
    constructor() {
        this.recipeArray = [];
        this.url = 'https://localhost:44394/api/recipes/name/';

        this.recipe = {
            name: "",
            style: "",
            version: 0,
            ibu: 0,
            abv: 0
        };

        
        document.getElementById('search-form').onclick = this.onFormSubmit.bind(this);

    }

    onFormSubmit(event) {
        event.preventDefault();
        let rName = document.getElementById('search').value;
        //rName.ToString();
        fetch(this.url + `${rName}`)
            .then(response => response.json())
            .then(data => {
                this.recipe.name = data[0].name;
                this.recipe.style = data[0].style.name;
                this.recipe.version = data[0].version;
                this.recipe.ibu = data[0].style.ibuMax;
                this.recipe.abv = data[0].style.abvMax;
                this.recipeArray.push(this.recipe);
                this.renderRecipe(this.recipe)
            })
            .catch(error => {
                alert("There was a problem getting recipe information!");
                //alert(error.message); //test trash
            });

    }
    renderRecipe(recipe) {
        let name = recipe.name;
        let style = recipe.style;
        let version = recipe.version;
        let ibu = recipe.ibuMax;
        let abv = recipe.avbMAX;
        
            this.recipe = `
            <tbody id="brew">
            <tr>
                <td>${name}</td>
                <td>${style}</td>
                <td>${version}</td>
                <td>${ibu}</td>
                <td>${abv}</td>
            </div>
                <td><a class="btn btn-default button1" href="history.html">History</a></td>
                <td><a class="btn btn-default button1" href="ingredients.html">Ingredients</a></td>
                <td><a class="btn btn-default button1" href="container.html">Select</button></td>
                <td>QOH</td>
                <td>Y/N</td>
                <!--ideally this icon would display expected date of completion(red) or start(green)-->
                <td><a class="btn btn-default button2" href="./schedule.html">
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
        document.getElementById('search').value = "";
    }

}
let index;
window.onload = () => { index = new Index(); }