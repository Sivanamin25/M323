import cats.effect.IO
import scala.util.Random

// Impure Funktion, die eine Zufallszahl von 1 bis 6 zurückgibt
def rollDiceImpure(): Int = {
  val random = new Random
  random.nextInt(6) + 1
}

// Definition der pure Funktion mit IO-Monade
def rollDice(): IO[Int] = {
  IO.delay(rollDiceImpure())
}

// Beispielaufruf
val result = rollDice().unsafeRunSync()
println(s"Der Würfel zeigt: $result")
