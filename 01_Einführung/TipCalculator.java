import java.util.List;

public class TipCalculator {

    public static int calculateTipPercentage(List<String> names) {
        if (names.size() == 0) {
            return 0;
        } else if (names.size() <= 5) {
            return 10;
        } else {
            return 20;
        }
    }
}
