using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace REXTools.TransformTools
{
    [System.Serializable]
    public class Vector2Float : Vector2T<float>
    {
        public Vector2 UValue
        {
            get
            {
                return new Vector3(x, y);
            }
        }

        public Vector2Float(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }

        //cast constructors
        public Vector2Float(Vector2 vector2)
        {
            this.x = vector2.x;
            this.y = vector2.y;
        }
        public static implicit operator Vector2Float(Vector2 value)
        {
            return new Vector2Float(value.x, value.y);
        }

        public Vector2Float(Vector2Int vector2Int)
        {
            this.x = vector2Int.x;
            this.y = vector2Int.y;
        }
        public static implicit operator Vector2Float(Vector2Int value)
        {
            return new Vector2Float(value.x, value.y);
        }

        public Vector2Float(UnityEngine.Vector2Int vector2Int)
        {
            this.x = vector2Int.x;
            this.y = vector2Int.y;
        }
        public static implicit operator Vector2Float(UnityEngine.Vector2Int value)
        {
            return new Vector2Float(value.x, value.y);
        }

        public Vector2Float(Vector3Float vector3Float)
        {
            this.x = vector3Float.x;
            this.y = vector3Float.y;
        }
        public static implicit operator Vector2Float(Vector3Float value)
        {
            return new Vector2Float(value.x, value.y);
        }
    }
}