def summe_von_liste(zahlen, index=0):
    # Prüeft, ob mer am Ändi vo dr Liste aacho sind
    if index == len(zahlen):
        return 0
    else:
        # Rekursivs Addiere vom aktuelle Element mit dr Summe vom Rescht vo dr Liste
        return zahlen[index] + summe_von_liste(zahlen, index + 1)

# Debug: Testet d Funktion mit ere Liste vo Zahlen
print("Debug: Summe von Liste:", summe_von_liste([1, 2, 3, 4, 5]))
