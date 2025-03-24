public class Wallet {
    private float value;

    public Wallet(float initialBalance) {
        this.value = initialBalance;
    }

    public boolean subtractMoney(float debit) {
        if (value >= debit) {
            value -= debit;
            return true;
        }
        return false;
    }

    public void addMoney(float deposit) {
        value += deposit;
    }
}