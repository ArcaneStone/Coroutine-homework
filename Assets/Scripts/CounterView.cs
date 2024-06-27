using System;
using UnityEngine;
using UnityEngine.UI;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Text _counterText;
    [SerializeField] private Counter _counter;

    private void Start()
    {
        _counterText.text = _counter.GetValue().ToString();
        _counter.ValueChanged += OnCounterValueChanged;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(_counter != null)
            {
                if(_counter.GetValue() == 0)
                {
                    _counter.StartCounting();
                }
                else
                {
                    _counter.StopCounting();
                }
            }
        }        
    }

    private void OnCounterValueChanged(float newValue)
    {
        _counterText.text = newValue.ToString();
    }
}
