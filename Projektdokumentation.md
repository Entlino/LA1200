# LA1200
# Projekt-Dokumentation

Blobfisch: Aeschlimann, Özden, Heiniger, Spaqi

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |                 |      | Als ein Benutzer, möchte ich dass das Program ein Login hat um meinen Stand zu speichern |
| 2    |                 |      | Als ein Benutzer, möchte ich dass das Program die verschienden Workshops anzeigt|
| 3    |                 |      | Als ein Benutzer, möchte ich dass das Program verschiende Prioritäten erkennt|
| 4    |                 |      | Als ein Benutzer, möchte ich dass das Program anzeigt welcher Workshop am beliebtesten ist|
| 6    |                 |      | Als ein Benutzer, möchte ich dass das Program ein Feedbackfeld hat um anregungen zu hinterlassen |
| 7    |                 |      | Als ein Benutzer, möchte ich dass das Program mir sagt wo ich zugeteilt wurde|
| 8    |                 |      | Als ein Benutzer, möchte ich dass das Program mir zusatzinformationen zu den Workshops gibt|
| 9    |                 |      | Als ein Benutzer, möchte ich dass das Program mir temporäre Workshops zuordnet|
  
✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Computer fragt nach Login-Daten             | B.Peter.inf@stud.bbbaden.ch        | B.Peter.inf@stud.bbbaden.ch                  |
| 1.2  | Computer fragt nach Login-Daten             | Passwort        | ******                  |
| 2.1  | Computer zeigt Workshops an             | Workshops        | zeigt Workshops                  |
| 2.2  | Computer zeigt Workshops an             | Tech-Workshop        | Sie haben "Tech-Workshop" ausgewählt.                  |
| 3.1  | Computer erkennt Prioritäten             | 0 / 1 / 2        | Sie haben Fitness auf 0; ... auf 1; ... auf 2; Priorität gesetzt                   |
| 4.1  | Computer zeigt top 5 beliebte Workshops an             | Top5 beliebte Workshops        | zeigt beliebte Workshops                  |
| 5.1  | Computer fragt nach Feedback nach             | guter Workshop        | Danke, für ihr Feedback                  |
| 6.1  | Computer zeigt mir meine Zuteilung an             | meine Zuteilung        | zeigt zuteilung von ihnen                  |
| 7.1  | Computer zeigt Zusatzdetails zu den Workshops an             | Zusatzinformationen von Fitness       | zeigt Zusatzinformationen von Fitness                 |
| 8.1  | Computer ordnet mich in temporäre Workshops zu             | 0; Fitness        | temporär zu Fitness zugeteilt                  |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       | Lukas     | Der Benutzer kann sich einen Account erstellen (Passwort, Benutzername etc.) | 45min         |
| 2.A  |       | Lukas     | Der Benutzer kann sich einlogen mit seinem Account und sein Passwort und andere Daten ändern kann falls etwas falsch wäre.| 60min         |
| 3.A  |       | Mirhan   | Herausfinden wie man Priritäten setzen kann und wie man Arrays am besten verwenden kann| 25min         |
| 4.A  |       | Mirhan          | Der Benutzer kann seine Mail und seine Prioritäteten eintragen| 50min         |
| 5.A  |       | Mirhan          | Die Einträge werden gespeichert             | 45min         |
| 6.A  |       | Christian/Mirhan | Herausfinden wie man die Prioritäten vergleichen kann mit Mirhan besprechen und im erklären| 45min/ 10min|
| 7.A  |       | Christian          | Feedbackfeld erstellen und eine Art Visitenkarte der Leitung der App| 45min              |
| 8.A  |       | Brandon          | Der Benutzer kann zu allen Workshops Informationen abfragen.| 45min              |
| 9.A  |       | Brandon          | Informationen können als Dokument gedownloaded werden            | 45min              |
| 10.A  |       | Christian          |  Temporäre Einteilung in die Workshops| 45min              |
| 11.A  |       | Brandon          | Auflistung wer und bei welchem Workshop fest eingetragen wurde.             | 45min              |
| 12.A  |       | Lukas          | Liste der Belibtesten Workshops und deren Anzahl an Mitglieder| 45min              |
| 13.A  | Falls Zeit übrig      | Christian          | Grafische überarbeitung| 45min              |
| 14.A  |       |           |              | 45min             |
| 15.A  |       |           |              | 45min              |
| 16.A  |       |           |              | 45min              |
| 17.A  |       |           |              | 45min              |
| 18.A  |       |           |              | 45min             |
| 19.A  |       |           |              | 45min              |
| 20.A  |       |           |              | 45min              |
| 21.A  |       |           |              | 45min              |
| 22.A  |       |           |              | 45min             |
| 23.A  |       |           |              | 45min              |
| 24.A  |       |           |              | 45min              |
| 25.A  |       |           |              | 45min              |
| 26.A  |       |           |              | 45min              |
| 27.A  |       |           |              | 45min              |
| 28.A  |       |           |              | 45min              |
| 29.A  |       |           |              | 45min              |
Total: 


✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden
In unserem Programm haben wir als Gruppe entschieden

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
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
