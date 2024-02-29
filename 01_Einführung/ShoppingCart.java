import java.util.ArrayList;
import java.util.List;

public class ShoppingCart {
    private List<String> items;
    private boolean bookAdded;

    public ShoppingCart() {
        this.items = new ArrayList<>();
        this.bookAdded = false;
    }

    public void addItem(String item) {
        items.add(item);
        if (item.equalsIgnoreCase("book")) {
            bookAdded = true;
        }
    }

    public void removeItem(String item) {
        items.remove(item);
        if (item.equalsIgnoreCase("book") && !items.contains("book")) {
            bookAdded = false;
        }
    }

    public List<String> getItems() {
        return items;
    }

    public double getDiscountPercentage() {
        return bookAdded ? 5.0 : 0.0;
    }
}

class ShoppingCartFunctional {

    public static double getDiscountPercentage(List<String> items) {
        return items.stream().anyMatch(item -> item.equalsIgnoreCase("book")) ? 5.0 : 0.0;
    }
}
