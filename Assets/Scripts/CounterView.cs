using UnityEngine;
using UnityEngine.UI;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Text _counterText;

    private Coroutine _counterCoroutine;
    private Counter _counter;

    private float _delayInSeconds = 0.5f;

    private void Start()
    {
        _counter = new Counter(_delayInSeconds);
        _counterText.text = _counter.GetCounterValue().ToString();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ToggleCounter();
        }

        UpdateCounterText();
    }

    private void ToggleCounter()
    {
        if (_counterCoroutine != null)
        {
            StopCoroutine(_counterCoroutine);
            _counterCoroutine = null;
        }
        else
        {
            _counterCoroutine = StartCoroutine(_counter.CountUp());
        }
    }

    private void UpdateCounterText()
    {
        _counterText.text =_counter.GetCounterValue().ToString();
    }
}
