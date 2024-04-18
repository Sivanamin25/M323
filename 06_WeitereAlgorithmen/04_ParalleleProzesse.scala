

// 1. Code:
for {
    _ <- IO.sleep(1.second)
    result <- List(rollDice(), rollDice()).parSequence
} yield result.sum
// Beschreibung: Dieser Code führt zwei Würfelwürfe parallel aus und summiert die Ergebnisse nach einer Sekunde Wartezeit.
// Er verwendet die Funktion `IO.sleep` zum Warten und `List.parSequence` für die parallele Ausführung.

// 2. Code:
for {
    storedCasts <- Ref.of[IO, List[Int]](List.empty)
    singleCast = rollDice()
    .flatMap(result => storedCasts.update(_.appended(result)))
    _ <- List(singleCast, singleCast).parSequence
    casts <- storedCasts.get
} yield casts
// Beschreibung: Dieser Code erstellt eine Referenz für eine leere Liste von Würfelergebnissen.
// Dann führt er zwei Würfelwürfe aus, fügt die Ergebnisse der Liste hinzu und gibt die Liste der Würfelergebnisse zurück.
// Der Code verwendet `Ref.of` für die Erstellung der Referenz und `List.parSequence` für die parallele Ausführung.

// 3. Code:
for {
    storedCasts <- Ref.of[IO, List[Int]](List.empty)
    singleCast = rollDice()
    .flatMap(result => storedCasts.update(_.appended(result)))
    _ <- List.fill(3)(singleCast).parSequence
    casts <- storedCasts.get
} yield casts
// Beschreibung: Dieser Code funktioniert ähnlich wie der vorherige, aber er führt drei Würfelwürfe aus.
// Es verwendet auch `Ref.of` für die Erstellung der Referenz und `List.fill` für die Wiederholung der Würfelwürfe.

// 4. Code:
for {
    storedCasts <- Ref.of[IO, Int](0)
    singleCast = rollDice().flatMap(result => if (result == 6) storedCasts.update(_ + 1) else IO.unit)
    _ <- List.fill(100)(singleCast).parSequence
    casts <- storedCasts.get
} yield casts
// Beschreibung: Dieser Code zählt die Anzahl der Würfe mit einem Ergebnis von 6 in einer parallelen Ausführung von 100 Würfen.
// Er verwendet `Ref.of` für die Erstellung der Referenz, `List.fill` für die Wiederholung der Würfe und `if` für die Bedingung.

// 5. Code:
List.fill(100)(IO.sleep(1.second).flatMap(_ => rollDice())).parSequence.map(_.sum)
// Beschreibung: Dieser Code führt 100 Würfelwürfe mit einer Sekunde Verzögerung zwischen ihnen aus und summiert die Ergebnisse.
// Er verwendet `List.fill` für die Wiederholung der Würfe, `IO.sleep` für die Verzögerung und `List.parSequence` für die parallele Ausführung.
