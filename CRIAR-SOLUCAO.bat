@echo off
dotnet new sln -n Atividades-MVC-LuizSilvino
for /r %%f in (*.csproj) do dotnet sln Atividades-MVC-LuizSilvino.sln add "%%f"
echo.
echo Solucao criada: Atividades-MVC-LuizSilvino.sln
pause
