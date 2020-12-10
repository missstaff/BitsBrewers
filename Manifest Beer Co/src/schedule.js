
class Schedule {

    constructor() {
        //Instance variables//
        this.days = Array(38).fill(null);

        //Bindings//
        this.getMonthYear = this.getMonthYear.bind(this);
        this.getMonthYear();
        this.renderCalendar = this.renderCalendar.bind(this);
        this.renderCalendar();

        this.id = this.renderCalendar();
        //Touch Event handler//   
        for (let i = 0; i < this.days.length; i++) {
            let id = i;
            document.getElementById(id).ontouchend = this.touched.bind(this);
        }
    }
    //on touch event
    touched() {
        console.log("touch"); //~ test trash
    }

    //retrieves month and year~displayed at top of page
    getMonthYear() {
        const monthNames = ["January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        ];

        let today = new Date();
        let year = today.getFullYear();
        let month = monthNames[today.getMonth()];
        let monthYear = `
        <div>
        <h1>Brew Schedule</h1>
        <div><h2 id="currentMonth">${month} ${year}</h2></div>
        <br />
    </div>
` ;
        document.getElementById("month-year").innerHTML = monthYear;

    }


    /*retrieves numeric dates and places them on the calendar
    need to figure out how to nest loops to make day set at the correct weekday*/

    /////////////////////////////////////////////////////////////////////////////////
    /**Start brew button will turn the day selected green on the calendar open the daily form 
    where brewer can set the antipated end date and confirm ingredients used which will be automatically updated in DB
    once submit button is hit remove the expected ingredients
    the databse; there is navigation to an additional subtract ingredients option for crafing brews or expirimenting*/
    ///////////////////////////////////////////////////////////////////////////////////////////////////
    /*The calendar has an ontouch event for each day that will bring up a form to enter daily readings; readings 
    will be saved in local storage and pushed to the database when end brew is selected. There will also be a notes
    section on the form which will also be pushed to the database when end brew is selected*/
    /////////////////////////////////////////////////////////////////////////////////////////////////////////
    /*Selecting end brew will finish the brew schedule by changing status, removing that batch from the brew schedule
    and pushing all dailing readings and notes associated with the brew to DB*/
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////
    renderCalendar() {
        const weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];
        this.days.splice(32);
        let startDate = new Date();
        let year = startDate.getFullYear();
        let month = startDate.getMonth();
        let startDay = new Date(year, month, 1);
        let start = startDay.getDay();
        //let dayOfWeek = weekDays[startDay.getDay()];
        let day = start;
        let id = 50;
        for (let d = 0; d < weekDays.length; d++) {
            document.getElementById(id).innerHTML = weekDays[day];
            id++;
            day++;
            if(day > 6) {
                day = 0;
            }
            
        }
        for (let i = start; i < this.days.length; i++) {
            let id = i;
            if (id == 32) {
                id = 1;
            } else if (id < 32 || month == 1 || month == 3 || month == 5 || month == 7 || month == 8
                || month == 10 || month == 12) {
                document.getElementById(id).innerHTML = start;
            } else if (id <= 30 || month == 4 || month == 6 || month == 9 || month == 11) {
                document.getElementById(id).innerHTML = start;
            }
            start++;
        }

    }


}

let schedule;
window.onload = () => { schedule = new Schedule(); }