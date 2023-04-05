function initializeCalendar() {
    const calendarButtons = document.querySelectorAll('#calendarButton');
    
    for (let i = 0; i < calendarButtons.length; i++) {
        calendarButtons[i].addEventListener('click', function (event) {
            event.preventDefault();
            
            const index = parseInt(this.getAttribute('data-index'));
            const dateInput = document.querySelectorAll('#dateInput')[index];
            const calendar = document.querySelectorAll('#calendar')[index];

            if (calendar.classList.contains('hidden')) {
                calendar.classList.remove('hidden');
                dateInput.classList.add('hidden');
                calendar.addEventListener('change', function () {
                    dateInput.value = this.value;
                    this.classList.add('hidden');
                    dateInput.classList.remove('hidden');
                });
            }
            else {
                calendar.classList.add('hidden');
                dateInput.classList.remove('hidden');
            }
        });
    }
    const dateInputs = document.querySelectorAll('#dateInput');
    for (let i = 0; i < calendarButtons.length; i++) {
        dateInputs[i].addEventListener('input', function () {
            this.value = this.value.replace(/[^0-9-]/g, '');
        });
    }
}

document.addEventListener('DOMContentLoaded', initializeCalendar);