def mittelwert_von_liste(zahlen, index=0, summe=0):
    # Prüeft, ob mer am Ändi vo dr Liste aacho sind
    if index == len(zahlen):
        return summe / len(zahlen) if len(zahlen) > 0 else 0
    else:
        # Rekursivs Addiere vom aktuelle Element zur Summe und erhöht den Index
        return mittelwert_von_liste(zahlen, index + 1, summe + zahlen[index])

# Debug: Testet d Funktion mit ere Liste vo Zahlen
print("Debug: Mittelwert von Liste:", mittelwert_von_liste([1, 2, 3, 4, 5]))
