namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{
            //    DateTime currentDate = DateTime.Now;

            //    Console.WriteLine("Текущая дата:");
            //    Console.WriteLine(currentDate.ToString("dd.MM.yyyy"));
            //    Console.WriteLine(currentDate.ToString("dd MMM yyyy"));
            //    Console.WriteLine(currentDate.ToString("dd MMMM yyyy 'г.'"));
            //    Console.WriteLine(currentDate.ToString("ddd, dd MMM yyyy"));
            //    Console.WriteLine(currentDate.ToString("dddd, dd MMMM yyyy"));

            //    Console.WriteLine("\nТекущее время:");
            //    Console.WriteLine(currentDate.ToString("HH:mm:ss"));
            //    Console.WriteLine(currentDate.ToString("HH:mm"));

            //    Console.WriteLine("\nТекущая дата и время:");
            //    Console.WriteLine(currentDate.ToString("dd.MM.yyyy HH:mm:ss"));
            //    Console.WriteLine(currentDate.ToString("dd MMMM yyyy 'г.' HH:mm"));
            //    Console.WriteLine(currentDate.ToString("dd MMMM yyyy 'г.' HH:mm:ss"));
            //    Console.WriteLine(currentDate.ToString("ddd, dd MMM yyyy HH:mm:ss GMT"));
            //    Console.WriteLine(currentDate.ToString("yyyy-MM-ddTHH:mm:ss"));

            {
                //Console.WriteLine("Введите свой возраст:");


                //if (int.TryParse(Console.ReadLine(), out int age))
                //{

                //    int currentYear = DateTime.Now.Year;


                //    int birthYear = currentYear - age;


                //    Console.WriteLine($"Ты родился в {birthYear} году.");
                //}
                //else
                //{
                {
                    Console.WriteLine("Введите год своего рождения:");

                    
                    if (int.TryParse(Console.ReadLine(), out int birthYear))
                    {
                        
                        int currentYear = DateTime.Now.Year;

                        
                        int age = currentYear - birthYear;

                        
                        Console.WriteLine($"Ваш возраст: {age} лет.");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректный год рождения в виде числа.");
                    }
                }
            }
            Console.ReadKey();
                }
            }
        }
        
            
        
    
    
