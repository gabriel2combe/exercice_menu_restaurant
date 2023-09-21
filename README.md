# Flux et Couches de l'application.
![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/c1193040-c178-4574-8be1-cabaebb3b8a3)



# Schema BDD
![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/1efff5f4-b814-49ec-9e85-5c787c861f7a)


# Maquettes
F1 : Liste des restaurants
![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/7df29314-c317-4eb8-9860-24d2053067b8)


F3 : Liste des plats d'un restaurant
![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/aba0ca9e-a298-4740-b817-26fa0da46ab8)


F4 & F5 : Detaille d'un plat & barre de recherche pour ajouter un plat
![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/24589b58-733f-4020-891a-50409b449462)


# Liste des Fonctionnalites

|Fonctionnalite| En tant que  | je souhaites  | afin de  |   | Notes : |
|---|---|---|---|---|---|
|F1| Gerant de restaurant | voir la liste de mes restaurants  | gerer les menus dans l'application Web  |   |   |
|F2| Gerant de restaurant | ajouter un restaurant  | gerer son menu dans l'application Web  |   |   |
|F3| Gerant de restaurant | voir les plats de mon restaurant  | gerer l'offre de mon restaurant  |   | Nom + image du plat  |
|F4| Gerant de restaurant | voir une vue detaillee d'un plat  | pouvoir le preparer |   | Nom, Image, Categorie, Ingredient et quantites  |
|F5| Gerant de restaurant | ajouter un plat au menu d'un de mes restaurants  | le proposer a mes clients | | Plat doit etre disponible sur l'api themealdb.com |
|   |   |   |   |   |

# Specifications des Fonctionnalites
## F2 Ajouter un nouveau restaurant
Apres avoir cliquer sur le bouton de creation de restaurant, l'utilisateur rempli un formulaire avec les champs suivant :
+ Nom du restaurant {Obligatoire}
+ Coordonees du restaurant (adress,ville,pays) {Obligatoire}
+ Categorie {optionnel}
+ Phone {optionnel}
+ Website {optionnel}
+ Image {optionnel}

Si tous les champs sont valides et respectent les contraintes définies dans la BDD <details><summary>Schema Bdd :</summary>
![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/1efff5f4-b814-49ec-9e85-5c787c861f7a)
 </details> 
 ...alors les données sont enregistrées dans la BDD. Si la BDD renvoie une réponse réussie, une confirmation s’affiche pour l’utilisateur qui est redirigé vers la page du nouveau restaurant.



## F4 Afficher une vue detaillee d'un plat
Sur la page de la liste des plats d'un restaurant *[F3]* , l'utilisateur clique sur l'un des plats, la fenetre du plat s'agrandit et toutes les informations suivantes sont disponibles :
+ Nom
+ Image
+ Categorie
+ Ingredients et quantites

les fenetres des plats doivent rester alignees entre-elles, comme sur la maquette
 <details><summary>Maquette:</summary>
   
![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/24589b58-733f-4020-891a-50409b449462)


 </details> 

 Si l'utilisateur click sur un autre plat, la fenetre du plat actuel se reduit et l'autre plat apparait.

