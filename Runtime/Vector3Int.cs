using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vector3Int_UnityEngine = UnityEngine.Vector3Int;

namespace REXTools.TransformTools
{
    [System.Serializable]
    public class Vector3Int : Vector3T<int>
    {
        public Vector3Int_UnityEngine UValue
        {
            get
            {
                return new Vector3Int_UnityEngine(x, y, z);
            }
        }

        public Vector3Int(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //cast constructors
        public Vector3Int (Vector3Int_UnityEngine vector3Int)
        {
            this.x = vector3Int.x;
            this.y = vector3Int.y;
            this.z = vector3Int.z;
        }
        public static implicit operator Vector3Int(Vector3Int_UnityEngine value)
        {
            return new Vector3Int(value.x, value.y, value.z);
        }

        public Vector3Int(Vector3Float vector3Float)
        {
            this.x = RMath.SignFloorToInt(vector3Float.x);
            this.y = RMath.SignFloorToInt(vector3Float.y);
            this.z = RMath.SignFloorToInt(vector3Float.z);
        }
        public static implicit operator Vector3Int(Vector3Float value)
        {
            return new Vector3Int(RMath.SignFloorToInt(value.x), RMath.SignFloorToInt(value.y), RMath.SignFloorToInt(value.z));
        }

        public Vector3Int(Vector2Int vector2Int, int z = 0)
        {
            this.x = vector2Int.x;
            this.y = vector2Int.y;
            this.z = z;
        }
        public static implicit operator Vector3Int(Vector2Int value)
        {
            return new Vector3Int(value.x, value.y, 0);
        }

        public Vector3Int(UnityEngine.Vector2Int vector2Int, int z = 0)
        {
            this.x = vector2Int.x;
            this.y = vector2Int.y;
            this.z = z;
        }
        public static implicit operator Vector3Int(UnityEngine.Vector2Int value)
        {
            return new Vector3Int(value.x, value.y, 0);
        }
    }
}