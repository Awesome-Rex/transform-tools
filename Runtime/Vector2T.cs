using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace REXTools.TransformTools
{
    [System.Serializable]
    public class Vector2T<T>
    {
        public T x;
        public T y;

        public Vector2T(T x = default, T y = default)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2T(Vector3T<T> vector3T)
        {
            this.x = vector3T.x;
            this.y = vector3T.y;
        }

        public Vector2Bool OperateBool(System.Func<Axis, T, bool> operation)
        {
            return new Vector2Bool(
                operation(Axis.X, x),
                operation(Axis.Y, y)
            );
        }
        public Vector2Bool OperateBool(Vector2T<T> b, System.Func<Axis, T, T, bool> operation)
        {
            return new Vector2Bool(
                operation(Axis.X, x, b.x),
                operation(Axis.Y, y, b.y)
            );
        }

        public Vector2 OperateFloat(System.Func<Axis, T, float> operation)
        {
            return new Vector2(
                operation(Axis.X, x),
                operation(Axis.Y, y)
            );
        }
        public Vector2 OperateFloat(Vector2T<T> b, System.Func<Axis, T, T, float> operation)
        {
            return new Vector2(
                operation(Axis.X, x, b.x),
                operation(Axis.Y, y, b.y)
            );
        }

        public Vector2T<T> Operate(System.Func<Axis, T, T> operation)
        {
            return new Vector2T<T>(
                operation(Axis.X, x),
                operation(Axis.Y, y)
            );
        }
        public Vector2T<T> Operate(Vector2T<T> b, System.Func<Axis, T, T, T> operation)
        {
            return new Vector2T<T>(
                operation(Axis.X, x, b.x),
                operation(Axis.Y, y, b.y)
            );
        }

        public Vector3T<TR> Operate<TR>(System.Func<Axis, T, TR> operation)
        {
            return new Vector3T<TR>(
                operation(Axis.X, x),
                operation(Axis.Y, y)
            );
        }
        public Vector3T<TR> Operate<TR, T1>(Vector3T<T1> b, System.Func<Axis, T, T1, TR> operation)
        {
            return new Vector3T<TR>(
                operation(Axis.X, x, b.x),
                operation(Axis.Y, y, b.y)
            );
        }
        public Vector3T<TR> Operate<TR, T1, T2>(Vector3T<T1> b, Vector3T<T2> c, System.Func<Axis, T, T1, T2, TR> operation)
        {
            return new Vector3T<TR>(
                operation(Axis.X, x, b.x, c.x),
                operation(Axis.Y, y, b.y, c.y)
            );
        }

        public T GetAxis(Axis axis)
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

        public Vector2T<T> SetAxis(Axis axis, T value)
        {
            if (axis == Axis.X)
            {
                return new Vector2T<T>(value, y);
            }
            else if (axis == Axis.Y)
            {
                return new Vector2T<T>(x, value);
            }

            return default;
        }


        public T[] ToArray()
        {
            return new T[]{
                x,
                y
            };
        }
        public List<T> ToList()
        {
            return new List<T>{
                x,
                y
            };
        }
    }
}