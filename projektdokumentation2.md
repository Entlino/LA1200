# Projekt-Dokumentation

Blobfisch - Brandon Spaqi, Mirhan Özden, Lukas Heiniger, Christian Aeschlimann

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   |                                                              |
| 3.11.2022| 0.0.1| Neu entscheid des Projektes                                  |
| 10.11.2022| 0.0.2    | Anfang des neuen PRojekt                                |
| 10.11.2022 | 0.0.3| Projekt ist teilweise Fertig hat aber noch fehler.         |                                                       |

## 1 Informieren

### 1.1 Ihr Projekt

Workshopaufteilungsprogramm

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ | Beschreibung                       |
| ---- | --------------- |-----| ---------------------------------- |
|   1  |       Muss      | FA  | Als ein Benutzer, möchte ich dass das Programm am Anfang fragt ob man ein neues Konto erstellen möchte damit neue Benutzer eins schnell erstellen können|
|   2  |       Muss      | FA  | Als ein Benutzer, möchte ich dass das Programm ein Login hat damit ich nachschauen kann welchen Workshop ich bekommen habe |
|   3  |       Muss      | FA  | Als ein Benutzer, möchte ich dass das Programm die Workshop einschreibungen Fair einteilt werden |
|   4  |       Muss      | FA  | Als ein Benutzer, möchte ich dass das Programm erkennt welche Workshops welche Priorität haben |
|   5  |       Muss      | FA  | Als ein Benutzer, möchte ich dass das Programm mir mitteilt bei welchem Workshop ich zugeteilt wurde sobald es entschieden ist |
|   6  |       Kann      |Quali| Als ein Benutzer, möchte ich dass das Programm mich beim Start begrüsst|
|   7  |       Kann      |Quali| Als ein Benutzer, möchte ich dass das Programm mir die Beliebtesten Workshops anzeigt damit ich rückicht darauf nehmen kann |
|   8  |       Kann      |Quali| Als ein Benutzer, möchte ich dass das Programm zusatzinformationen zu den Workshop hat |
|   9  |       Kann      |Quali| Als ein Benutzer, möchte ich dass das Programm ein Befehl hat mit welchem ich Kontaktdaten erfahre um Feedback zu hinterlassen |
|  10  |       Kann      |Quali| Als ein Benutzer, möchte ich dass das Programm nach dem auswählen der Workshops eine Tempöräre zuordnung anzeigt |
|  11  |       Kann      |Quali| Als ein Benutzer, möchte ich dass das Programm ansprechend aussieht |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm gestartet, Kontoerstellungsfrage gestellt | Ja      | Bitte geben sie ihr Benutzername ein |
| 2.1  | Programm gestartet, Kontoerstellungsfrage gestellt | Nein    | Bitte logen Sie sich ein |
| 3.1  | Programm gestartet, Eingeloggt | Workshop prioritäten gesetzt         | Ihre Priöritäten sind: 1. ...  2. ... 3. ...|
| 4.1  | Programm gestartet | Einloggen         | Sie wurdem den Workshop ... zugeteilt|
| 5.1  |Programm gestartet, Eingeloggt| Workshop auswahl         |Folgende Workshops stehen zur Auswahl; ..., ..., ..., diese drei wurden bis jetzt am meisten gewählt.|
| 6.1  |Programm gestartet, Eingeloggt|Workshop auswählen| In diesem Workshop geht es um...                    |
| 7.1  |Programm gestartet, Eingeloggt|feedback|Hier können die uns kontaktieren: ...|
| 8.1  | Programm gestartet, Eingeloggt |Workshopauswahl abschliessen| Sie wurdem temporär dem Workshop ... zugeteilt|

### 1.4 Diagramme

![MicrosoftTeams-image](https://user-images.githubusercontent.com/111046353/202382363-5f6b3e34-f58b-4711-8ed9-d36a1109e01d.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |Lukas| Konto kann erstellt werden |    45min      |
| 2:A  |       |Lukas| Benutzer kann sich bei einem bestehenden Konto einloggen|    45min     |
| 3.A  |       |Mirhan| Workshop werden angezeigt und können ausgewählt werden|    60min    |
| 4.A  |       |Brandon| Workshops werden fair unter den Anmeldungen ausgeteilt|    90min     |
| 5.A  |       |Christian| Finale zuteilung erfolgt direkt nach dem Entscheid|      45min    |
| 6.A  |       |Lukas| Programm begrüsst einem beim Start|   30min     |
| 7.A  |       |Mirhan| Das Programm zeigt die Beliebtesten Workshops an |   90min   |
| 8.A  |       |Brandon| Das Programm kann bei Interesse zusatzinformationen zu einem bestimmten Workshop angeben |   45min     |
| 9.A  |       |Christian| Es gibt einen Feedback befehl|  30min    |
|10.A  |       |Brandon| Temporäre zuordnung der Workshops |   90min     |
|11.A  |       |Christian| Programm schön darstellen |  90min |

Total: 

## 3 Entscheiden

Wir haben uns nach den Testprotokollen entschieden, uns neu dem Auftrag zu orientieren und von neu den Code zu schreiben. Wir haben die Aufgaben neu aufgeteillt. Christian hatte die Aufgabe zugeordnet bekommen, die Datei einzulesen, Lukas die Aufgabe die Datei auszugeben, Brandon musste die Grenze setzen wieviele einen Kurs besuchen können. Mirhan seine Aufgabe war es die Workshops fair zuzuordnen.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |17.11.2022|Funktioniert Nicht|Christian Aeschlimann|
| 2.1  |17.11.2022|Funktioniert Nicht|Christian Aeschlimann|
| 3.1  |17.11.2022|Funktioniert Nicht|Christian Aeschlimann|
| 4.1  |17.11.2022|Funktioniert Nicht|Christian Aeschlimann|
| 5.1  |17.11.2022|Funktioniert Nicht|Christian Aeschlimann|
| 6.1  |17.11.2022|Funktioniert Nicht|Christian Aeschlimann|
| 7.1  |17.11.2022|Funktioniert Nicht|Christian Aeschlimann|
| 8.1  |17.11.2022|Funktioniert Nicht|Christian Aeschlimann|
| 9.1  |17.11.2022|Funktioniert Nicht|Christian Aeschlimann|
| 10.1 |17.11.2022|Funktioniert Nicht|Christian Aeschlimann|
| 11.1 |17.11.2022|Funktioniert Nicht|Christian Aeschlimann|


Fazit: Wir haben kurz vor Abgabe erfahren das wir die Aufgabe falsch verstanden haben, deshalb haben wir in der letzten R-Sitzung noch Vollgas gegeben und alles neu gemacht, für dass das wir nur 4h Zeit hatten, sind wir sehr Weit gekommen, Was man das nächste mal definitiv besser machen kann ist z. B. von anfang an die Aufgabe mehrfach durchliest um die Aufgabe von anfang an richtig zu Verstehen und um direkt mit Vollgas alles richtig machen können.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |


## 6 Auswerten
