import java.time.LocalTime

// Aufgabe 1
def wetterFunktion(): (String, LocalTime, Double) = {
  // Hier könnten Logik zur Ermittlung der Wetterbeschreibung, der aktuellen Zeit und der Temperatur stehen
  val wetterBeschreibung = "sonnig"
  val currentTime = LocalTime.now()
  val temperatur = 25.0 // Beispieltemperatur
  (wetterBeschreibung, currentTime, temperatur)
}

// Aufgabe 2
val wetterdaten: List[(String, Double)] = List(
  ("Stadt1", 18.0),
  ("Stadt2", 22.0),
  ("Stadt3", 19.5),
  ("Stadt4", 25.0)
)

def städteWärmerAls(temperatur: Double, daten: List[(String, Double)]): List[String] = {
  daten.filter(_._2 > temperatur).map(_._1)
}

// Zusatzaufgabe
def trending(rates: List[BigDecimal]): Boolean = {
  val pairs = rates.zip(rates.drop(1))
  pairs.forall { case (prevRate, currentRate) => currentRate > prevRate }
}

// Testen der Funktionen
val (wetterBeschreibung, currentTime, temperatur) = wetterFunktion()
println(s"Wetter: $wetterBeschreibung, Zeit: $currentTime, Temperatur: $temperatur")

val wärmereStädte = städteWärmerAls(20.0, wetterdaten)
println(s"Städte wärmer als 20 Grad: $wärmereStädte")

val trend1 = trending(List(BigDecimal(1), BigDecimal(4), BigDecimal(3), BigDecimal(8)))
val trend2 = trending(List(BigDecimal(1), BigDecimal(2), BigDecimal(3), BigDecimal(8)))
println(s"Trend für Daten 1: $trend1")
println(s"Trend für Daten 2: $trend2")
