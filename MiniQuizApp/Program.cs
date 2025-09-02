using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();
            quiz.Start();

            List<Question> questions = new List<Question>
            {
                new Question(" Hangisi, Leonardo da Vinci'nin en ünlü eserlerinden biri değildir?", new string[] { "Mona Lisa", "Son Akşam Yemeği", "İnci Küpeli Kız", "Vitruvius Adamı" }, 2),
                new Question("Güneş Sistemi'mizdeki en büyük gezegen hangisidir?", new string[] { "Satürn", "Jüpiter", "Neptün", "Dünya" }, 1),
                new Question("Dönüşüm (Die Verwandlung) adlı novella kime aittir?", new string[] { "Albert Camus", "Franz Kafka", "Fyodor Dostoyevski", "Virginia Woolf" }, 1),
                new Question("Aşağıdaki ülkelerden hangisi bir kıtadan oluşan tek ülkedir?", new string[] { "Rusya", "Kanada", "Avustralya", "Çin" }, 2),
                new Question("Hangi elementin kimyasal sembolü Au dur?", new string[] { "Gümüş", "Altın", "Argon", "Alüminyum" }, 1),
                new Question("Hangisi, William Shakespeare'in bir trajedisi değildir?", new string[] { "Hamlet", "Macbetch", "Fırtına", "Kral Lear" }, 2),
                new Question(" Osmanlı İmparatorluğu'nun kurucusu kimdir?", new string[] { "Orhan Gazi", "Osman Gazi", "I. Mehmed(Çelebi)", "I.Murad(Hüdavendigar)" }, 1),
                new Question(" Hangi besteci, Klasik Müziğin Üç B'si olarak anılan isimlerden biri değildir?", new string[] { " Ludwig van Beethoven", "Johann Sebastian Bach", "Johannes Brahms", " Frédéric Chopin" }, 3),
                new Question(" Hangisi, bir Türkiye cumhurbaşkanı değildir?", new string[] { "Turgut Özal", "Süleyman Demirel", "Bülent Ecevit", "Abdullah Gül" }, 2),
                new Question("Hangi şehir, aynı zamanda bir kıtanın adıdır?", new string[] { "Sidney", "Melbourne", "Adelaide", "Ankara" }, 0),
            };

            int score = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                Question q = questions[i];

                Console.WriteLine($"{i + 1}. {q.Text}");
                for (int j = 0; j < q.Options.Length; j++)
                {
                    Console.WriteLine($"{j + 1}) {q.Options[j]}");
                }

                Console.Write("Cevabınız (1-4): ");
                int answer = int.Parse(Console.ReadLine()) - 1;

                if (answer == q.CorrectAnswer)
                {
                    Console.WriteLine("Doğru! ✅");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Yanlış ❌ Doğru cevap: {q.Options[q.CorrectAnswer]}");
                }
            }

            Console.WriteLine($"Quiz bitti! Skorunuz: {score}/{questions.Count}");


        }
    }

    class Quiz
    {
        public void Start()
        {
            Console.WriteLine("Welcome to the Mini Quiz App!");
        }
    }
}
