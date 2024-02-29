def calculate_total_time(lap_times):
    total_time = sum(lap_times[1:])  
    print(f"Debug: Total time excluding warm-up lap is {total_time}")
    return total_time

def calculate_average_lap_time(lap_times):
    if len(lap_times) > 1:
        average_time = sum(lap_times[1:]) / (len(lap_times) - 1)
    else:
        average_time = 0
    print(f"Debug: Average lap time excluding warm-up lap is {average_time}")
    return average_time

lap_times = [120, 110, 115, 113]
calculate_total_time(lap_times)
calculate_average_lap_time(lap_times)
