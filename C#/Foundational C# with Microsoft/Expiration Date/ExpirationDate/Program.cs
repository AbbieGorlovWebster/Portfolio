using System;

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
if (daysUntilExpiration <= 0)
{
    Console.Write("Your subscription has expired.");
}
else if (daysUntilExpiration <= 1) 
{
    discountPercentage = 20;
    Console.Write($"Your subscription expires within a day!\r\nRenew now and save {discountPercentage}%!\r\n");
}
else if (daysUntilExpiration <= 5) 
{  
    discountPercentage = 10;
    Console.Write($"Your subscription expires in {daysUntilExpiration} days.\r\nRenew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.Write("Your subscription will expire soon. Renew now!");
}