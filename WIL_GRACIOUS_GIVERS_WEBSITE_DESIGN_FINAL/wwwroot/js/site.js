// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//Scroll Effect
const sr = ScrollReveal({
    distance: '65px',
    duration: 2000,
    delay: 450,
    reset: true
});

sr.reveal('section', { delay: 200, origin: 'top' });


//Navbar Scroll/Hide
const navbar = document.querySelector(".navbar");
let prevScrollpos = window.pageYOffset;

window.addEventListener("scroll", () => {
    const currentScrollpos = window.pageYOffset;
    if (prevScrollpos > currentScrollpos) {
        navbar.classList.remove("hidden");
    } else {
        navbar.classList.add("hidden");
    }
    prevScrollpos = currentScrollpos;
});


