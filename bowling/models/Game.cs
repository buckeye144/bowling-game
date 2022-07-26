using System;

namespace Models
{
    class Game
    {
        private static Random rand = new Random();
        private static int frame = 1;
        private static int ball = 0;
        private static int score = 0;
        private static int pins = 10;
        private static bool extraBall = false;

        public static void game()
        {
            reset();
            while(frame <= 10)
            {
                int tempScore = 0;
                Console.WriteLine("Frame: " + frame);
                Console.WriteLine("Score: " + score);
                while (ball < 2)
                {
                    Console.WriteLine("Ball: " + (ball + 1));
                    Console.WriteLine("1) Roll Ball");
                    Console.WriteLine("2) Cheat");
                    Console.WriteLine("3) Loser");

                    String input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            int pinsHit = rand.Next(pins);
                            tempScore += pinsHit;
                            if (tempScore == 10)
                            {
                                lastFrame();
                            }
                            Console.WriteLine("");
                            Console.WriteLine("Hit " + pinsHit + " pins!");
                            pins -= pinsHit;
                            ball++;
                            break;
                        case "2":
                            tempScore = 0;
                            score += 10;
                            lastFrame();
                            break;
                        case "3":
                            tempScore = 0;
                            ball = 2;
                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("Not a valid command");
                            break;
                    }

                    if (ball >= 2)
                    {
                        score += tempScore;
                    }
                }
                frame++;
                ball = 0;
                pins = 10;
            }
            Console.WriteLine("");
            Console.WriteLine("Game Over!");
            Console.WriteLine("Final Score: " + score);
        }

        private static void lastFrame()
        {
            if (frame == 10)
            {
                if (extraBall)
                {
                    extraBall = false;
                    ball = 2;
                }
                else 
                {
                    extraBall = true;
                    ball = 1;
                    pins = 10;
                }
            }
            else 
            {
                ball = 2;
            }
        }

        private static void reset()
        {
            frame = 1;
            ball = 0;
            score = 0;
            pins = 10;
            extraBall = false;
        }
    }
}