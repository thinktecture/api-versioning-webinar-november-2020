# Einzelschritte / Steps

## Branch start-new-project

Erzeuge ein neues WebApi Projekt, und installiere die notwendigen Abhängigkeiten von NuGet. Zur Nachvollziehbarkeit werden die SDK Version und alle Paket Versionen fest gepinnt.

Commandline:

```shell
dotnet new webapi -n ApiVersioning
cd ApiVersioning
dotnet add package Microsoft.AspNetCore.Mvc.Versioning -v 5.0.0-preview.2
dotnet add package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer -v 5.0.0-preview.2
```

## Branch add-basic-versioning

1. Versionierungs-Funktionalität zum Startup hinzugefügt, die Versionsinfo bei Swagger aktualisiert und dem Standard-Controller über ein Attribut die Version 1.0 zugewiesen.
2. Zwei neue Beispiel-Controller hinzugefügt mit einem versionierten Endpunkt.
3. Neuer Controller mit zwei unterschiedlichen Versionen des gleichen Endpunkts hinzugefügt.
