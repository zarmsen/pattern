namespace Patterns.Core.Game
{
    public class HitResult
    {
        public HitResult(PlayerBase player, WeaponBase weapon)
        {
            var newEnergy = player.Energy - weapon.Effect;
            var deathValue = 0;
            Damage = newEnergy <= deathValue ? deathValue : newEnergy;
            NameOfWeapon = weapon.Name;
        }

        public string NameOfWeapon { get; private set; }

        public int Damage { get; private set; }
    }
}