class BankAccount:

    def __init__(self, int_rate = .01, balance = 0): 
        self.int_rate = int_rate
        self.balance = balance

    def deposit(self, amount):
        self.balance += amount
        return self

    def withdraw(self, amount):
        if self.balance >= amount:
            self.balance -= amount
        else:
            print("Insufficient funds: Charging a $5 fee")
            self.balance -= amount
        return self

    def display_account_info(self):
        print(self.balance)
        return self

    def yield_interest(self):
        if self.balance > 0:
            self.balance = self.balance * self.int_rate
            return self
        return self

    def transfer(self, amount, user):
        user.make_deposit(amount)
        self.withdraw(amount)
        return self


class User:
    def __init__(self, name, email):
        self.name = name
        self.email = email
        self.account = BankAccount(int_rate=0.02, balance=0)
    
    def make_deposit(self, amount):
        self.account.deposit(amount)
        return self

    def make_withdrawal(self, amount):
        self.account.withdraw(amount)
        return self

    def display_user_balance(self):
        self.account.display_account_info()
        return self

    def transfer_money(self, amount, user):
        self.account.transfer(amount, user)
        return self



ross = User("John", "j@theman")

hassan = User("Adam", "a@theone")

ross.make_deposit(10001).transfer_money(10000, hassan).display_user_balance()

hassan.make_deposit(100).make_withdrawal(87).display_user_balance()