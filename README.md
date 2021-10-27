# Adress-DB
Adress-Datenbank für Unternehmen
Die Adress-DB wurde aus verschiedenen Gründen entwickelt und bietet folgende Funktionen:
- es wird eine Datei für DocuWare erzeugt mit den Namen der Geschäftspartner sowie deren Kunden-/Lieferanten-/Leadnummern. 
  Es können in DocuWare nur Dokumente zu einem Geschäftspartner abgelegt werden, wenn dieser zuvor in der Datenbank erfasst wurde.
  (somit wird verhindert, dass Dokumente unter "Testfirma GmbH", "Testfirma AG", "Testfirma", etc abgelegt werden - immer der gleiche Name! 
- Die Datenbank vergibt zentral Kunden- und Lieferantennummern. Diese werden im ERP-System oder DATEV weiterverarbeitet (keine anderen Listen mehr!)
- Vorlagen wie Briefe, Faxe, Angebote, etc. werden immer mit gleichen Firmennamen, Namen des Geschäftspartners erzeugt. Keine falschen Schreibweisen/Anschreiben mehr.
  Über die Sachbearbeiter-Daten(bank) werden die Vorlagen neben den Kontaktdaten auch mit den persönlichen Informationen ergänzt (Datum, Durchwahl, Position, etc.)
- Über eine Historie ist auf die Schnelle zu sehen, welche Dokumente bereits für den Geschäftspartner erstellt wurden.
- Alle Kontakte werden zudem zentral erfasst und jeder kann die benötigten Kontakte in sein persönliches Outlook übertragen.
  Telefonanrufe können per Link (zB. per BusinessCTI) direkt aus der Datenbank gestartet werden, Email werden direkt erzeugt.

Die Adress-DB speichert die Daten auf einem SQL-Server. 

<img src="https://github.com/OliverHannover/Adress-DB/blob/master/Screenshots/Adress-DB.PNG" alt="0" style="max-width:100%;">

<img src="https://github.com/OliverHannover/Adress-DB/blob/master/Screenshots/outlook.PNG" alt="0" style="max-width:100%;">

<img src="https://github.com/OliverHannover/Adress-DB/blob/master/Screenshots/fax.PNG" alt="0" style="max-width:100%;">
