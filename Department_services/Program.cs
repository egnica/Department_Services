using System;

namespace Assignment_3_march_26
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            string employeeName;
            int departmentNumber;
            int hourlySal;
            int hoursWorked;
            int EXIT = 10;
            string [] department = {"1 Personnel", "2 Marketing", "3 Manufacturing", "4 Computer Services", "5 Sales", "6 Accounting", "7 Shipping"};
            int [] hoursCount = {0, 0, 0, 0, 0, 0, 0};
            int [] rateCount = {0, 0, 0, 0, 0, 0, 0};
          //  int [] totalCount = {0, 0, 0, 0, 0, 0, 0};
          //  int totalSum;

            //Primer + looping for departments
            System.Console.WriteLine("Please enter the number of the department you work for 1-7");
             for(var i = 0; i < department.Length; i++){
                System.Console.WriteLine($"Department:{department[i]}");
            }
            
            //Enter department
            departmentNumber = Convert.ToInt32(System.Console.ReadLine());
            while(departmentNumber != EXIT){
                
                //Resets the index number back to '0'
                departmentNumber = departmentNumber - 1;


                System.Console.WriteLine("Please enter your name");
                employeeName = System.Console.ReadLine();

                System.Console.WriteLine("Please enter your hourly salary");
                hourlySal = Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine("Please enter how many hours you worked");
                hoursWorked = Convert.ToInt32(System.Console.ReadLine());

              //  totalSum = hourlySal*hoursWorked;

                //entering numbers into the array or adding to array for hours, rate, and total
                if(hoursCount[departmentNumber] == 0){
                hoursCount[departmentNumber] =+ hoursWorked; 
                }else{
                    hoursCount[departmentNumber] = hoursCount[departmentNumber] + hoursWorked;
                }

               if(rateCount[departmentNumber] == 0){
                   rateCount[departmentNumber] =+ hourlySal;
               }else{
                    rateCount[departmentNumber] = rateCount[departmentNumber] + hourlySal;
               }

        /*       if(totalCount[departmentNumber] == 0){
                   totalCount[departmentNumber] =+  totalSum;
               }else{
                    totalCount[departmentNumber] = totalCount[departmentNumber] +  totalSum;
               }
            
        */
               
                System.Console.WriteLine("To continue, please type the number of your department. To exit, please type '10'");
                departmentNumber = Convert.ToInt32(System.Console.ReadLine());

            
            }
            System.Console.WriteLine("Thank you ");
            for(var z = 0; z < department.Length; z++){
                
                System.Console.WriteLine($"{department[z]} Total Hours: {hoursCount[z]} hours. Total Rate: ${rateCount[z]} Total Gross Payroll ${hoursCount[z]*rateCount[z]}");
                }
            }    
        
        
    }
}
