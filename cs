/* General Styles */

body {
    font-family: Arial, sans-serif;
    margin: 0;
    line-height: 1.6;
    background-color: #ffffff;
    color: #222222;
}

/* Header */

header {
    background-color: #003366;
    color: white;
    padding: 20px;
    text-align: center;
}

/* Navigation using Flexbox */

.nav-links {
    display: flex;
    justify-content: center;
    gap: 20px;
    list-style: none;
    padding: 0;
}

.nav-links a {
    color: white;
    text-decoration: none;
}

/* Focus States */

a:focus,
button:focus,
input:focus {
    outline: 3px solid #ffcc00;
    outline-offset: 2px;
}

/* Grid Layout */

.grid-container {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 20px;
    padding: 20px;
}

section {
    border: 1px solid #ccc;
    padding: 20px;
    border-radius: 8px;
}

/* Images */

img {
    width: 100%;
    height: auto;
}

/* Form */

form {
    display: flex;
    flex-direction: column;
}

input,
button {
    padding: 10px;
    margin-bottom: 10px;
}

button {
    background-color: #003366;
    color: white;
    border: none;
    cursor: pointer;
}

/* Tablet Breakpoint */

@media (max-width: 1024px) {
    body {
        font-size: 16px;
    }
}

/* Mobile Breakpoint */

@media (max-width: 600px) {

    .grid-container {
        grid-template-columns: 1fr;
    }

    .nav-links {
        flex-direction: column;
        align-items: center;
    }

    body {
        font-size: 14px;
    }
}

/* Footer */

footer {
    background-color: #003366;
    color: white;
    text-align: center;
    padding: 10px;
}