using System;


namespace classMetotDemo
{
	 Class CustomerManager

	{
		public void Add (Customer customer)
		{
        Console.WriteLine("Tebrikler! \n + customer.Name + ");
		}
		public void Delete (Customer customer)
		{
        Console.WriteLine("Sizi kaybettiğimiz için üzgünüz" + customer.Name + " " + "Bankamızdaki hesabınız kapatılmıştır.");
		}
	}
}
