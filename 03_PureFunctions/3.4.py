def sortiere_objekte(objekte):
    if len(objekte) <= 1:
        return objekte
    else:
        pivot = objekte[0]
        kleiner_als_pivot = [x for x in objekte[1:] if (x['Datum'], x['Priorität'], x['Titel']) <= (pivot['Datum'], pivot['Priorität'], pivot['Titel'])]
        groesser_als_pivot = [x for x in objekte[1:] if (x['Datum'], x['Priorität'], x['Titel']) > (pivot['Datum'], pivot['Priorität'], pivot['Titel'])]
        return sortiere_objekte(kleiner_als_pivot) + [pivot] + sortiere_objekte(groesser_als_pivot)

# Testet d Funktion mit ere Liste vo Objekte
print("Debug: Sortierte Objekte:", sortiere_objekte([{"Datum": "2023-01-01", "Priorität": 2, "Titel": "A"}, {"Datum": "2023-01-02", "Priorität": 1, "Titel": "B"}]))
