using System;

namespace Entities
{
    public class Reward : IEquatable<Reward>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ID
        {
            get;
            set;
        }
        public override int GetHashCode()
        {
            return this.Title.GetHashCode();
        }

        public bool Equals(Reward other)
        {
            if (other == null)
                return false;
            if ((ID == other.ID))
                return true;
            else
                return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Reward pObj = obj as Reward;
            if (pObj == null)
                return false;
            else
                return Equals(pObj);
        }

        public static bool operator ==(Reward p1, Reward p2)
        {
            if (((object)p1) == null || ((object)p2) == null)
                return Object.Equals(p1, p2);

            return p1.Equals(p2);
        }

        public static bool operator !=(Reward p1, Reward p2)
        {
            return !(p1 == p2);
        }

    }
}
