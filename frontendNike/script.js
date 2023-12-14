document.body.addEventListener("click", function(e){
    if (e.target.classList.contains("menubtn")) {
        let elementsWithClass = document.querySelectorAll(".active");
        elementsWithClass.forEach(function(element) {
        element.classList.remove("active");
        }); 
        // Agrega la clase al elemento clickeado
        e.target.classList.add("active");
    }
    if (e.target.id = "content"){
        let elementsWithClass = document.querySelectorAll(".active");
        console.log(elementsWithClass[0].innerHTML);
        if (elementsWithClass[0].innerHTML == "Todos los productos"){
            fetch('http://localhost:5122/api/Producto')
                .then(data => 
                    data.forEach(item => console.log(item)));
        }
    }
    }
)