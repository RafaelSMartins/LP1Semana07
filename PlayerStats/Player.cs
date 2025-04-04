using System;

namespace PlayerStats
{
    public class Player
    {
        // Variáveis de instância
        private float highScore;
        private int playedGames;
        private int wonGames;

        // Propriedade HighScore
        public float HighScore
        {
            get => highScore;
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }

        // Propriedade auto-implementada Name
        public string Name { get; }

        // Propriedade WinRate
        public float WinRate
        {
            get
            {
                if (playedGames == 0)
                {
                    return 0;
                }

                return (float)wonGames / playedGames;
            }
        }

        // Construtor
        public Player(string name)
        {
            Name = name;
            highScore = 0;
            playedGames = 0;
            wonGames = 0;
        }

        // Método PlayGame
        public void PlayGame(bool win)
        {
            playedGames++;
            if (win)
            {
                wonGames++;
            }
        }
    }
}