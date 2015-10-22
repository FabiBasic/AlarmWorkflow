# Migration der Datenbank auf Version v0.9.9.0

Beginnend mit der Version v0.9.9.0 hat sich - Codeseitig - der Zugriff auf die Datenbank ge�ndert.

Konkret bedeutet das, dass auf Entity Framework Code First gewechselt wurde, welches einiges an Erleichterung f�r k�nftige Datenbankaktualisierungen bringen wird.

F�r den Anwender bedeutet das, dass die bestehende Datenbank umgestellt werden muss.
Die nachfolgende Anleitung beschreibt die Vorgehensweise.

Es wird davon ausgegangen, dass der Leser Grundkenntnisse von **MySQL Workbench** oder **phpMyAdmin** besitzt.
Diese Anleitung basiert auf der Verwendung von **MySQL Workbench**, m�sste aber auch mit **phpMyAdmin** zu erledigen sein.

# Umstellung der Datenbank

## 1. Sicherung der bestehenden Datenbank

Es empfiehlt sich, dass die bestehende Datenbank umbenannt wird, um Datenverlust zu vermeiden.

Dies kann am einfachsten bewerkstelligt werden, wenn in der Datei **Backend.config** der Wert folgender Einstellung ver�ndert wird:

  <add key="Server.DB.DatabaseName" value="alarmworkflow" />

�ndern Sie den Wert von **"alarmworkflow"** auf beispielsweise **"alarmworkflow_ng"** (f�r _n_ext _g_eneration, ein neutraler Name, kann aber beliebig sein).
So bleibt die bestehende Datenbank erhalten und die Anwendung wird dann die neue Datenbank anlegen.

## 2. Starten des Services

Die neue Datenbankstruktur wird automatisch durch den Code angelegt. Hierzu ist lediglich der Service zu starten.

**Hinweise:**
- Es empfiehlt sich, die Logdateien zu �ffnen, um eventuelle Probleme diagnostizieren zu k�nnen.
- Weiterhin kann dieser Prozess einige Zeit in Anspruch nehmen, aus Erfahrung zwischen einer und 60 Sekunden.

## 3. �bernahme der bestehenden Daten

Sehr wahrscheinlich sind bereits Daten vorhanden, die am besten �bernommen werden sollten.

Dies gelingt sehr einfach mit **MySQL Workbench** in folgenden Schritten:

1. Starten der Anwendung und Anmeldung am Server
2. Navigieren zu "alarmworkflow" -> "operation" (die bestehende Datenbank)
3. Kontextmen� aufrufen und "Select rows" w�hlen (im Deutschen ggf. anders)
4. Im sich �ffnenden Dokument nun auf die Diskette neben "**Export/Import**" (1. Symbol) und die Datei speichern
5. Diesen Vorgang nun Wiederholen f�r die restlichen Tabellen
6. Nachdem alle vier Tabellen exportiert wurden, ist es erforderlich, dass in jeder exportierten Datei die *erste Zeile* gel�scht wird, da sonst der Importer nicht korrekt arbeiten kann!

In der neuen Datenbank m�ssen folgende Schritte f�r jede Tabelle ausf�hren:
1. Kontextmen� aufrufen und "Select rows" w�hlen (im Deutschen ggf. anders)
2. Im sich �ffnenden Dokument nun auf den Ordner neben "**Export/Import**" (2. Symbol) und die exportierte Datei ausw�hlen
3. Der Importvorgang kann ein paar Sekunden dauern. Nach Abschluss ist der aktiv gewordene Button "Apply" zu bet�tigen und das Fenster zu best�tigen.
