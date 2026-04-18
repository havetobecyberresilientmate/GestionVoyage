# GestionVoyage ✈️

## Description
Projet C# de gestion de voyages permettant de modéliser des clients, des réservations, des voyages, des paiements et des destinations.

Motivation :
- J’ai choisi ce thème car il est concret, facile à comprendre et permet de modéliser plusieurs concepts importants de la programmation orientée objet comme l’héritage et les relations entre classes.

Le projet utilise la programmation orientée objet avec :
- héritage
- classes
- relations entre objets

---

## UML
Le diagramme UML du projet est disponible dans le fichier :
`diagramme.png`

---

## Structure
- Voyage (classe abstraite)
- Vol
- Hotel
- Client
- Reservation
- Paiement
- Destination
- Bagage

---

## Lancer le projet
bash
dotnet run

---

## Entités
| Entité      | Attributs                     | Comportements          |
| ----------- | ----------------------------- | ---------------------- |
| Client      | nom, prénom, email, téléphone | reserver(), annuler()  |
| Voyage      | destination, dateDepart, prix | afficherDetails()      |
| Vol         | numeroVol, compagnie          | afficherDetails()      |
| Hotel       | nomHotel, nombreNuits         | afficherDetails()      |
| Reservation | dateReservation, statut       | confirmer(), annuler() |
| Paiement    | montant, date, methode        | effectuerPaiement()    |
| Destination | nom, pays, description        | afficher()             |
| Bagage      | poids, type                   | verifierPoids()        |

---

## Relations

# Héritage

* Vol hérite de Voyage
* Hotel hérite de Voyage

# Associations

* Reservation possède un Client
* Reservation possède un Voyage
* Paiement possède une Reservation
* Voyage possède une Destination

# Méthode redéfinie

* afficherDetails() est définie dans Voyage et redéfinie dans Vol et Hotel

