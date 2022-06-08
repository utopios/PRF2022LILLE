import Contact from './js/Contact.js';

//Création des constantes permettant la récupération d'element HTML
const tableau = document.querySelector('#tableau');

// Declaration des variables globale
let contacts = [];

function createFakeContact() {
    // Création d'un tableau de personnes à deux dimensions
    let annuaire = [
        {
            titre: "Mr",
            nom: "Dupont",
            prenom: "Jean",
            dateNaissance: "1973,10,08",
            telephone: "+(33)6 12 36 54 78",
            email: "jdupont@gmail.com"
        },
        {
            titre: "Mme",
            nom: "Doe",
            prenom: "Jeanne",
            dateNaissance: "1985,02,24",
            telephone: "+(33)6 45 23 87 14",
            email: "jdoe@yahoo.fr"
        },
        {
            titre: "Mr",
            nom: "Martin",
            prenom: "Jacques",
            dateNaissance: "1933,06,22",
            telephone: "+(33)6 78 45 24 95",
            email: "jmartin@petitrapporteur.fr"
        }
    ];
    for (let contact of annuaire) {
        let cTmp = new Contact(contact.titre, contact.nom, contact.prenom,new Date(contact.dateNaissance).toLocaleDateString(),contact.telephone,contact.email);
        contacts.push(cTmp);
    }
    insertList();
}

function insertList(){
    for(let contact of contacts){
        tableau.innerHTML +=`<tr>
                                <td>${contact.titre}</td>
                                <td>${contact.nom}</td>
                                <td>${contact.prenom}</td>
                                <td>${contact.dateNaissance}</td>
                                <td>${contact.telephone}</td>
                                <td>${contact.email}</td>        
                            </tr>`;
    }
}

window.onload = createFakeContact();