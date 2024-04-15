// Übung 1
val zahlen = List(1, 2, 3, 4, 5)
val geradeZahlen = zahlen.filter(_ % 2 == 0)
println(geradeZahlen) // Ausgabe: List(2, 4)

// Übung 2
val namen = List("Alice", "Bob", "Charlie", "Diana")
val langeNamen = namen.filter(_.length > 4)
println(langeNamen) // Ausgabe: List("Alice", "Charlie", "Diana")

// Übung 3
val zahlen2 = List(12, 45, 68, 100)
val grosseZahlen = zahlen2.filter(_ > 50)
println(grosseZahlen) // Ausgabe: List(68, 100)

// Übung 4
val woerter = List("Scala", "ist", "fantastisch")
val startMitS = woerter.filter(_.startsWith("S"))
println(startMitS) // Ausgabe: List("Scala")

// Übung 5 (filter und map)
case class Buch(titel: String, autor: String, jahr: Int)
val buecher = List(
  Buch("1984", "George Orwell", 1949),
  Buch("Brave New World", "Aldous Huxley", 1932),
  Buch("Fahrenheit 451", "Ray Bradbury", 1953)
)
val aeltereBuecher = buecher.filter(_.jahr < 1950).map(_.titel)
println(aeltereBuecher) // Ausgabe: List("1984", "Brave New World")