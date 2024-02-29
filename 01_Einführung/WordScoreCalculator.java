public class WordScoreCalculator {

    public static void main(String[] args) {
        System.out.println("Imperativer Stil:");
        System.out.println("Score of 'imperative': " + calculateScore("imperative"));
        System.out.println("Score of 'no': " + calculateScore("no"));

        System.out.println("\nDeklarativer Stil:");
        System.out.println("Score of 'declarative': " + wordScore("declarative"));
        System.out.println("Score of 'yes': " + wordScore("yes"));
    }

    public static int calculateScore(String word) {
        int score = 0;
        for (char c : word.toCharArray()) {
            if (c != 'a') {
                score++;
            }
        }
        return score;
    }

    public static int wordScore(String word) {
        return (int) word.chars()
                .filter(c -> c != 'a')
                .count();
    }
}
