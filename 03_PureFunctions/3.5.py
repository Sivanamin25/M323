def lese_blaetter(baum):
    if isinstance(baum, dict):
        # Wenn s es Blatt isch, füeg s zur Liste zue
        if 'Kinder' not in baum or not baum['Kinder']:
            return [baum['Wert']]
        else:
            # Wenn s Kinder het, goht wiiter dur d Kinder
            blätter = []
            for kind in baum['Kinder']:
                blätter += lese_blaetter(kind)
            return blätter
    elif isinstance(baum, list):
        # Wenn d Struktur e Liste vo Kinder isch, behandlet jedes als eigene Baum
        blätter = []
        for element in baum:
            blätter += lese_blaetter(element)
        return blätter
    else:
        # Basissfall: Wenn s kei Baum isch, sondern direkt es Blatt
        return [baum]
    

# Debug: Testet d Funktion mit eme einfache Baum
print("Debug: Gelesene Blätter:", lese_blaetter({"Wert": "Root", "Kinder": [{"Wert": "Blatt1"}, {"Wert": "Blatt2"}]}))


# Komplexere Baum :D
komplexer_baum = {
    "Wert": "Root",
    "Kinder": [
        {
            "Wert": "Knoten1",
            "Kinder": [
                {"Wert": "Blatt1"}
            ]
        },
        {
            "Wert": "Knoten2",
            "Kinder": [
                {"Wert": "Knoten3", "Kinder": [{"Wert": "Blatt2"}, {"Wert": "Blatt3"}]},
                {"Wert": "Blatt4"}
            ]
        }
    ]
}

# Debug: Testet d Funktion mit eme komplexe Baum
print("Debug: Gelesene Blätter:", lese_blaetter(komplexer_baum))
