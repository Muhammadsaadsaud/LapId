# Nutzerverwaltung_LapId

######  Einer JSON-basierten REST-API mit C# zur Nutzerverwaltung

## Voraussetzung
Das folgende Framework, IDE und die folgenden Pakete sind erforderlich, um dieses Projekt auszuführen

- .NET 6 als Framework
-  Visual Studio 2022 17.0 oder eine neuere Version
- "Microsoft.EntityFrameworkCore" Version="6.0.2"
- "Microsoft.EntityFrameworkCore.Design" Version="6.0.2"
- "Microsoft.EntityFrameworkCore.Sqlite" Version="6.0.2"
- "Swashbuckle.AspNetCore" Version="6.2.3"
- C# als Programmiersprache

## Schritte zum Ausführen/Erstellen des Projekts

1. Klonen oder das Projekt aus dem Repository herunterladen
2. API.sln in Visual Studio Öffnen
3. Das Projekt ausführen, indem oben auf die grüne Play Button klicken

## Endpunkte testen

Man kann Postman oder Swagger verwenden, um die Endpunkte zu testen. Hier werde ich erklären, wie man die Endpunkte über Swagger testet

1.  Nach dem Ausführen der Web-App wird im Ausgabefenster von Visual Studio ein localhost-Link angezeigt
2.  https://localhost:{Port}/swagger mit Ihrem Port füllen und in einem Webbrowser ausführen
3.  Hier kann man zwei Abschnitte sehen (Accounts und Users)
4.  Unter Konto sieht man vier Endpunkte, die sich auf das Benutzerkonto beziehen
      * [HttpPost] /api/Account/users  ---> um einen Benutzer zu registrieren/anzulegen
      ```
        {
          "firstname": "Max",
          "lastname": "Mustermann",
          "login": "max_mustermann",
          "password": "123456",
        }

      ```
        Erfolgreiche Erstellung gibt einen Status Code 201 zurück.  
        Bei einem Fehler wird der Status Code 400 angezeigt
      
      * [HttpPut] /api/Account/users/{id}  ---> um einen Benutzer zu bearbeiten/aktualisieren
     ```
        mit Passwort
        {
          "firstname": "Max",
          "lastname": "Mustermann",
          "login": "max_mustermann",
          "password": "123456",
        }
        
        ohne Passwort
        
        {
          "firstname": "Max2",
          "lastname": "Mustermann2",
          "login": "max_mustermann2"
        }

      ```
       Erfolgreiche Erstellung gibt einen Status Code 200 zurück.  
       Bei einem Fehler wird der Status Code 400 angezeigt

## Troubleshoot
- NuGet package restore failed: mögliche Lösung finden Sie [hier](https://stackoverflow.com/questions/52400750/how-to-resolve-nuget-package-restore-failed-in-visual-studio)
- The reference assemblies for .NETFramework,Version=v6.0 were not found: .NET 6 Framework Installieren und versuchen Sie, das Projekt erneut zu starten

