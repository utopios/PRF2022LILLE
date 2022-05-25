/**
 * Les nouveautés ES6 (Implémentation de la spécification ECMA6)
 */
// Récupération de l'element du DOM #App
const app = document.querySelector('#app');

 console.log("---------- Nouveauté ES6 ----------");
 
/**
 *  Let
 * 
 *  Jusqu'a présent nous utilision var pour la déclaration de nos variables
 *  Maintenant nous utiliserons let, voyons pourquoi =>
 */
 console.log("---------- Mot clé let => remplace var ----------");

// Afficher une variable avant la déclaration
console.log(prenomVar); // Hoisting (remontée de la déclaration variable) => Pour le navigateur la variable existe, seule sa valeur est non initialisé
//console.log(nomLet); // Provoque une erreur de variable non déclarée
// Déclaration des variables (var et let)
var prenomVar = "Richard";
let nomLet = "Gear";

/**
 * Const
 * 
 * Pour déclarer une constante
 * 
 */

const nbMax = 128;
console.log("NbMax vaut : " + nbMax / 2);
// nbMax = 129; // Uncaught TypeError: Assignment to constant variable.
// console.log(nbMax);

const fruits = ["Pomme"];
//fruits = ["Abricots","Poire"]; // Uncaught TypeError: Assignment to constant variable.

fruits.push("Abricots","Poire"); // Ici const garantit la structure de l'objet (tableau numérique de string)
console.table(fruits);


/**
 * Les nouvelles méthodes apportées à la classe Array
 * 
 *  .foreach()
 *  .map()
 *  .find()
 *  .filter()
 * 
 */
 console.log("---------- Les nouvelles Méthodes ES6 ----------");

// Déclaration d'un tableau de légumes (2 dimensions)

const vegetables = [
    {
        code : 1,
        name:"Carotte",
        price:1.99
    },
    {
        code : 2,
        name:"Poivron Vert",
        price:4.99
    },
    {
        code : 3,
        name:"Poivron Rouge",
        price:4.99
    },
    {
        code : 4,
        name:"Haricot Vert",
        price:3.89
    },
    {
        code : 5,
        name:"Courgette",
        price:2.59
    },
];

// Affichage du tableau dans la console
console.table(vegetables);

/**
 *  .foreach()
 */  

console.log("\n------ Parcours du tableau Vegetables avec .foreach(vegetable) --------");

// Affichage du tableau avec un foreach
vegetables.forEach(function(vegetable) {
    console.log(vegetable.name);
    app.innerHTML += `<h3>${vegetable.name}</h3>`;
} );
console.log("\n------ Parcours du tableau Vegetables avec .foreach avec index --------");

// Affichage du tableau avec les index
vegetables.forEach(function(vegetable,index) {
    console.log((index+1) + " - " + vegetable.name);
    app.innerHTML += `<h3>${index + 1} - ${vegetable.name}</h3>`;
} );


/**
 *   .map()
 */
console.log("\n------ Parcours du tableau Vegetables avec .map(function(){}) ------");

const vegetablesNames =  vegetables.map(function(vegetable) {
    return vegetable.name;
})

console.table(vegetables);
console.table(vegetablesNames); // map() nous retourne un nouveau table indexé



/**
 *  Find() => retourne le premier element correspondant aux critères
 */
 console.log("\n------ Parcours du tableau Vegetables avec .find(function(){}) ------");

const poivron = vegetables.find(function(vegetable){
    return vegetable.name.includes("Poivron");
})

console.log(poivron);


/**
 *  Filter() => retourne un tableau contenant n occurences correspondant à nos critères
 */
 console.log("\n------ Parcours du tableau Vegetables avec .filter(function(){}) ------");

const poivrons = vegetables.filter(function(vegetable){
    return vegetable.name.includes("Poivron");
})

console.log(poivrons);




