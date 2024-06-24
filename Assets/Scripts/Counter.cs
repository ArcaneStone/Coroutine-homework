using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private Text _counterText;

    private Coroutine _counterCoroutine;

    private bool _isWork = true;
    private float _counter = 0;
    private float _delayInSeconds = 0.5f;
    private float _counterIncrement = 1f;

    void Start()
    {
        _counterText.text = _counter.ToString();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ToggleCounter();
        }
    }

    private void ToggleCounter()
    {
        if(_counterCoroutine != null)
        {
            StopCoroutine(_counterCoroutine);
            _counterCoroutine = null;
        }
        else
        {
            _counterCoroutine = StartCoroutine(CountUp());
        }        
    }

    private IEnumerator CountUp()
    {
        var wait = new WaitForSeconds(_delayInSeconds);

        while (_isWork)
        {
            yield return wait;
            _counter += _counterIncrement;
            _counterText.text = _counter.ToString();
        }
    }
}
