def calculate_discounted_price(price):
    discounted_price = price * 95 / 100
    print(f"Debug: Calculated discounted price is {discounted_price}")
    return discounted_price

original_price = 100
discounted_price = calculate_discounted_price(original_price)
print(f"The discounted price for an original price of {original_price} is {discounted_price}")
