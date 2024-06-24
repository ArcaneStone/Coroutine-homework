using System.Collections;
using UnityEngine;

public class Counter
{
    private float _meter;
    private float _delayInSeconds;

    private bool _isWork = true;

    public Counter(float delayInSeconds)
    {
        _delayInSeconds = delayInSeconds;
    }

    public IEnumerator CountUp()
    {
        var wait = new WaitForSeconds(_delayInSeconds);

        while (_isWork)
        {
            yield return wait;
            _meter++;
        }
    }

    public float GetCounterValue()
    {
        return _meter;
    }
}
