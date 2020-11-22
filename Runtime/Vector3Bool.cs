using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace REXTools.TransformTools
{
    [System.Serializable]
    public class Vector3Bool : Vector3T<bool>
    {
        public Vector3Bool invert
        {
            get
            {
                return new Vector3Bool(!x, !y, !z);
            }
        }

        public bool anyTrue
        {
            get
            {
                return x || y || z;
            }
        }
        public bool anyFalse
        {
            get
            {
                return !x || !y || !z;
            }
        }
        
        public Vector3Bool (bool x = false, bool y = false, bool z = false)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3Bool (Vector2Bool vector2Bool, bool z = false)
        {
            this.x = vector2Bool.x;
            this.y = vector2Bool.y;
            this.z = z;
        }


        public static readonly Vector3Bool truthy = new Vector3Bool(true, true, true);
        public static readonly Vector3Bool falsey = new Vector3Bool(false, false, false);
    }
}
