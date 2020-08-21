using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace REXTools.TransformTools
{
    [System.Serializable]
    public class Vector2Bool
    {
        public bool x;
        public bool y;

        public Vector2Bool invert
        {
            get
            {
                return new Vector2Bool(!x, !y);
            }
        }

        public Vector2Bool(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2Bool(Vector3Bool vector3Bool)
        {
            this.x = vector3Bool.x;
            this.y = vector3Bool.y;
        }

        public Vector2Bool OperateBool(System.Func<Axis, bool, bool> operation)
        {
            return new Vector2Bool(
                operation(Axis.X, x),
                operation(Axis.Y, y)
            );
        }
        public Vector2Bool OperateBool(Vector2Bool b, System.Func<Axis, bool, bool, bool> operation)
        {
            return new Vector2Bool(
                operation(Axis.X, x, b.x),
                operation(Axis.Y, y, b.y)
            );
        }

        public Vector2 Operate(System.Func<Axis, bool, float> operation)
        {
            return new Vector2(
                operation(Axis.X, x),
                operation(Axis.Y, y)
            );
        }
        public Vector2 Operate(Vector2Bool b, System.Func<Axis, bool, bool, float> operation)
        {
            return new Vector2(
                operation(Axis.X, x, b.x),
                operation(Axis.Y, y, b.y)
            );
        }


        public bool GetAxis(Axis axis)
        {
            if (axis == Axis.X)
            {
                return x;
            }
            else if (axis == Axis.Y)
            {
                return y;
            }

            return default;
        }

        public Vector2Bool SetAxis(Axis axis, bool value)
        {
            if (axis == Axis.X)
            {
                return new Vector2Bool(value, y);
            }
            else if (axis == Axis.Y)
            {
                return new Vector2Bool(x, value);
            }

            return default;
        }
    }
}