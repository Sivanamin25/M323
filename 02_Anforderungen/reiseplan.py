destinations = []

def add_destination(destination):
    destinations.append(destination)
    print(f"Debug: Added destination {destination}")

def modify_route(old_destination, new_destination):
    try:
        index = destinations.index(old_destination)
        destinations[index] = new_destination
        print(f"Debug: Modified route from {old_destination} to {new_destination}")
    except ValueError:
        print(f"Debug: {old_destination} not in destinations list")

# Beispiele für die Nutzung
add_destination("Paris")
modify_route("Paris", "Berlin")
