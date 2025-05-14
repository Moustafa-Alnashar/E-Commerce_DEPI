// Script for navigation bar
const bar = document.getElementById('bar');
const nav = document.getElementById('navbar');
const close = document.getElementById('close');
let imgSrcDetails = ''
var MainImg = document.getElementById("MainImg");


if (bar) {
    bar.addEventListener('click', () => {
        nav.classList.add('active');
    })
}

if (close) {
    close.addEventListener('click', () => {
        nav.classList.remove('active');
    })
}

function goToDetails(src) {
    localStorage.setItem("imgSrcDetails", src); // store image src
    window.location.href = "/sproduct.html";     // navigate to second page
}



function toggleMenu(event, button) {
    event.stopPropagation(); // Prevent going to product details
    const menu = button.nextElementSibling;

    // Close all other menus
    document.querySelectorAll('.dropdown-menu').forEach(m => {
        if (m !== menu) m.style.display = 'none';
    });

    // Toggle this one
    menu.style.display = menu.style.display === 'block' ? 'none' : 'block';
}

// Optional handlers (replace alerts with real logic)
function handleUpdate(event) {
    event.stopPropagation();
    alert("Update clicked");
}

function handleDelete(event) {
    event.stopPropagation();
    alert("Delete clicked");
}

function handleAdd(event) {
    event.stopPropagation();
    alert("Add clicked");
}

// Close menu when clicking outside
document.addEventListener('click', function () {
    document.querySelectorAll('.dropdown-menu').forEach(menu => {
        menu.style.display = 'none';
    });
});


function loadUpdataView() {
    alert("bb");
    fetch('/Products/edit') // Sends a GET request to the specified URL
        .then(response => response.text()) // Converts the response into text (HTML)
        .then(html => {
            document.getElementById("viewContainer").innerHTML = html; // Inserts the HTML into the page
        })
        .catch(error => console.error("Error loading view:", error)); // Handles errors
}
