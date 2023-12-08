using ObserverTask;

CashDrawer cashDrawer = new CashDrawer();

ICashDrawerObserver registerDisplay = new CashRegisterDisplay();
ICashDrawerObserver cashierApp = new CashierApp();


cashDrawer.AddObserver(registerDisplay);
cashDrawer.AddObserver(cashierApp);


cashDrawer.AddMoney(50.0m);


cashDrawer.RemoveObserver(cashierApp);


cashDrawer.AddMoney(20.0m);