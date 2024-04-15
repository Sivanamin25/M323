# M323
TBZ M323


## Aufgabe 1.1 Bewertung: Pure vs. Impure Funktionen

| Aufgabe | Nur ein Rückgabewert | Resultat nur abhängig von übergebenen Parametern | Verändert keine existierenden Werte | Pure oder Impure |
|---------|:--------------------:|:------------------------------------------------:|:-----------------------------------:|:----------------:|
| 1.1     | Ja                   | Nein                                             | Nein                                | Impure           |

### Erklärung:
- **Nur ein Rückgabewert:** Die Funktion `addToCart` gibt tatsächlich nur einen Wert zurück, den aktualisierten Warenkorb, daher ist dieses Kriterium erfüllt.
- **Resultat nur abhängig von übergebenen Parametern:** Die Funktion `addToCart` hängt von einem externen Zustand (`cartItems`) ab und verletzt damit das Prinzip, dass das Ergebnis nur von den übergebenen Parametern abhängen soll.
- **Verändert keine existierenden Werte:** Die Funktion verändert einen externen Zustand (`cartItems`), indem sie ein neues Element hinzufügt, was das Prinzip verletzt, keine existierenden Werte zu verändern.


## Aufgabe 1.2 Bewertung: Pure vs. Impure Funktionen

| Aufgabe | Nur ein Rückgabewert | Resultat nur abhängig von übergebenen Parametern | Verändert keine existierenden Werte | Pure oder Impure |
|---------|:--------------------:|:------------------------------------------------:|:-----------------------------------:|:----------------:|
| 1.2     | Ja                   | Ja                                               | Ja                                  | Pure             |

### Erklärung:
- **Nur ein Rückgabewert:** Die Funktion `add` gibt einen einzigen Wert zurück, die Summe von `a` und `b`.
- **Resultat nur abhängig von übergebenen Parametern:** Das Ergebnis von `add` hängt ausschließlich von den übergebenen Parametern `a` und `b` ab.
- **Verändert keine existierenden Werte:** Die Funktion `add` verändert keinen externen Zustand oder Werte.

## Aufgabe 1.3 Bewertung: Pure vs. Impure Funktionen

| Aufgabe | Nur ein Rückgabewert | Resultat nur abhängig von übergebenen Parametern | Verändert keine existierenden Werte | Pure oder Impure |
|---------|:--------------------:|:------------------------------------------------:|:-----------------------------------:|:----------------:|
| 1.3     | Nein                   | Ja                                               | Ja                                  | Impure             |

### Erklärung:
- **Nur ein Rückgabewert:** Die Funktion `firstCharacter` gibt den ersten Buchstaben des übergebenen Strings zurück.
- **Resultat nur abhängig von übergebenen Parametern:** Das Ergebnis hängt ausschließlich vom übergebenen Parameter `str` ab.
- **Verändert keine existierenden Werte:** Keine Veränderung externer Zustände oder Werte.

## Aufgabe 1.4 Bewertung: Pure vs. Impure Funktionen

| Aufgabe | Nur ein Rückgabewert | Resultat nur abhängig von übergebenen Parametern | Verändert keine existierenden Werte | Pure oder Impure |
|---------|:--------------------:|:------------------------------------------------:|:-----------------------------------:|:----------------:|
| 1.4     | Ja                   | Nein                                             | Ja                                  | Impure           |

### Erklärung:
- **Nur ein Rückgabewert:** Die Funktion `multiplyWithRandom` gibt einen einzigen Wert zurück, das Produkt von `number` und einem zufälligen Wert.
- **Resultat nur abhängig von übergebenen Parametern:** Das Ergebnis hängt auch von einem nicht vorhersehbaren, zufälligen Wert ab, nicht nur vom übergebenen Parameter.
- **Verändert keine existierenden Werte:** Die Funktion verändert keinen externen Zustand oder Werte, aber ihre Unreinheit ergibt sich aus der Abhängigkeit von einer externen, nicht deterministischen Quelle.


## Aufgabe 2 - Umschreiben von impure zu pure functions

### Aufgabe 1.1 - `addToCart`

**Ursprünglich (Impure):**
- Die Funktion verändert den globalen Zustand `cartItems` durch Hinzufügen eines neuen Elements.

**Transformiert (Pure):**
```javascript
function addToCart(cartItems, item) {
    return [...cartItems, item];
}
