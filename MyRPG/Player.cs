namespace MyRPG
{
    public class Player
    {
        //Variaveis de instancia Privada 
        private int xp;
        private float health;

        //Propriedade auto-implementada
        public string Name { get; }
        
        //Aumentar o valor de Xp
        public int XP
        {
            get => xp;
            set
            {
                if (value > xp) xp = value;
            }
        }

        //Leitura de Level 
        public int Level
        {
            get => 1 + (xp / 1000);
        }

        // Controlar o valor de health entre 0 e MaxHealth

        public float Health
        {
            get => health;
            set
            {
                health = value;
                if (health > MaxHealth) health = MaxHealth;
                if (health < 0) health = 0;
            }
        }
        
        // Calcular MaxHealth
        public float MaxHealth
        {
            get => 100f + (Level - 1) * 20f;
        }
    
        public Player(string name)
        {
            this.Name = name;
            xp = 0;
            Health = MaxHealth;
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;
            XP += (int)damage / 20;
        }

    }
}