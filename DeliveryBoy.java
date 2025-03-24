public class DeliveryBoy {
    public void requestPayment(Customer customer, float payment) {
        if (customer.makePayment(payment)) {
            System.out.println("Payment  $" + payment + " received " + customer.getFullName());
        } else {
            System.out.println("Insufficient funds!");
        }
    }
}
