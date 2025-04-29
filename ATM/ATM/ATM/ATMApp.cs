using ATM.Database;
using ATM.Exceptions;
using ATM.Models;
using ATM.Services;
using ATM.Utils;

namespace ATM
{
    class ATMApp
    {
        static void Main(string[] args)
        {
            var atm = new ATMMachine();
            var server = new Server();
            var service = new ATMService(atm, server);

           
            Logger.LogInfo("Welcome to the ATM Machine");

            try
            {
                string cardNumber = UserInterface.GetCardNumber();
                Account account = AccountDatabase.FindAccountByCardNumber(cardNumber);
                UserInterface.TryValidatePin(account,service);               
                decimal amount = UserInterface.GetWithdrawalAmount();
                service.Withdraw(account, amount);
                Logger.LogSuccess($"Withdrawal successful! Remaining Balance: {account.Balance}");
            }
            catch (DailyLimitExceededException ex)
            {
                Logger.LogError(ex.Message);
            }
            catch (InsufficientFundsException ex)
            {
                Logger.LogError(ex.Message);
            }
            catch (ServerConnectionException ex)
            {
                Logger.LogError(ex.Message);
            }
            catch(CardBlockedException ex)
            {
                Logger.LogError(ex.Message);
            }
            catch (Exception ex)
            {
                Logger.LogError("Unexpected error: " + ex.Message);
            }
        }
    }
}
