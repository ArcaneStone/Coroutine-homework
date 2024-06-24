using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    private float _counter;
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
            _counter++;
        }
    }

    public float GetCounterValue()
    {
        return _counter;
    }
}
