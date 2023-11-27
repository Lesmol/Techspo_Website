// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const hamburger = document.querySelector(".hamburger")
const nav_menu = document.querySelector(".nav-menu")
const nav_menu2 = document.querySelector(".nav-menu2")
hamburger.addEventListener("click", () => {
    hamburger.classList.toggle("active");
    nav_menu.classList.toggle("active");
    nav_menu2.classList.toggle("active");
})
document.querySelectorAll(".nav-link").forEach(n => n.addEventListener("click", () => {
    hamburger.classList.remove("active");
    nav_menu.classList.remove("active");
    nav_menu2.classList.remove("active");
}))