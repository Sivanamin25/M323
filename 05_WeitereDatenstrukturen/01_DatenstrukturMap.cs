// Übung 1
val m1: Map[String, String] = Map("key" -> "value")
println(m1) // Ausgabe: Map("key" -> "value")

// Übung 2
val m2 = m1 + ("key2" -> "value2")
println(m2) // Ausgabe: Map("key" -> "value", "key2" -> "value2")

// Übung 3
val m3 = m2 + ("key2" -> "aDifferentValue")
println(m3) // Ausgabe: Map("key" -> "value", "key2" -> "aDifferentValue")

// Übung 4
val m4 = m3 - "key"
println(m4) // Ausgabe: Map("key2" -> "aDifferentValue")

// Übung 5
val valueFromM3: Option[String] = m3.get("key")
println(valueFromM3) // Ausgabe: Some("value")

// Übung 6
val valueFromM4: Option[String] = m3.get("nonExistentKey")
println(valueFromM4) // Ausgabe: None
