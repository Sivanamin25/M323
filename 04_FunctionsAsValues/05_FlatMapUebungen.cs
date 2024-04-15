// Übung 1
val listen = List(List(1, 2), List(3, 4), List(5, 6))
val verdoppelt = listen.flatMap(_.map(_ * 2))
println(verdoppelt) // Ausgabe: List(2, 4, 6, 8, 10, 12)

// Übung 2
val personen = List(("Max", List("Blau", "Grün")), ("Anna", List("Rot")), ("Julia", List("Gelb", "Blau", "Grün")))
val einzigartigeFarben = personen.flatMap(_._2).distinct
println(einzigartigeFarben) // Ausgabe: List("Blau", "Grün", "Rot", "Gelb")
