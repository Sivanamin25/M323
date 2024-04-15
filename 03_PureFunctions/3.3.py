def sortiere_strings(strings):
    # Wenn d Liste leer isch oder nur es Element het, isch si scho sortiert
    if len(strings) <= 1:
        return strings
    else:
        pivot = strings[0]
        # Teil d Liste in zwei, abhängig devoo, ob s Element grösser oder chliiner als s Pivot isch
        kleiner_als_pivot = [x for x in strings[1:] if x <= pivot]
        groesser_als_pivot = [x for x in strings[1:] if x > pivot]
        # Sortiert rekursiv di zwei Teilliste und tüe si mit em Pivot zäme
        return sortiere_strings(kleiner_als_pivot) + [pivot] + sortiere_strings(groesser_als_pivot)

# Debug: Testet d Funktion mit ere Liste vo Strings
print("Debug: Sortierte Strings:", sortiere_strings(["b", "a", "c", "e", "d"]))
