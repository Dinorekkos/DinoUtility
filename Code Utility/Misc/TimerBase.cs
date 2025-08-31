using System;
using UnityEngine;

namespace Dino.Utils
{
    /// <summary>
    /// Last update 31/08/2025 Dino
    /// A class that allows you to create a timer with start, pause, reset and stop functionalities.
    /// </summary>
    public class TimerBase : MonoBehaviour
    {
        #region public variables
        public float CurrentTimer => _currentTimer;
        public bool IsTimerActive => _isTimerActive; 

        public Action OnTimerStart;
        public Action OnTimerEnd;
        public Action<float> OnTimerUpdate;
        public Action OnTimerLoop;
        #endregion

        #region private variables
        private bool _isTimerActive;
        private bool _isLoopable;
        private float _currentTimer;
        private float _loopTimer;
        private float _updateInterval = 1f; 
        private float _elapsedTime;
        private bool _isCountdown;
        private float _timerValue;
        #endregion
        
        #region unity methods
        void Update()
        {
            if (_isTimerActive)
            {
                if(_isCountdown) _currentTimer -= 1 * Time.deltaTime;
                else _currentTimer += 1 * Time.deltaTime;
                
                if (_currentTimer <= 0.9f)
                {
                    if(_isLoopable)
                    {
                        _currentTimer = _loopTimer;
                        OnTimerLoop?.Invoke();
                    }
                    else
                        FinishedTimer();
                }
            
                _elapsedTime += Time.deltaTime;
                if (_elapsedTime >= _updateInterval)
                {
                    OnTimerUpdate?.Invoke(_currentTimer);
                    _elapsedTime = 0.0f;
                    // Debug.Log("Timer Update = " + _currentTimer);
                }
                
            }
        }
        #endregion

        #region public methods

        public float GetTimePercentage()
        {
            return  _currentTimer / _timerValue;
        }   
        public void StartTimer(float timer,string message = "", bool isCountDown = false, float intervalUpdate = 1f)
        {
            if(isCountDown) _currentTimer = timer;
            
            _timerValue = timer;
            _updateInterval = intervalUpdate;
            _isCountdown = isCountDown;
            
            _isTimerActive = true;
            OnTimerStart?.Invoke();
            
            if(!string.IsNullOrEmpty(message))
             Debug.Log("Timer Started = " + message + " Timer = " + _currentTimer);
        }

        public void StartLoopTimer(float timer,string message = "", bool isCountDown = false, float intervalUpdate = 1f)
        {
            if(isCountDown) _currentTimer = timer;
            
            _updateInterval = intervalUpdate;
            _loopTimer = timer;
            _isCountdown = isCountDown;
            
            _isTimerActive = true;
            _isLoopable = true;
            
            if(!string.IsNullOrEmpty(message))
                Debug.Log("Timer Started = " + message + " Timer = " + _currentTimer);
        }
        public void PauseTimer()
        {
            _isTimerActive = false;
        }

        public void ResetTimer()
        {
            _currentTimer = 0;
        }
        
        public void StopTimer(bool destroy = false)
        {
            _isTimerActive = false;
            ResetTimer();
            if(destroy) Destroy(this);
        }
        
        #endregion

        #region private methods

        private void FinishedTimer()
        {
            _isTimerActive = false;
            ResetTimer();
            OnTimerEnd?.Invoke();
        }

        #endregion
    }

}