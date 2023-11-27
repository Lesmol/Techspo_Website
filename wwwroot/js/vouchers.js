// Get all elements with the class 'toggleButton'
var buttons = document.querySelectorAll('.select-btn');

// Function to toggle classes when the button is clicked
function toggleClasses() {
    // Toggle 'class1' and 'class2' on the clicked button
    this.classList.toggle('.select-btn');
    this.classList.toggle('select-btn__pressed');
}

// Attach the click event listener to all elements with the class 'toggleButton'
buttons.forEach(function (button) {
    button.addEventListener('click', toggleClasses);
});