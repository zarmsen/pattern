using System;

namespace Patterns.Core.Game
{
    public class PlayerBase : IEquatable<PlayerBase>
    {
        public PlayerBase(string name)
        {
            Energy = 100;
            Name = name;
        }

        public string Name { get; }

        public int Energy { get; set; }

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
            return string.Equals(Name, other.Name);
        }

        public virtual void GetHit(HitResult result)
        {
       
            Energy = result.NewEnergyOfPlayer;
            Console.WriteLine($"Get hit from {result.NameOfWeapon}!!! {ToString()}");
        }

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return $"{Name} with energy of {Energy} %";
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
            return (Name != null ? Name.GetHashCode() : 0);
        }

        public static bool operator ==(PlayerBase left, PlayerBase right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PlayerBase left, PlayerBase right)
        {
            return !Equals(left, right);
        }
    }
}