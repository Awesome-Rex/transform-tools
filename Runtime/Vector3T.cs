using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace REXTools.TransformTools
{
    [System.Serializable]
    public class Vector3T<T>
    {
        public T x;
        public T y;
        public T z;

        public Vector3T(T x = default, T y = default, T z = default)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3T(Vector2T<T> vector2T, T z = default)
        {
            this.x = vector2T.x;
            this.y = vector2T.y;
            this.z = z;
        }

        public Vector3Bool OperateBool(System.Func<Axis, T, bool> operation)
        {
            return new Vector3Bool(
                operation(Axis.X, x),
                operation(Axis.Y, y),
                operation(Axis.Z, z)
            );
        }
        public Vector3Bool OperateBool(Vector3T<T> b, System.Func<Axis, T, T, bool> operation)
        {
            return new Vector3Bool(
                operation(Axis.X, x, b.x),
                operation(Axis.Y, y, b.y),
                operation(Axis.Z, z, b.z)
            );
        }

        public Vector3 OperateFloat(System.Func<Axis, T, float> operation)
        {
            return new Vector3(
                operation(Axis.X, x),
                operation(Axis.Y, y),
                operation(Axis.Z, z)
            );
        }
        public Vector3 OperateFloat(Vector3T<T> b, System.Func<Axis, T, T, float> operation)
        {
            return new Vector3(
                operation(Axis.X, x, b.x),
                operation(Axis.Y, y, b.y),
                operation(Axis.Z, z, b.z)
            );
        }

        public Vector3T<T> Operate(System.Func<Axis, T, T> operation)
        {
            return new Vector3T<T>(
                operation(Axis.X, x),
                operation(Axis.Y, y),
                operation(Axis.Z, z)
            );
        }
        public Vector3T<T> Operate(Vector3T<T> b, System.Func<Axis, T, T, T> operation)
        {
            return new Vector3T<T>(
                operation(Axis.X, x, b.x),
                operation(Axis.Y, y, b.y),
                operation(Axis.Z, z, b.z)
            );
        }

        //oiperations with custom types
        public Vector3T<TR> Operate<TR> (System.Func<Axis, T, TR> operation)
        {
            return new Vector3T<TR>(
                operation(Axis.X, x),
                operation(Axis.Y, y),
                operation(Axis.Z, z)
            );
        }
        public Vector3T<TR> Operate<TR, T1>(Vector3T<T1> b, System.Func<Axis, T, T1, TR> operation)
        {
            return new Vector3T<TR>(
                operation(Axis.X, x, b.x),
                operation(Axis.Y, y, b.y),
                operation(Axis.Z, z, b.z)
            );
        }
        public Vector3T<TR> Operate<TR, T1, T2>(Vector3T<T1> b, Vector3T<T2> c, System.Func<Axis, T, T1, T2, TR> operation)
        {
            return new Vector3T<TR>(
                operation(Axis.X, x, b.x, c.x),
                operation(Axis.Y, y, b.y, c.y),
                operation(Axis.Z, z, b.z, c.z)
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
            } else if (axis == Axis.Z)
            {
                return z;
            }

            return default;
        }

        public Vector3T<T> SetAxis(Axis axis, T value)
        {
            if (axis == Axis.X)
            {
                return new Vector3T<T>(value, y, z);
            }
            else if (axis == Axis.Y)
            {
                return new Vector3T<T>(x, value, z);
            }
            else if (axis == Axis.Z)
            {
                return new Vector3T<T>(x, y, value);
            }

            return default;
        }


        public T[] ToArray()
        {
            return new T[]{
                x,
                y,
                z
            };
        }
        public List<T> ToList()
        {
            return new List<T>{
                x,
                y,
                z
            };
        }
    }
}