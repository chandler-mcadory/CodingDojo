class BankAccount:

    def __init__(self, int_rate = .01, balance = 0): 
        self.int_rate = int_rate
        self.balance = balance

    def deposit(self, amount):
        self.balance += amount
        return self

    def withdraw(self, amount):
        if self.balance > amount:
            self.balance -= amount
        else:
            print("Insufficient funds: Charging a $5 fee")
            self.balance -= 5
        return self

    def display_account_info(self):
        print(self.balance)
        return self

    def yield_interest(self):
        if self.balance > 0:
            self.balance = self.balance * self.int_rate
        return self


max = BankAccount(.02, 1000)

max.deposit(50).deposit(250).deposit(200).withdraw(500).yield_interest().display_account_info()


beltus = BankAccount(.03, 10)

beltus.deposit(50).deposit(250).withdraw(200).withdraw(500).yield_interest().display_account_info()
