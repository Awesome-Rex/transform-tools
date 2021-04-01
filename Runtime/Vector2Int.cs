using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vector2Int_UnityEngine = UnityEngine.Vector2Int;

namespace REXTools.TransformTools
{
    [System.Serializable]
    public class Vector2Int : Vector2T<int>
    {
        public Vector2Int_UnityEngine UValue
        {
            get
            {
                return new Vector2Int_UnityEngine(x, y);
            }
        }

        public Vector2Int(Vector2T<int> vector)
        {
            this.x = vector.x;
            this.y = vector.y;
        }

        public Vector2Int(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        //cast constructors
        public Vector2Int(Vector2Int_UnityEngine vector2Int)
        {
            this.x = vector2Int.x;
            this.y = vector2Int.y;
        }
        public static implicit operator Vector2Int(Vector2Int_UnityEngine value)
        {
            return new Vector2Int(value.x, value.y);
        }

        public Vector2Int(Vector2Float vector2Float)
        {
            this.x = RMath.SignFloorToInt(vector2Float.x);
            this.y = RMath.SignFloorToInt(vector2Float.y);
        }
        public static implicit operator Vector2Int(Vector2Float value)
        {
            return new Vector2Int(RMath.SignFloorToInt(value.x), RMath.SignFloorToInt(value.y));
        }

        public Vector2Int(Vector3Int vector3Int)
        {
            this.x = vector3Int.x;
            this.y = vector3Int.y;
        }
        public static implicit operator Vector2Int(Vector3Int value)
        {
            return new Vector2Int(value.x, value.y);
        }

        public Vector2Int(UnityEngine.Vector3Int vector3Int)
        {
            this.x = vector3Int.x;
            this.y = vector3Int.y;
        }
        public static implicit operator Vector2Int(UnityEngine.Vector3Int value)
        {
            return new Vector2Int(value.x, value.y);
        }
    }
}