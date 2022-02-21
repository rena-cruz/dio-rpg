namespace rpg.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType) 
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Name = string.Empty;
        public int Level;
        public string HeroType = string.Empty;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name  + " Atacou com a sua espada ";
        }
    }
}