using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Handan";
            customer1.Lastname = "Altuner";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Akif";
            customer2.Lastname = "Başak";
            customer2.City = "Ankara";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Serap";
            customer3.Lastname ="Gümüş";
            customer3.City = "İzmir";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name ="Ali";
            customer4.Lastname ="Yılmaz";
            customer4.City = "Ankara"; 

            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4};

            Console.WriteLine("Adınız");
            string name = Console.ReadLine();

            foreach (var Customer in customers)

	            {
                    if (name == "Handan")
	                    {
                            Console.WriteLine(name+ "Bankamıza hoşgeldiniz.");
                            Console.WriteLine("Lütfen yapacağınız işlemi seçiniz.");
                            Console.WriteLine("Yeni Hesap : 1\" + "Hesap Silme : 2");
                                
                            int secim = Convert.ToInt32(Console.ReadLine());
                            CustomerManager manager = new CustomerManager();
                            if (secim == 1)
	                            {
                                    manager.Add(customer1);
	                            }
                            else
	                            {
                                    manager.Delete(customer1);
	                            }
                            break;


	                    }

                    if (name == "Akif")
	                    {
                            Console.WriteLine((name+ "Bankamıza hoşgeldiniz.");
                            Console.WriteLine("Lütfen yapacağınız işlemi seçiniz.");
                            Console.WriteLine("Yeni Hesap : 1\" + "Hesap Silme : 2");
                                
                            int secim = Convert.ToInt32(Console.ReadLine());
                            CustomerManager manager = new CustomerManager();
                            if (secim == 1)
	                            {
                                    manager.Add(customer2);
	                            }
                            else
	                            {
                                    manager.Delete(customer2);
	                            }
                            break;


	                    }

                    
                    
                    if (name == "Serap")
	                    {
                            Console.WriteLine((name+ "Bankamıza hoşgeldiniz.");
                            Console.WriteLine("Lütfen yapacağınız işlemi seçiniz.");
                            Console.WriteLine("Yeni Hesap : 1\" + "Hesap Silme : 2");
                                
                            int secim = Convert.ToInt32(Console.ReadLine());
                            CustomerManager manager = new CustomerManager();
                            if (secim == 1)
	                            {
                                    manager.Add(customer3);
	                            }
                            else
	                            {
                                    manager.Delete(customer3);
	                            }
                            break;


	                    }

                    
                    if (name == "Ali")
	                    {
                            Console.WriteLine((name+ "Bankamıza hoşgeldiniz.");
                            Console.WriteLine("Lütfen yapacağınız işlemi seçiniz.");
                            Console.WriteLine("Yeni Hesap : 1\" + "Hesap Silme : 2");
                                
                            int secim = Convert.ToInt32(Console.ReadLine());
                            CustomerManager manager = new CustomerManager();
                            if (secim == 1)
	                            {
                                    manager.Add(customer4);
	                            }
                            else
	                            {
                                    manager.Delete(customer4);
	                            }
                            break;


	                    }

                        else
                         {

                          Console.WriteLine(name + "Yeni hesap işlemine hoşgeldiniz.");
                          Console.WriteLine("Soyadınız : ");
                          string LastName = Console.ReadLine();
                          Console.WriteLine("Şehir : ");
                          string City = Console.ReadLine();
                          Customer.Name = name;
                          Customer.Lastname = LastName;
                          Customer.City = City;
                          Console.WriteLine("Yeni Hesbınız oluşturuldu. Teşekkürler");
                          break;

                          }
    





	            }





            Console.ReadLine();
        }
    }
}
