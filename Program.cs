using Banco;

var account = new BankAccount("Igor Cabila", 1000);
Console.WriteLine($"Account {account.Number} was create for {account.Owner} with {account.Balance} Initial balance");
account.MakeWithdrawal(500,DateTime.Now, "Rend payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(2000, DateTime.Now, "Frient paid me back");
Console.WriteLine(account.Balance);
Console.WriteLine(account.GetAccountHistory());


Console.WriteLine("--------------GiftCard--------------------");
var giftCard = new GiftCardAccount("gift card", 1000, 500);
giftCard.MakeWithdrawal(20, DateTime.Now, "get exponsive coffee");
giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
giftCard.PerformMonthEndTransactions();
giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
Console.WriteLine(giftCard.GetAccountHistory());

Console.WriteLine("--------------InterestEarningAccount--------------------");
var savings = new InterestEarningAccount("savings account", 10000);
savings.MakeDeposit(750, DateTime.Now, "Save some money");
savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
savings.MakeWithdrawal(250, DateTime.Now, "Need to pay monthly bills");
savings.PerformMonthEndTransactions();
Console.WriteLine(savings.GetAccountHistory());

Console.WriteLine("--------------LIneOfCredit--------------------");
var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out  monthly advance");
lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
lineOfCredit.PerformMonthEndTransactions();
Console.WriteLine(lineOfCredit.GetAccountHistory());





