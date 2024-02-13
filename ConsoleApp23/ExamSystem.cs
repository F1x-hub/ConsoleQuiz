using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class ExamSystem 
    {
        List<Person> people = new List<Person>()
        {
            new Person(){Name = "Mike", LastName = "jackson"},
            new Person(){Name = "Morty", LastName = "Smith"}
        };

        List<Exam> examList = new List<Exam>()
        {
            new Exam(){Question = "Which ancient civilization developed the first known system of writing?", Answer1 = "Ancient Egypt", Answer2 = "Ancient Greece", Answer3 = "Mesopotamia", Answer4 = "Ancient China", CorrectAnswer = "Mesopotamia"},
            new Exam(){Question = "Who was the first emperor of Rome?", Answer1 = "Julius Caesar", Answer2 = "Augustus", Answer3 = "Nero", Answer4 = "Constantine", CorrectAnswer = "Augustus"},
            new Exam(){Question = "Which event marked the beginning of the Protestant Reformation in Europe?", Answer1 = "The Council of Trent", Answer2 = "The Peace of Augsburg", Answer3 = "The Diet of Worms", Answer4 = "The Edict of Nantes", CorrectAnswer = "The Diet of Worms"},
            new Exam(){Question = "The Magna Carta, signed in 1215, is considered a cornerstone of which principle in English law?", Answer1 = "Habeas corpus", Answer2 = "Rule of law", Answer3 = "Freedom of speech", Answer4 = "Trial by jury", CorrectAnswer = "Rule of law"},
            new Exam(){Question = "Who was the leader of the Bolshevik Revolution in Russia in 1917?", Answer1 = "Vladimir Lenin", Answer2 = "Joseph Stalin", Answer3 = "Leon Trotsky", Answer4 = "Nicholas II", CorrectAnswer = "Vladimir Lenin"},
            new Exam(){Question = "The ancient city of Carthage, a major rival to Rome, was located in modern-day:", Answer1 = "Tunisia", Answer2 = "Greece", Answer3 = "Italy", Answer4 = "Spain", CorrectAnswer = "Tunisia"},
            new Exam(){Question = "The term 'Renaissance' is commonly associated with the revival of interest in which classical civilization?", Answer1 = "Greek", Answer2 = "Roman", Answer3 = "Egyptian", Answer4 = "Mesopotamian", CorrectAnswer = "Roman"},
            new Exam(){Question = "Who was the first European explorer to reach India by sea, establishing direct trade routes between Europe and Asia?", Answer1 = "Vasco da Gama", Answer2 = "Christopher Columbus", Answer3 = "Ferdinand Magellan", Answer4 = "Marco Polo", CorrectAnswer = "Vasco da Gama"},
            new Exam(){Question = "The \"Scramble for Africa\" refers to:", Answer1 = "The partitioning of Africa among European powers in the late 19th century", Answer2 = "The African slave trade during the colonial era", Answer3 = "The decolonization movements in Africa during the 20th century", Answer4 = "The establishment of trading posts along the African coast by Portuguese explorers", CorrectAnswer = "The partitioning of Africa among European powers in the late 19th century"},
            new Exam(){Question = "The Treaty of Versailles, signed in 1919, formally ended which conflict?", Answer1 = "World War I", Answer2 = "Napoleonic Wars", Answer3 = "Hundred Years' War", Answer4 = "World War II", CorrectAnswer = "World War I"},
            new Exam(){Question = "Who was the last pharaoh of ancient Egypt?", Answer1 = "Cleopatra VII", Answer2 = "Tutankhamun", Answer3 = "Ramses II", Answer4 = "Hatshepsut", CorrectAnswer = "Cleopatra VII"},
            new Exam(){Question = "The Gupta Empire is known for its advancements in which field?", Answer1 = "Mathematics", Answer2 = "Architecture", Answer3 = "Philosophy", Answer4 = "Military strategy", CorrectAnswer = "Mathematics"},
            new Exam(){Question = "The Battle of Hastings in 1066 marked the beginning of the Norman conquest of which country?", Answer1 = "England", Answer2 = "France", Answer3 = "Scotland", Answer4 = "Ireland", CorrectAnswer = "England"},
            new Exam(){Question = "The Silk Road was a network of trade routes connecting which two regions?", Answer1 = "Asia and the Mediterranean", Answer2 = "Europe and Africa", Answer3 = "North America and the Middle East", Answer4 = "South America and Asia", CorrectAnswer = "Asia and the Mediterranean"},
            new Exam(){Question = "The Ottoman Empire reached its peak during the reign of which ruler?", Answer1 = "Suleiman the Magnificent", Answer2 = "Mehmed the Conqueror", Answer3 = "Selim the Grim", Answer4 = "Osman I", CorrectAnswer = "Suleiman the Magnificent"},
            new Exam(){Question = "The Meiji Restoration in Japan resulted in:", Answer1 = "The overthrow of the Shogunate and the restoration of imperial rule", Answer2 = "The adoption of Confucianism as the state religion", Answer3 = "The establishment of a military dictatorship", Answer4 = "The division of Japan into feudal territories", CorrectAnswer = "The overthrow of the Shogunate and the restoration of imperial rule"},
            new Exam(){Question = "The term 'Enlightenment' refers to:", Answer1 = "A period of intellectual and philosophical growth in Europe during the 18th century", Answer2 = "The Renaissance period in Italy", Answer3 = "The spread of Christianity in medieval Europe", Answer4 = "The Industrial Revolution in Britain", CorrectAnswer = "A period of intellectual and philosophical growth in Europe during the 18th century"},
            new Exam(){Question = "The French Revolution began with the storming of which famous landmark?", Answer1 = "The Bastille", Answer2 = "The Louvre", Answer3 = "Notre Dame Cathedral", Answer4 = "Palace of Versailles", CorrectAnswer = "The Bastille"},
            new Exam(){Question = "Who was the leader of the Haitian Revolution, which resulted in the first successful slave revolt leading to the establishment of Haiti as an independent nation?", Answer1 = "Toussaint Louverture", Answer2 = "Simon Bolivar", Answer3 = "José de San Martín", Answer4 = "Francisco de Miranda", CorrectAnswer = "Toussaint Louverture"},
            new Exam(){Question = "The Treaty of Tordesillas, signed in 1494, divided newly discovered lands outside Europe between which two countries?", Answer1 = "Spain and Portugal", Answer2 = "England and France", Answer3 = "Netherlands and Italy", Answer4 = "Sweden and Denmark", CorrectAnswer = "Spain and Portugal"},
            new Exam(){Question = "Who was the founder of the Maurya Empire in ancient India?", Answer1 = "Chandragupta Maurya", Answer2 = "Ashoka the Great", Answer3 = "Chandragupta II", Answer4 = "Bindusara", CorrectAnswer = "Chandragupta Maurya"},
            new Exam(){Question = "Which event is often considered the beginning of the Cold War?", Answer1 = "The Cuban Missile Crisis", Answer2 = "The Berlin Blockade", Answer3 = "The Yalta Conference", Answer4 = "The dropping of atomic bombs on Hiroshima and Nagasaki", CorrectAnswer = "The dropping of atomic bombs on Hiroshima and Nagasaki"},
            new Exam(){Question = "The Treaty of Westphalia, signed in 1648, is significant for:", Answer1 = "Ending the Thirty Years' War and establishing the principle of state sovereignty", Answer2 = "Beginning the Protestant Reformation", Answer3 = "Establishing the United Nations", Answer4 = "Ending World War II", CorrectAnswer = "Ending the Thirty Years' War and establishing the principle of state "},
            new Exam(){Question = "Who was the first woman to become Prime Minister of a European country?", Answer1 = "Margaret Thatcher", Answer2 = "Golda Meir", Answer3 = "Angela Merkel", Answer4 = "Indira Gandhi", CorrectAnswer = "Margaret Thatcher"},
            new Exam(){Question = "The construction of the Great Wall of China was primarily aimed at:", Answer1 = "Defending against invasions from northern nomadic tribes", Answer2 = "Establishing trade routes with Central Asia", Answer3 = "Marking the borders of the Chinese empire", Answer4 = "Facilitating communication between different regions of China", CorrectAnswer = "Defending against invasions from northern nomadic tribes"}
        };
        public void QuizMenu()
        {
            int control = 0;
            while(control != 3)
            {
                Console.WriteLine("1. Registration\n2. Join\n3. Exit");
                try
                {
                    control = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
                if (control == 1)
                {
                    Registration();
                }
                if (control == 2)
                {
                    Quiz();
                }

            }
        }
        public void Quiz()
        {
            bool restart = true;
            Person user = Join();
            while (restart != false)
            {
                if (user != null)
                {
                    user.Score = 0;
                    Print(user);
                    if(user.Score < 5)
                    {
                        Console.WriteLine("not enough points, need to try again");
                    }
                    else 
                    {
                        Console.WriteLine("you have passed enough points, congratulations");
                    }
                    Console.WriteLine("Do you want to restart the quiz? (yes/no)");
                    string choise = Console.ReadLine();
                    if (choise == "no")
                    {
                        restart = false;
                    }
                }
                else
                {
                    Console.WriteLine("User not found. Please try again.");
                    break;
                }

            }
            
        }
        public void Registration()
        {
            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter LastName: ");
            string LastName = Console.ReadLine();

            people.Add(new Person() { Name = Name, LastName = LastName});
            Console.WriteLine("Registration Successfully Succeed");
            
        }
        public Person Join()
        {
            Person user = null;
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            foreach (Person people in people)
            {
                if (people.Name.ToLower() == name.ToLower())
                {
                    user = people;
                    break;
                }
            }

            

            return user;

        }
        public void Print(Person user)
        {
            Random random = new Random();
            int answer = 0;
            List<Exam> asketQuestion = new List<Exam>();
            
            for (int i = 0; i < 10; i++)
            {
                int randomIndex = random.Next(0, examList.Count);
                Exam randomExam = examList[randomIndex];
                asketQuestion.Add(randomExam);
                Console.WriteLine($"Question: {randomExam}");
                answer = int.Parse(Console.ReadLine());  
                if(answer == 1)
                {
                    if(randomExam.Answer1 == randomExam.CorrectAnswer)
                    {
                        user.Score++;
                        
                    }
                }
                if (answer == 2)
                {
                    if (randomExam.Answer2 == randomExam.CorrectAnswer)
                    {
                        user.Score++;

                    }
                }
                if (answer == 3)
                {
                    if (randomExam.Answer2 == randomExam.CorrectAnswer)
                    {
                        user.Score++;
                        
                    }
                }
                if (answer == 4)
                {
                    if (randomExam.Answer3 == randomExam.CorrectAnswer)
                    {
                        user.Score++;

                    }
                }
            }
            Console.WriteLine("Do you want see corecct answer? (yes/no)");
            if (Console.ReadLine() == "yes")
            {
                int number = 0;
                foreach (Exam exam in asketQuestion)
                {
                    Console.WriteLine($"{++number}: {exam.CorrectAnswer}\n");
                }
            }
            Console.WriteLine(user);
            
        }
    }
}
