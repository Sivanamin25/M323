// Übung 1
val zahlen = List(1, 2, 3, 4, 5)
val summe = zahlen.foldLeft(0)(_ + _)
println(summe) // Ausgabe: 15

// Übung 2
val strings = List("Hallo", " ", "Welt", "!")
val kombiniert = strings.foldLeft("")(_ + _)
println(kombiniert) // Ausgabe: "Hallo Welt!"

// Übung 3
val points = List((1, 3), (2, 5), (4, 8), (6, 2))
val (summeX, summeY) = points.foldLeft((0, 0)) { case ((accX, accY), (x, y)) => (accX + x, accY + y) }
val anzahlPunkte = points.length
val schwerpunkt = (summeX.toDouble / anzahlPunkte, summeY.toDouble / anzahlPunkte)
println(schwerpunkt) // Ausgabe: (3.25, 4.5)
