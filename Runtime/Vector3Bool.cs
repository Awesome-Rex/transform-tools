using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace REXTools.TransformTools
{
    [System.Serializable]
    public struct Vector3Bool
    {
        public bool x;
        public bool y;
        public bool z;
        
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

        public Vector3Bool OperateBool(System.Func<Axis, bool, bool> operation)
        {
            return new Vector3Bool(
                operation(Axis.X, x),
                operation(Axis.Y, y),
                operation(Axis.Z, z)
            );
        }
        public Vector3Bool OperateBool(Vector3Bool b, System.Func<Axis, bool, bool, bool> operation)
        {
            return new Vector3Bool(
                operation(Axis.X, x, b.x),
                operation(Axis.Y, y, b.y),
                operation(Axis.Z, z, b.z)
            );
        }

        public Vector3 Operate(System.Func<Axis, bool, float> operation)
        {
            return new Vector3(
                operation(Axis.X, x),
                operation(Axis.Y, y),
                operation(Axis.Z, z)
            );
        }
        public Vector3 Operate(Vector3Bool b, System.Func<Axis, bool, bool, float> operation)
        {
            return new Vector3(
                operation(Axis.X, x, b.x),
                operation(Axis.Y, y, b.y),
                operation(Axis.Z, z, b.z)
            );
        }


        public bool GetAxis(Axis axis)
        {
            if (axis == Axis.X)
            {
                return x;
            } else if (axis == Axis.Y)
            {
                return y;
            } else if (axis == Axis.Z)
            {
                return z;
            }

            return default;
        }

        public Vector3Bool SetAxis(Axis axis, bool value)
        {
            if (axis == Axis.X)
            {
                return new Vector3Bool(value, y, z);
            }
            else if (axis == Axis.Y)
            {
                return new Vector3Bool(x, value, z);
            }
            else if (axis == Axis.Z)
            {
                return new Vector3Bool(x, y, value);
            }

            return default;
        }



        public static readonly Vector3Bool truthy = new Vector3Bool(true, true, true);
        public static readonly Vector3Bool falsey = new Vector3Bool(false, false, false);
    }
}
