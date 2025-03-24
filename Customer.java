public class Customer {
    private String firstName;
    private String lastName;
    private Wallet myWallet;

    public Customer(String firstName, String lastName, float initialBalance) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.myWallet = new Wallet(initialBalance);
    }

    public String getFullName() {
        return firstName + " " + lastName;
    }

    public boolean makePayment(float amount) {
        return myWallet.subtractMoney(amount);
    }

    public void addMoneyToWallet(float amount) {
        myWallet.addMoney(amount);
    }
}