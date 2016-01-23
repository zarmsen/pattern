using System;

namespace Patterns.Core.Game
{
    public abstract class PlayerBase : IEquatable<PlayerBase>
    {
        protected PlayerBase(string name, Position sartPosition)
        {
            Energy = 100;
            Name = name;
            CurrentPosition = sartPosition;
        }

        public string Name { get; }

        public Position CurrentPosition { get; private set; }

        public int Energy { get; set; }

        public WeaponBase Weapon { get; private set; }

        /// <summary>
        ///     Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(PlayerBase other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return string.Equals(Name, other.Name) && Equals(Weapon, other.Weapon);
        }

        public void Move(Position move)
        {
            CurrentPosition = move;
        }

        public virtual void GetHit(HitResult result)
        {
            Energy = result.NewEnergyOfPlayer;
            Console.WriteLine($"Get hit from {result.NameOfWeapon}!!! {ToString()}");
        }

        public virtual void Hit(PlayerBase player)
        {
            if (Weapon != null)
            {
                player.Energy = player.Energy - Weapon.Effect;
            }
        }

        public void SetWeapon(Weapons weapons)
        {
            switch (weapons)
            {
                case Weapons.Axe:
                {
                    Weapon = new Axe();
                    break;
                }
                case Weapons.Gun:
                {
                    Weapon = new Gun();
                    break;
                }
                case Weapons.Sword:
                {
                    Weapon = new Sword();
                    break;
                }
                case Weapons.None:
                {
                    Weapon = null;
                    break;
                }

                case Weapons.All:
                {
                    throw new InvalidOperationException("A player have only one weapon!!!");
                }
            }
        }

        /// <summary>
        ///     Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <returns>
        ///     true if the specified object  is equal to the current object; otherwise, false.
        /// </returns>
        /// <param name="obj">The object to compare with the current object. </param>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != GetType())
            {
                return false;
            }
            return Equals((PlayerBase)obj);
        }

        /// <summary>
        ///     Serves as the default hash function.
        /// </summary>
        /// <returns>
        ///     A hash code for the current object.
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Weapon != null ? Weapon.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(PlayerBase left, PlayerBase right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PlayerBase left, PlayerBase right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return Weapon == null
                ? $"{Name} on Position '{CurrentPosition}' with energy of {Energy} %"
                : $"{Name} - {Weapon} with energy of {Energy} %";
        }
    }
}