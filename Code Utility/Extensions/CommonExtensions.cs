using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Dino.UtilityTools.Extensions
{
    public static class CommonExtensions
    {
        #region Vector3
        public static Vector3 SetX(this Vector3 v, float x)
        {
            v.x = x;
            return v;
        }
        public static Vector3 SetY(this Vector3 v, float y)
        {
            v.y = y;
            return v;
        }
        public static Vector3 SetZ(this Vector3 v, float z)
        {
            v.z = z;
            return v;
        }
        public static Vector3 SetXY(this Vector3 v, float x, float y)
        {
            v.x = x;
            v.y = y;
            return v;
        }
        public static Vector3 SetXZ(this Vector3 v, float x, float z)
        {
            v.x = x;
            v.z = z;
            return v;
        }
        public static Vector3 SetYZ(this Vector3 v, float y, float z)
        {
            v.y = y;
            v.z = z;
            return v;
        }
        public static Vector3 AddX(this Vector3 v, float x)
        {
            v.x += x;
            return v;
        }
        public static Vector3 AddY(this Vector3 v, float y)
        {
            v.y += y;
            return v;
        }
        public static Vector3 AddZ(this Vector3 v, float z)
        {
            v.z += z;
            return v;
        }
        public static Vector3 AddXY(this Vector3 v, float x, float y)
        {
            v.x += x;
            v.y += y;
            return v;
        }
        public static Vector3 AddXZ(this Vector3 v, float x, float z)
        {
            v.x += x;
            v.z += z;
            return v;
        }
        public static Vector3 AddYZ(this Vector3 v, float y, float z)
        {
            v.y += y;
            v.z += z;
            return v;
        }
        public static Vector3 MulX(this Vector3 v, float xFac)
        {
            v.x *= xFac;
            return v;
        }
        public static Vector3 MulY(this Vector3 v, float yFac)
        {
            v.y *= yFac;
            return v;
        }
        public static Vector3 MulZ(this Vector3 v, float zFac)
        {
            v.z *= zFac;
            return v;
        }
        public static Vector3 MulXY(this Vector3 v, float xFac, float yFac)
        {
            v.x *= xFac;
            v.y *= yFac;
            return v;
        }
        public static Vector3 MulXZ(this Vector3 v, float yFac, float zFac)
        {
            v.y *= yFac;
            v.z *= zFac;
            return v;
        }
        public static Vector3 MulYZ(this Vector3 v, float yFac, float zFac)
        {
            v.y *= yFac;
            v.z *= zFac;
            return v;
        }
        public static Vector3Int SetX(this Vector3Int v, int x)
        {
            v.x = x;
            return v;
        }
        public static Vector3Int SetY(this Vector3Int v, int y)
        {
            v.y = y;
            return v;
        }
        public static Vector3Int SetZ(this Vector3Int v, int z)
        {
            v.z = z;
            return v;
        }
        public static Vector3Int SetXY(this Vector3Int v, int x, int y)
        {
            v.x = x;
            v.y = y;
            return v;
        }
        public static Vector3Int SetXZ(this Vector3Int v, int x, int z)
        {
            v.x = x;
            v.z = z;
            return v;
        }
        public static Vector3Int SetYZ(this Vector3Int v, int y, int z)
        {
            v.y = y;
            v.z = z;
            return v;
        }
        public static Vector3Int AddX(this Vector3Int v, int x)
        {
            v.x += x;
            return v;
        }
        public static Vector3Int AddY(this Vector3Int v, int y)
        {
            v.y += y;
            return v;
        }
        public static Vector3Int AddZ(this Vector3Int v, int z)
        {
            v.z += z;
            return v;
        }
        public static Vector3Int AddXY(this Vector3Int v, int x, int y)
        {
            v.x += x;
            v.y += y;
            return v;
        }
        public static Vector3Int AddXZ(this Vector3Int v, int x, int z)
        {
            v.x += x;
            v.z += z;
            return v;
        }
        public static Vector3Int AddYZ(this Vector3Int v, int y, int z)
        {
            v.y += y;
            v.z += z;
            return v;
        }
        public static Vector3 SwapXY(this Vector3 v)
        {
            float temp = v.x;
            v.x = v.y;
            v.y = temp;
            return v;
        }
        public static Vector3 SwapXZ(this Vector3 v)
        {
            float temp = v.x;
            v.x = v.z;
            v.z = temp;
            return v;
        }
        public static Vector3 SwapYZ(this Vector3 v)
        {
            float temp = v.y;
            v.y = v.z;
            v.z = temp;
            return v;
        }
        public static Vector2 ToV2(this Vector3 v, bool Z_AxisIs_Y_Axis = false)
        {
            return new Vector2(v.x, Z_AxisIs_Y_Axis ? v.z : v.y);
        }
        public static Vector3 Abs(this Vector3 v) => new Vector3(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z));
        public static Vector3 Round(this Vector3 v)
        {
            v.x = Mathf.Round(v.x);
            v.y = Mathf.Round(v.y);
            v.z = Mathf.Round(v.z);
            return v;
        }
        public static Vector3 Floor(this Vector3 v)
        {
            v.x = Mathf.Floor(v.x);
            v.y = Mathf.Floor(v.y);
            v.z = Mathf.Floor(v.z);
            return v;
        }
        /// <summary>
        ///  Rounds to nearest Vector Int value.
        /// </summary>
        /// <param name="v">Vector to round</param>
        /// <returns></returns>
        public static Vector3Int RoundToInt(this Vector3 v)
        {
            return new Vector3Int(
                Mathf.RoundToInt(v.x),
                Mathf.RoundToInt(v.y),
                Mathf.RoundToInt(v.z));
        }
        public static Vector3Int FloorToInt(this Vector3 v)
        {
            return new Vector3Int(
                Mathf.FloorToInt(v.x),
                Mathf.FloorToInt(v.y),
                Mathf.FloorToInt(v.z));
        }
        public static float Heuristic(this Vector3 v)
        {
            float value = v.x + v.y + v.z;
            if (value < 0)
                value = -value;
            return value;
        }


        /// <summary>
        /// Does not touch Y axis
        /// </summary>
        /// <param name="v"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static Vector3 SubtractMagnitudeHorizontal(this Vector3 v, float amount)
        {
            float y = v.y;
            v.y = 0;
            v = v.SubtractMagnitude(amount);
            v.y = y;
            return v;
        }
        public static Vector3 SubtractMagnitude(this Vector3 v, float amount)
        {
            //Store magntiude
            float magnitude = v.magnitude;
            //if magnitude is 0
            if (magnitude == 0f)
            {
                return v;
            }
            //Normalize vector
            v /= magnitude;
            //Calculate new magnitude
            magnitude = Mathf.Clamp(magnitude - amount, 0f, Mathf.Infinity);
            //Return vector with correct magnitude
            return v * magnitude;
        }
        public static bool IsApproxZero(this Vector3 v) => Mathf.Approximately(v.x, 0f) && Mathf.Approximately(v.y, 0f) && Mathf.Approximately(v.z, 0f);
        public static bool IsInfinity(this Vector3 v) => float.IsInfinity(v.x) || float.IsInfinity(v.y) || float.IsInfinity(v.z);
        public static bool IsNaN(this Vector3 v) => float.IsNaN(v.x) || float.IsNaN(v.y) || float.IsNaN(v.z);

        public static Vector3 ClampMagnitude(this Vector3 v, float maxMagnitude)
        {
            float sqrMagn = v.sqrMagnitude;
            if (sqrMagn > maxMagnitude * maxMagnitude)
            {
                return v.normalized * maxMagnitude;
            }
            return v;
        }
        public static float Average(this Vector3 v)
        {
            return (v.x + v.y + v.z) / 3f;
        }
        public static Color ToColor(this Vector3 v)
        {
            return new Color(v.x, v.y, v.z);
        }
        #endregion

        #region Vector2
        public static Vector2 SetX(this Vector2 v, float x)
        {
            v.x = x;
            return v;
        }
        public static Vector2 SetY(this Vector2 v, float y)
        {
            v.y = y;
            return v;
        }
        public static Vector2 SetXY(this Vector2 v, float x, float y)
        {
            v.x = x;
            v.y = y;
            return v;
        }
        public static Vector2 AddX(this Vector2 v, float x)
        {
            v.x += x;
            return v;
        }
        public static Vector2 AddY(this Vector2 v, float y)
        {
            v.y += y;
            return v;
        }
        public static Vector2 AddXY(this Vector2 v, float x, float y)
        {
            v.x += x;
            v.y += y;
            return v;
        }
        public static Vector2 MulX(this Vector2 v, float x)
        {
            v.x *= x;
            return v;
        }
        public static Vector2 MulY(this Vector2 v, float y)
        {
            v.y *= y;
            return v;
        }
        public static Vector2 MulXY(this Vector2 v, float x, float y)
        {
            v.x *= x;
            v.y *= y;
            return v;
        }
        public static Vector2Int SetX(this Vector2Int v, int x)
        {
            v.x = x;
            return v;
        }
        public static Vector2Int SetY(this Vector2Int v, int y)
        {
            v.y = y;
            return v;
        }
        public static Vector2Int SetXY(this Vector2Int v, int x, int y)
        {
            v.x = x;
            v.y = y;
            return v;
        }
        public static Vector2Int AddX(this Vector2Int v, int x)
        {
            v.x += x;
            return v;
        }
        public static Vector2Int AddY(this Vector2Int v, int y)
        {
            v.y += y;
            return v;
        }
        public static Vector2Int AddXY(this Vector2Int v, int x, int y)
        {
            v.x += x;
            v.y += y;
            return v;
        }
        public static Vector2Int MulX(this Vector2Int v, int x)
        {
            v.x *= x;
            return v;
        }
        public static Vector2Int MulY(this Vector2Int v, int y)
        {
            v.y *= y;
            return v;
        }
        public static Vector2Int MulXY(this Vector2Int v, int x, int y)
        {
            v.x *= x;
            v.y *= y;
            return v;
        }
        public static Vector2 Add(this Vector2 v, Vector2 v2)
        {
            v.x += v2.x;
            v.y += v2.y;
            return v;
        }
        public static Vector2 Add(this Vector2 v, Vector3 v3, bool useZforY = false)
        {
            v.x += v3.x;
            if (useZforY == true)
            {
                v.y += v3.z;
            }
            else
            {
                v.y += v3.y;
            }
            return v;
        }
        public static Vector2 SwapXY(this Vector2 v)
        {
            float temp = v.x;
            v.x = v.y;
            v.y = temp;
            return v;
        }
        public static Vector2 ToDirection(this Vector2 v)
        {
            Vector2 abs = v.Abs();
            if (abs.x > abs.y)
            {
                return v.x > 0 ? Vector2.right : Vector2.left;
            }
            else if (abs.x < abs.y)
            {
                return v.y > 0 ? Vector2.up : Vector2.down;
            }
            return Vector2.zero;
        }
        public static Vector3 ToV3(this Vector2 v, float zValue = 0)
        {
            return new Vector3(v.x, v.y, zValue);
        }
        public static Vector3 ToV3_YisZ(this Vector2 v)
        {
            return new Vector3(v.x, 0, v.y);
        }
        public static Vector2 ToV2(this Vector2Int v) => new(v.x, v.y);
        public static Vector2 ToV2(this Vector3Int v) => new(v.x, v.y);
        public static Vector3 ToV3(this Vector2Int v) => new(v.x, v.y);
        public static Vector3 ToV3(this Vector3Int v) => new(v.x, v.y, v.z);
        public static Vector2 Abs(this Vector2 v) => new(Mathf.Abs(v.x), Mathf.Abs(v.y));
        public static Vector2Int RoundToInt(this Vector2 v)
        {
            return new Vector2Int(
                Mathf.RoundToInt(v.x),
                Mathf.RoundToInt(v.y));
        }
        public static Vector2Int FloorToInt(this Vector2 v)
        {
            return new Vector2Int(
                Mathf.FloorToInt(v.x),
                Mathf.FloorToInt(v.y));
        }

        public static Vector2 Lerp(this Vector2 v, Vector2 target, float t)
        {
            return Vector2.Lerp(v, target, t);
        }
        public static Vector2 MoveTowards(this Vector2 v, Vector2 target, float step, bool deltaTime = false, bool scaled = true)
        {
            return Vector2.MoveTowards(v, target, step * (deltaTime ? (scaled ? Time.deltaTime : Time.unscaledDeltaTime) : 1f));
        }
        public static Vector2 ClampMagnitude(this Vector2 v, float maxMagnitude)
        {
            float sqrMagn = v.sqrMagnitude;
            if (sqrMagn > maxMagnitude * maxMagnitude)
            {
                return v.normalized * maxMagnitude;
            }
            return v;
        }
        public static Vector2 SubtractMagnitude(this Vector2 v, float amount)
        {
            //Store magntiude
            float magnitude = v.magnitude;
            //if magnitude is 0
            if (magnitude == 0f)
            {
                return v;
            }
            //Normalize vector
            v /= magnitude;
            //Calculate new magnitude
            magnitude = Mathf.Max(0f, magnitude - amount);
            //Return vector with correct magnitude
            return v * magnitude;
        }
        public static bool IsInfinity(this Vector2 v)
        {
            return float.IsInfinity(v.x) || float.IsInfinity(v.y);
        }
        public static float Average(this Vector2 v)
        {
            return (v.x + v.y) / 2f;
        }
        public static Vector2 GetRandomPointInCircle(this Vector2 origin, float spread)
        {
            float angle = UnityEngine.Random.Range(0f, 360f);
            float x = origin.x + spread * Mathf.Sin(angle);
            float y = origin.y + spread * Mathf.Cos(angle);
            return new Vector2(x, y);
        }
        #endregion

        #region Color
        public static Color SetR(this Color c, float r)
        {
            c.r = r;
            return c;
        }
        public static Color SetG(this Color c, float g)
        {
            c.g = g;
            return c;
        }
        public static Color SetB(this Color c, float b)
        {
            c.b = b;
            return c;
        }
        public static Color SetA(this Color c, float a)
        {
            c.a = a;
            return c;
        }
        public static Color SetRGB(this Color c, Color color) => c.SetRGB(color.r, color.g, color.b);
        public static Color SetRGB(this Color c, float r, float g, float b)
        {
            c.r = r;
            c.g = g;
            c.b = b;
            return c;
        }
        public static Color SetGBA(this Color c, float g, float b, float a)
        {
            c.g = g;
            c.b = b;
            c.a = a;
            return c;
        }
        public static Color AddR(this Color c, float r)
        {
            c.r += r;
            return c;
        }
        public static Color AddG(this Color c, float g)
        {
            c.g += g;
            return c;
        }
        public static Color AddB(this Color c, float b)
        {
            c.b += b;
            return c;
        }
        public static Color AddA(this Color c, float a)
        {
            c.a += a;
            return c;
        }
        public static Vector3 ToV3(this Color c)
        {
            return new Vector3(c.r, c.g, c.b);
        }
        #endregion

        #region IEnumerable
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> e) => e == null || e.Count() == 0;

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> e, Action<T> action)
        {
            if (e.IsNullOrEmpty()) yield break;
            foreach (var item in e)
            {
                action(item);
                yield return item;
            }
        }
        public static bool AllElementsEquals<T>(this IEnumerable<T> e1, IEnumerable<T> e2)
        {
            if (e1.IsNullOrEmpty() || e2.IsNullOrEmpty())
                return e1 == e2;

            if (e1.Count() != e2.Count())
                return false;

            for (int i = 0; i < e1.Count(); i++)
            {
                T element1 = e1.ElementAt(i);
                T element2 = e2.ElementAt(i);
                if (element1 == null)
                {
                    if (element2 != null)
                        return false;
                }
                else
                {
                    if (!element1.Equals(element2))
                        return false;
                }
            }

            return true;
        }
        public static bool AnyElementsEquals<T>(this IEnumerable<T> e1, IEnumerable<T> e2)
        {
            if (e1.IsNullOrEmpty() || e2.IsNullOrEmpty())
                return e1 == e2;

            for (int i1 = 0; i1 < e1.Count(); i1++)
            {
                T element1 = e1.ElementAt(i1);
                for (int i2 = 0; i2 < e2.Count(); i2++)
                {
                    T element2 = e2.ElementAt(i2);
                    if (element1 == null)
                    {
                        if (element2 == null)
                            return true;
                    }
                    else
                    {
                        if (element1.Equals(element2))
                            return true;
                    }
                }
            }

            return false;
        }
        public static float ComputeAverage(this IEnumerable<float> c)
        {
            if (c.IsNullOrEmpty()) return default;
            float total = 0f;
            for (int i = 0; i < c.Count(); i++)
            {
                total += c.ElementAt(i);
            }
            return total / c.Count();
        }
        #endregion

        #region IEnumerator
        public static void ForEach<T>(this System.Collections.IEnumerator e, Action<T> action)
        {
            if (e == null) return;
            try
            {
                while (e.MoveNext())
                {
                    action((T)e.Current);
                }
            }
            catch (Exception exception)
            {
                Debug.LogError($"Something went wrong when looping through IEnumerator {e} ({exception.Message}). {exception.StackTrace}");
            }
        }
        public static void ForEach<T>(this IEnumerator<T> e, Action<T> action)
        {
            if (e == null) return;
            try
            {
                while (e.MoveNext())
                {
                    action(e.Current);
                }
            }
            catch (Exception exception)
            {
                Debug.LogError($"Something went wrong when looping through IEnumerator {e} ({exception.Message}). {exception.StackTrace}");
            }
            finally
            {
                e.Dispose();
            }
        }
        #endregion

        #region Array
        public static bool IsIndexNullOrEmpty<T>(this T[] array, int index) => array.IsNullOrEmpty() || index < 0 || index >= array.Length || array[index] == null;

        public static void SetAllValues<T>(this T[] array, T value) => array.ForEach(x => x = value);
        public static int FindIndex<T>(this T[] array, T item)
        {
            if (!(array.IsNullOrEmpty() || item == null))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (item.Equals(array[i]))
                        return i;
                }
            }
            return -1;
        }
        public static bool Contains<T>(this T[] array, T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (item.Equals(array[i]))
                    return true;
            }
            return false;
        }
        public static T Random<T>(this T[] array) => array.IsNullOrEmpty() ? default : array[UnityEngine.Random.Range(0, array.Length)];

        public static T[] ResizeAndCopy<T>(this T[] array, T[] copyFrom)
        {
            array = new T[copyFrom.Length];
            Array.Copy(copyFrom, array, copyFrom.Length);
            return array;
        }
        #endregion

        #region List
        public static bool IsIndexNullOrEmpty<T>(this IList<T> list, int index) => list.IsNullOrEmpty() || index < 0 || index >= list.Count || list[index] == null;

        public static bool ContainsAny<T>(this IList<T> l1, IList<T> l2)
        {
            for (int i = 0; i < l2.Count; i++)
            {
                if (l1.Contains(l2[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public static T Random<T>(this IList<T> list) => list.IsNullOrEmpty() ? default : list[UnityEngine.Random.Range(0, list.Count)];
        public static int RandomIndex<T>(this IList<T> list) => list.IsNullOrEmpty() ? default : UnityEngine.Random.Range(0, list.Count);
        public static void Shuffle<T>(this IList<T> list)
        {
            if (list.IsNullOrEmpty()) return;
            System.Random random = new();
            int count = list.Count;
            while (count > 1)
            {
                count--;
                int index = random.Next(count + 1);
                (list[count], list[index]) = (list[index], list[count]);
            }
        }
        public static T Dequeue<T>(this IList<T> list)
        {
            if (list.IsNullOrEmpty()) return default;
            T t = list[0];
            list.RemoveAt(0);
            return t;
        }
        public static T Pop<T>(this IList<T> list)
        {
            if (list.IsNullOrEmpty()) return default;
            T t = list.Last();
            list.RemoveAt(list.Count - 1);
            return t;
        }
        /// <summary>
        /// Only adds to the list if the element is not already present in it.
        /// </summary>
        public static void AddNonRepeat<T>(this IList<T> list, T element)
        {
            if (!list.Contains(element)) list.Add(element);
        }
        #endregion

        #region Dictionary
        public static void AddOrSet<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, TValue value)
        {
            if (dic.IsNullOrEmpty()) return;
            if (dic.ContainsKey(key) == false)
            {
                dic.Add(key, value);
            }
            else
            {
                dic[key] = value;
            }
        }
        public static void DoIfHasKey<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, Action<TValue> action)
        {
            if (dic.IsNullOrEmpty()) return;
            if (dic.TryGetValue(key, out TValue value))
                action(value);
        }
        public static TReturn DoIfHasKey<TKey, TValue, TReturn>(this Dictionary<TKey, TValue> dic, TKey key, Func<TValue, TReturn> action, TReturn defaultReturn = default) => !dic.IsNullOrEmpty() && dic.TryGetValue(key, out TValue value) ? action(value) : defaultReturn;
        public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, TValue defaultReturn = default) => dic.TryGetValue(key, out TValue value) ? value : defaultReturn;
        #endregion

        #region Events
        public static void HandleSubscribe(this UnityEvent e, UnityAction a, bool subscribe, bool safe = false)
        {
            if (subscribe)
            {
                if (safe) e.SafeSubscribe(a);
                else e.Subscribe(a);
            }
            else e.Unsubscribe(a);
        }
        public static void HandleSubscribe<T0>(this UnityEvent<T0> e, UnityAction<T0> a, bool subscribe, bool safe = false)
        {
            if (subscribe)
            {
                if (safe) e.SafeSubscribe(a);
                else e.Subscribe(a);
            }
            else e.Unsubscribe(a);
        }
        public static void HandleSubscribe<T0, T1>(this UnityEvent<T0, T1> e, UnityAction<T0, T1> a, bool subscribe, bool safe = false)
        {
            if (subscribe)
            {
                if (safe) e.SafeSubscribe(a);
                else e.Subscribe(a);
            }
            else e.Unsubscribe(a);
        }
        public static void HandleSubscribe<T0, T1, T2>(this UnityEvent<T0, T1, T2> e, UnityAction<T0, T1, T2> a, bool subscribe, bool safe = false)
        {
            if (subscribe)
            {
                if (safe) e.SafeSubscribe(a);
                else e.Subscribe(a);
            }
            else e.Unsubscribe(a);
        }
        public static void HandleSubscribe<T0, T1, T2, T3>(this UnityEvent<T0, T1, T2, T3> e, UnityAction<T0, T1, T2, T3> a, bool subscribe, bool safe = false)
        {
            if (subscribe)
            {
                if (safe) e.SafeSubscribe(a);
                else e.Subscribe(a);
            }
            else e.Unsubscribe(a);
        }

        public static void SafeSubscribe(this UnityEvent e, UnityAction a)
        {
            e.RemoveListener(a);
            e.AddListener(a);
        }
        public static void SafeSubscribe<T0>(this UnityEvent<T0> e, UnityAction<T0> a)
        {
            e.RemoveListener(a);
            e.AddListener(a);
        }
        public static void SafeSubscribe<T0, T1>(this UnityEvent<T0, T1> e, UnityAction<T0, T1> a)
        {
            e.RemoveListener(a);
            e.AddListener(a);
        }
        public static void SafeSubscribe<T0, T1, T2>(this UnityEvent<T0, T1, T2> e, UnityAction<T0, T1, T2> a)
        {
            e.RemoveListener(a);
            e.AddListener(a);
        }
        public static void SafeSubscribe<T0, T1, T2, T3>(this UnityEvent<T0, T1, T2, T3> e, UnityAction<T0, T1, T2, T3> a)
        {
            e.RemoveListener(a);
            e.AddListener(a);
        }

        public static void Subscribe(this UnityEvent e, UnityAction a)
        {
            e.AddListener(a);
        }
        public static void Subscribe<T0>(this UnityEvent<T0> e, UnityAction<T0> a)
        {
            e.AddListener(a);
        }
        public static void Subscribe<T0, T1>(this UnityEvent<T0, T1> e, UnityAction<T0, T1> a)
        {
            e.AddListener(a);
        }
        public static void Subscribe<T0, T1, T2>(this UnityEvent<T0, T1, T2> e, UnityAction<T0, T1, T2> a)
        {
            e.AddListener(a);
        }
        public static void Subscribe<T0, T1, T2, T3>(this UnityEvent<T0, T1, T2, T3> e, UnityAction<T0, T1, T2, T3> a)
        {
            e.AddListener(a);
        }

        public static void Unsubscribe(this UnityEvent e, UnityAction a)
        {
            e.RemoveListener(a);
        }
        public static void Unsubscribe<T0>(this UnityEvent<T0> e, UnityAction<T0> a)
        {
            e.RemoveListener(a);
        }
        public static void Unsubscribe<T0, T1>(this UnityEvent<T0, T1> e, UnityAction<T0, T1> a)
        {
            e.RemoveListener(a);
        }
        public static void Unsubscribe<T0, T1, T2>(this UnityEvent<T0, T1, T2> e, UnityAction<T0, T1, T2> a)
        {
            e.RemoveListener(a);
        }
        public static void Unsubscribe<T0, T1, T2, T3>(this UnityEvent<T0, T1, T2, T3> e, UnityAction<T0, T1, T2, T3> a)
        {
            e.RemoveListener(a);
        }
        #endregion

        #region String
        /// <summary>
        /// Convert the string to the provided enum type
        /// </summary>
        /// <typeparam name="TEnum">Fallback value used to define the enum type</typeparam>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Enum ToEnum(this string value, Enum defaultValue)
		{
            Type enumType = defaultValue.GetType();

            if (string.IsNullOrEmpty(value)
                || !Enum.IsDefined(enumType, value))
            {
                Debug.Log($"Could not parse string \"{value}\" to enum type \"{enumType}\"");
                return defaultValue;
            }
            return (Enum)Enum.Parse(defaultValue.GetType(), value, true);
		}
		#endregion

		#region Enum
		public static int GetEnumIndex(this Enum value)
		{
			Array enumValues = Enum.GetValues(value.GetType());

			for (int i = 0; i < enumValues.Length; i++)
			{
				if (value.Equals(enumValues.GetValue(i)))
				{
					return i;
				}
			}

			return -1; // Value not found
		}
        public static bool EnumEquals(this Enum value, Enum toCompare)
        {
            Type valueType = value.GetType();
            Type toCompareType = toCompare.GetType();
            int valueIndex = value.GetEnumIndex();
			int toCompareIndex = toCompare.GetEnumIndex();

			return valueType.Equals(toCompareType) && valueIndex == toCompareIndex;
        }
        #endregion

        #region GameObject
        /// <summary>
        /// Executes the specified event function on the GameObject using a new BaseEventData.
        /// </summary>
        /// <typeparam name="T">Type of the event handler.</typeparam>
        /// <param name="gameObject">The target GameObject.</param>
        /// <param name="executeEvents">The event function to execute.</param>
        public static void Execute<T>(this GameObject gameObject, ExecuteEvents.EventFunction<T> executeEvents) where T : IEventSystemHandler
        {
            ExecuteEvents.Execute(gameObject, new BaseEventData(EventSystem.current), executeEvents);
        }
        
        /// <summary>
        /// Executes the specified event function on the GameObject using the provided event data.
        /// </summary>
        /// <typeparam name="T">Type of the event handler.</typeparam>
        /// <param name="gameObject">The target GameObject.</param>
        /// <param name="eventData">The event data to use.</param>
        /// <param name="executeEvents">The event function to execute.</param>
        public static void Execute<T>(this GameObject gameObject, BaseEventData eventData, ExecuteEvents.EventFunction<T> executeEvents) where T : IEventSystemHandler
        {
            ExecuteEvents.Execute(gameObject, eventData, executeEvents);
        }
        
        /// <summary>
        /// Executes the specified event function on the GameObject using a new PointerEventData.
        /// </summary>
        /// <typeparam name="T">Type of the event handler.</typeparam>
        /// <param name="gameObject">The target GameObject.</param>
        /// <param name="executeEvents">The event function to execute.</param>
        public static void ExecutePointer<T>(this GameObject gameObject, ExecuteEvents.EventFunction<T> executeEvents) where T : IEventSystemHandler
        {
            ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), executeEvents);
        }
        /// <summary>
        /// Gets the specified component from the GameObject. If the component does not exist, adds it and returns the new instance.
        /// </summary>
        /// <typeparam name="T">Type of the component to get or add.</typeparam>
        /// <param name="gameObject">The target GameObject.</param>
        /// <returns>The existing or newly added component of type T.</returns>
        public static T GetOrAdd<T>(this GameObject gameObject) where T : Component {
            T component = gameObject.GetComponent<T>();
            if (!component) component = gameObject.AddComponent<T>();

            return component;
        }
        #endregion

        #region Transform
       /// <summary>
        /// Returns all direct children of the given Transform. If recursive is true, returns all descendants recursively.
        /// </summary>
        /// <param name="t">The parent Transform.</param>
        /// <param name="recursive">If true, includes all descendants recursively; otherwise, only direct children.</param>
        /// <returns>An IEnumerable of child Transforms.</returns>
        public static IEnumerable<Transform> GetChildren(this Transform t, bool recursive = false)
        {
            foreach (Transform child in t)
            {
                yield return child;
                if (recursive)
                {
                    foreach (var c in child.GetChildren(true))
                        yield return c;
                }
            }
        }
        /// <summary>
		/// Finds children by name, breadth first
		/// </summary>
		/// <param name="t"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public static Transform FindDeepChildBreadthFirst(this Transform t, string name)
        {
            Queue<Transform> queue = new();
            queue.Enqueue(t);
            while (queue.Count > 0)
            {
                Transform child = queue.Dequeue();
                if (child.name == name)
                    return child;

                foreach (Transform c in child)
                    queue.Enqueue(c);
            }
            return null;
        }
        /// <summary>
        /// Finds children by name, depth first
        /// </summary>
        /// <param name="t"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Transform FindDeepChildDepthFirst(this Transform t, string name)
        {
            foreach (Transform child in t)
            {
                if (child.name == name)
                    return child;

                Transform result = child.FindDeepChildDepthFirst(name);
                if (result) return result;
            }
            return null;
        }
        public static void DestroyChildren(this Transform t)
        {
            foreach (var child in t.GetChildren())
            {
                if (Application.isPlaying)
                {
                    UnityEngine.Object.Destroy(child.gameObject);
                }
                else
                {
                    UnityEngine.Object.DestroyImmediate(child.gameObject);
                }
            }
        }
        #endregion
    }
}
