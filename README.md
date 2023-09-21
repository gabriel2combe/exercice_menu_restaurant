# Flux et Couches de l'application
![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/84d2adfa-5fdd-4672-aad8-aa311b20627d)



# Schema BDD

![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/1527650a-f8ff-457c-ac2e-11c24e88a10e)


# Maquettes
F1 : Liste des restaurants
![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/b86ca0d4-1af4-4043-9b15-75bbac3cdb0f)


F3 : Liste des plats d'un restaurant

![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/80d91c23-b753-4002-8fa7-d10789edb004)


F4 & F5 : Detaille d'un plat & barre de recherche pour ajouter un plat
![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/1091174e-851e-4c35-aeeb-17c2b105179e)


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
## F2 : Ajouter un nouveau restaurant
Apres avoir cliquer sur le bouton de creation de restaurant, l'utilisateur rempli un formulaire avec les champs suivant :
+ Nom du restaurant {Obligatoire}
+ Coordonees du restaurant (adress,ville,pays) {Obligatoire}
+ Categorie {optionnel}
+ Phone {optionnel}
+ Website {optionnel}
+ Image {optionnel}

Si tous les champs sont valides et respectent les contraintes définies dans la BDD <details><summary>Schema Bdd :</summary>

![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/1527650a-f8ff-457c-ac2e-11c24e88a10e)

 </details> 
 ...alors les données sont enregistrées dans la BDD. Si la BDD renvoie une réponse réussie, une confirmation s’affiche pour l’utilisateur qui est redirigé vers la page du nouveau restaurant.



## F4 : Afficher une vue detaillee d'un plat
Sur la page de la liste des plats d'un restaurant *[F3]* , l'utilisateur clique sur l'un des plats, la fenetre du plat s'agrandit et toutes les informations suivantes sont disponibles :
+ Nom
+ Image
+ Categorie
+ Ingredients et quantites

les fenetres des plats doivent rester alignees entre-elles, comme sur la maquette
 <details><summary>Maquette:</summary>
   
![image](https://github.com/gabriel2combe/exercice_menu_restaurant/assets/36897202/1091174e-851e-4c35-aeeb-17c2b105179e)

 </details> 

 Si l'utilisateur click sur un autre plat, la fenetre du plat actuel se reduit et l'autre plat apparait.

