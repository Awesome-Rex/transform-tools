using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace REXTools.TransformTools
{
    [System.Serializable]
    public class Vector2Bool : Vector2T<bool>
    {
        public Vector2Bool invert
        {
            get
            {
                return new Vector2Bool(!x, !y);
            }
        }

        public bool anyTrue
        {
            get
            {
                return x || y;
            }
        }
        public bool anyFalse
        {
            get
            {
                return !x || !y;
            }
        }

        public Vector2Bool(bool x = false, bool y = false)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2Bool(Vector3Bool vector3Bool)
        {
            this.x = vector3Bool.x;
            this.y = vector3Bool.y;
        }


        public static readonly Vector2Bool truthy = new Vector2Bool(true, true);
        public static readonly Vector2Bool falsey = new Vector2Bool(false, false);
    }
}