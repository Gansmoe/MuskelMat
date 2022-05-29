# MuskelMat

## Install

-> Clone repo <br>
-> In terminal, navigate to MuskelMat-folder <br>
-> run 'npm ci' 


## Start

### Start API
-> Open the project in a code-editor, in AppDbContext.cs and Program.cs, change the path for SQLite data source to where you clone the repository. This is marked with a comment in the code. <br>
-> In terminal, navigate to MuskelMat_backend-folder <br>
-> run 'dotnet run'-command


### To start app
-> In terminal, navigate to MuskelMat-folder <br>
-> run 'npm start' <br>
-> your browser should open automatically <br>
-> to get to app, click the 'App' button in index.html <br>


## Login

There is two logins. One for admin and one for regular user. The only difference is when logged in as admin you can save recipes when clicked the "Kör" button under the "Få din veckomeny"-tab.

-> Username: User *or* Admin
-> Password: Password


=======
-> The context in app.jsx isn't working, thou context is working for DetailedRecipe.jsx is working <br>
-> The logic to get a complete weekly menu isn't written yet. I've started making it. <br>
-> There is nothing indicating that a recipe has been added even thou it is. <br>
-> The button for erasing recipes from saved recipes is still there when you clicked it. <br>


### Troubleshooting

If the database or API-calls isn't working it might be a problem with the database that comes with the repository. If this is the case you can try this:

-> Delete the app.db file in MuskelMat/MuskelMat_backend/DB. <br>
-> In terminal run command *dotnet ef migrations remove* <br>
-> In terminal run command *dotnet ef migrations add [migration-name]* <br>
-> In terminal run command *dotnet ef database update* <br>