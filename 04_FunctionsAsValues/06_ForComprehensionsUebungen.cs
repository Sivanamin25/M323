// Übung 1
val quadrierteZahlen = for {
  zahl <- 1 to 10
} yield zahl * zahl

println(quadrierteZahlen) // Ausgabe: Vector(1, 4, 9, 16, 25, 36, 49, 64, 81, 100)

// Übung 2
val geradeZahlen = for {
  zahl <- 1 to 20
  if zahl % 2 == 0
} yield zahl

println(geradeZahlen) // Ausgabe: Vector(2, 4, 6, 8, 10, 12, 14, 16, 18, 20)

// Übung 3
val colors = List("Red", "Green", "Blue")
val fruits = List("Apple", "Banana", "Orange")

val paare = for {
  color <- colors
  fruit <- fruits
} yield (color, fruit)

println(paare) // Ausgabe: List((Red,Apple), (Red,Banana), (Red,Orange), (Green,Apple), (Green,Banana), (Green,Orange), (Blue,Apple), (Blue,Banana), (Blue,Orange))

// Übung 4
case class User(name: String, tasks: List[String])

val users = List(
  User("Alice", List("Task 1", "Task 2", "Task 3")),
  User("Bob", List("Task 1", "Task 4", "Task 5")),
  User("Charlie", List("Task 2", "Task 3", "Task 6"))
)

val tasksCompleted = List("Task 1", "Task 3", "Task 5")

val pendingTasks = for {
  user <- users
  task <- user.tasks
  if !tasksCompleted.contains(task)
} yield (user.name, task)

println(pendingTasks) // Ausgabe: List((Alice,Task 2), (Alice,Task 3), (Bob,Task 4), (Charlie,Task 2), (Charlie,Task 6))
