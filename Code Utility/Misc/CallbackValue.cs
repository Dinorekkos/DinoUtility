using System;
using UnityEngine;

namespace Dino.UtilityTools.Callback
{
    /// <summary>
    /// Last update 29/08/2025 Dino
    /// A class that allows you to set a value and have a callback when the value changes.
    /// </summary>
    public class CallbackValue<T>
    {
        public Action<T> onChanged;
        
        public CallbackValue()
        {

        }
        public CallbackValue(T cachedValue)
        {
            _cachedValue = cachedValue;
        }

        public T Value
        {
            get => _cachedValue;
            set
            {
                if (_cachedValue!=null && _cachedValue.Equals(value))
                    return;
                _cachedValue = value;
                onChanged?.Invoke(_cachedValue);
            }
        }

        public void ForceSet(T value)
        {
            _cachedValue = value;
            onChanged?.Invoke(_cachedValue);
        }

        public void SetNoCallback(T value)
        {
            _cachedValue = value;
        }

        T _cachedValue = default;
    }
}
