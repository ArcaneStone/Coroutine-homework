using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour 
{
    private float _delayInSeconds = 0.5f;
    private float _value = 0;
    private bool _isRunning = false;

    public event Action<float> ValueChanged;

    public void StartCounting()
    {        
        _isRunning = true;
        StartCoroutine(CountUp());
    }

    public void StopCounting()
    {
        _isRunning = false;
    }

    public float GetValue()
    {
        return _value;
    }

    private IEnumerator CountUp()
    {
        var wait = new WaitForSeconds(_delayInSeconds);

        while (_isRunning)
        {
            yield return wait;
            _value++;
            ValueChanged?.Invoke(_value);
        }
    }
}
