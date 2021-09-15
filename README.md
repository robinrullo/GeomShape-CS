# GeomShape
Fil rouge de 2ème année en C#

## Lancement
Le projet utilise docker. Le projet est configuré en environnement de développement. Pour le lancer:
```bash
docker-compose up --build -d
```

## Migrations (BDD)
La base de données est créée par le conteneur db (MySQL) de docker.
- Si le volume n'existe pas, il sera automatiquement créé.
- Si elle existe déjà, exécuter une migration manuelle avec l'outil [dotnet-ef](https://docs.microsoft.com/fr-fr/ef/core/cli/dotnet)

Créer une nouvelle migration (développeurs):
```bash
dotnet-ef migrations add <migration_name> --project Entities -s GeomShapeServer
```

Générer un nouveau script SQL (**_MySQL_Init_Script/init.sql**):
```bash
dotnet-ef migrations script --project Entities -s GeomShapeServer
```

Appliquer manuellement la migration à la bdd:
```bash
dotnet-ef database update --project Entities -s GeomShapeServer
```
Nb: On peut ajouter `--verbose` aux commandes.

## API
| ⚠️ Non implémenté. |
|--------------------|


Actions de l'API à implémenter et documenter:
- READ: Return drawing shapes
- UPDATE/DELETE: in one shape of the collection.
- CREATE: any shape

## TODO:
- BackEnd
  - [X] ⛳ Créer le projet
  - [X] ⚠️ Créer un logger (p:LoggerService)
  - [X] ⛳ Créer les models/entités (p:Entities)
  - [X] ⛳ Créer un Repository (p: Repository)
  - [X] Créer un projet ASPNET Web Server (p:GeomShapeServer)
  - [X] ⛳ "Dockeriser" le projet
  - [X] ⛳ Ajouter un conteneur pour la base de donnée MySQL
  - [X] ⛳ Ajouter MySQL dans le projet
  - [ ] ⛳ ⚠️ \-- EN COURS \-- Créer / Récupérer les formes depuis les dessins
  - [ ] ⛳ \-- EN COURS \-- Créer des controlleurs - VOIR API
  - [ ] ⛳️ Calculer l'aire et le périmètre de chaque figure géométrique instanciée
  - [ ] ⛳️ Créer des formes 3D
  - [ ] ⛳️ Documenter l'API
  - [ ] ⏱️️ Utiliser les variables d'environnement Docker pour configurer les applications .NET/React
  - [ ] 
- FrontEnd
  - [X] ⛳ Créer une ReactApp
  - [X] ⛳ Build et deploy automatique par ASPNET (p:GeomShapeServer)
  - [ ] ⛳ Afficher les détails de la composition (Drawing)
  - [ ] ⛳ CRUD des formes dans une composition (Drawing)
  - [ ] ⛳ Afficher les aires et périmètres de la composition
  
⚠️: Ne fonctionne pas / pas comme attendu
⛳️: Attendu
⏱️: En plus