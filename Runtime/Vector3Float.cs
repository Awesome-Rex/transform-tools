using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace REXTools.TransformTools
{
    [System.Serializable]
    public class Vector3Float : Vector3T<float>
    {
        public Vector3 UValue
        {
            get
            {
                return new Vector3(x, y, z);
            }
        }

        public Vector3Float(float x = 0, float y = 0, float z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //cast constructors
        public Vector3Float(Vector3 vector3)
        {
            this.x = vector3.x;
            this.y = vector3.y;
            this.z = vector3.z;
        }
        public static implicit operator Vector3Float(Vector3 value)
        {
            return new Vector3Float(value.x, value.y, value.z);
        }

        public Vector3Float(Vector3Int vector3Int)
        {
            this.x = vector3Int.x;
            this.y = vector3Int.y;
            this.z = vector3Int.z;
        }
        public static implicit operator Vector3Float(Vector3Int value)
        {
            return new Vector3Float(value.x, value.y, value.z);
        }

        public Vector3Float(UnityEngine.Vector3Int vector3Int)
        {
            this.x = vector3Int.x;
            this.y = vector3Int.y;
            this.z = vector3Int.z;
        }
        public static implicit operator Vector3Float(UnityEngine.Vector3Int value)
        {
            return new Vector3Float(value.x, value.y, value.z);
        }

        public Vector3Float(Vector2Float vector2Float, float z = 0)
        {
            this.x = vector2Float.x;
            this.y = vector2Float.y;
            this.z = z;
        }
        public static implicit operator Vector3Float(Vector2Float value)
        {
            return new Vector3Float(value.x, value.y, 0f);
        }
    }
}