using System;
using System.IO;

namespace StudentEnrollment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\jctej\Documents\Requirements";

            string[] requiredFiles = // List of required documents
            {
                "GOODMORAL.docx",
                "FORM137.docx",
                "SHSDIPLOMA.docx",
                "PSA.docx",
                "MEDCERT.docx"
            };

            Console.WriteLine("Welcome to the STI website!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your guardian's name: ");
            string guardianName = Console.ReadLine();

            string phoneNumber;
            while (true)
            {
                Console.Write("Enter your phone number (11 digits): ");
                phoneNumber = Console.ReadLine();
                if (phoneNumber.Length == 11 && long.TryParse(phoneNumber, out _))
                    break;
                else
                    Console.WriteLine("Invalid phone number. Please enter a 10-digit number.");
            }

            Console.Write("Enter your address: ");
            string address = Console.ReadLine();

            Console.Write("\nAre you a new or existing student? (New/Existing): ");
            string studentStatus = Console.ReadLine();

            if (studentStatus.Equals("New", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Welcome, new student!");
                Console.Write("Please enter your campus location: ");
                string campusLocation = Console.ReadLine();
                Console.WriteLine($"You are enrolling at the {campusLocation} campus.");

                Console.WriteLine("\nYou need to submit the following documents:");
                foreach (string file in requiredFiles)
                {
                    bool hasFile = false;
                    while (!hasFile)
                    {
                        Console.Write($"Do you have the {Path.GetFileNameWithoutExtension(file)}? (Yes/No): ");
                        string response = Console.ReadLine();
                        if (response.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                        {
                            hasFile = true;
                            Console.WriteLine($"{Path.GetFileNameWithoutExtension(file)} is available.");
                        }
                        else if (response.Equals("No", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Please make sure to obtain the {Path.GetFileNameWithoutExtension(file)}.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid response. Please answer 'Yes' or 'No'.");
                        }
                    }
                }
            }
            else if (studentStatus.Equals("Existing", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Welcome back, existing student!");
                Console.Write("Please enter your campus location: ");
                string campusLocation = Console.ReadLine();
                Console.WriteLine($"You are continuing your studies at the {campusLocation} campus.");
                Console.WriteLine("Since you're already a student, no additional documents are required.");
            }
            else
            {
                Console.WriteLine("Invalid status. Please enter 'New' or 'Existing'.");
                return; // Exit the program if the status is invalid
            }

            Console.WriteLine("\nAvailable courses:");
            Console.WriteLine("1. BSCS (Bachelor of Science in Computer Science) - Focuses on computing theory, programming, and software development.");
            Console.WriteLine("   Benefits: High demand for software developers, opportunities in various tech sectors, strong foundation in computing principles.");
            Console.WriteLine("2. BSIT (Bachelor of Science in Information Technology) - Emphasizes practical IT skills, network management, and system administration.");
            Console.WriteLine("   Benefits: Practical skills for IT roles, preparation for network and systems management, versatile career options in IT support and administration.");

            Console.Write("\nSelect your course: ");
            string course = Console.ReadLine();

            if (course.Equals("BSCS", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"You selected BSCS. This course focuses on computing theory, programming, and software development.");
                Console.WriteLine("Benefits: High demand for software developers, opportunities in various tech sectors, strong foundation in computing principles.");
            }
            else if (course.Equals("BSIT", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"You selected BSIT. This course emphasizes practical IT skills, network management, and system administration.");
                Console.WriteLine("Benefits: Practical skills for IT roles, preparation for network and systems management, versatile career options in IT support and administration.");
            }
            else
            {
                Console.WriteLine("Invalid course selection.");
            }

            Console.Write("\nPayment option (Cash or Installment): ");
            string paymentOption = Console.ReadLine();

            if (paymentOption.Equals("CASH", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You chose to pay in cash. The total is 32,000 pesos.");
                Console.WriteLine("Payment Summary: Total due upon enrollment.");
            }
            else if (paymentOption.Equals("INSTALLMENT", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You chose to pay in installments. Deposit: 10,000 pesos, 6,250 pesos per quarter.");
                Console.WriteLine("Payment Summary: Initial deposit required. Quarterly payments scheduled.");
            }
            else
            {
                Console.WriteLine("Invalid payment option.");
            }

            // Display collected information
            Console.WriteLine("\nRegistration Summary:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Guardian's Name: {guardianName}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Course: {course}");

            // Feedback System
            Console.Write("\nPlease rate your registration experience (1-5): ");
            int rating = int.Parse(Console.ReadLine());
            Console.WriteLine($"Thank you for your feedback! Your rating: {rating}/5");
        }
    }
}
