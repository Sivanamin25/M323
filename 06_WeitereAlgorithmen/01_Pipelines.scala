// Gegebene Kurse
case class Course(title: String, students: List[String])

val courses = List(
    Course("M323", List("Peter", "Petra", "Paul", "Paula")),
    Course("M183", List("Paula", "Franz", "Franziska")),
    Course("M117", List("Paul", "Paula")),
    Course("M114", List("Petra", "Paul", "Paula"))
)

// Filtern und Transformieren der Kurse
val resultPeter = courses
  .filter(_.students.contains("Peter"))
  .map(course => s"Peter besucht folgende Module: ${course.title}")

val resultPetra = courses
  .filter(_.students.contains("Petra"))
  .map(course => s"Petra besucht folgende Module: ${course.title}")

// Ausgabe der Ergebnisse
println(resultPeter)
println(resultPetra)
