// See https://aka.ms/new-console-template for more information

using practice;

var b = new BillingInfo();
b.BillingStartDate = new DateTime(1996, 03, 22);
b.BillingFrequencyInMonths = 12;
var NextBillingDate = b.BillingStartDate;

//while(NextBillingDate < DateTime.Now)
//{
//    NextBillingDate = NextBillingDate.AddMonths(b.BillingFrequencyInMonths);
//}

NextBillingDate = new DateTime(NextBillingDate.Year, NextBillingDate.Month, b.BillingStartDate.Day);
DateTime.Today.AddMonths(b.BillingFrequencyInMonths);

