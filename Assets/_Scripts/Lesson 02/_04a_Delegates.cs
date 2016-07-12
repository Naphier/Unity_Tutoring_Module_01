using UnityEngine;
using System.Collections;
using UnityEngine.Events;
public class _04a_Delegates : MonoBehaviour
{
    delegate void MyDelegateType(float value);
    MyDelegateType onCoroutineFinished;

    void Start()
    {
        onCoroutineFinished += DoAfterCoroutine;
        StartCoroutine(SomeCoroutine());


    }

    IEnumerator SomeCoroutine()
    {
        float timer = 0;
        while (timer < 5f)
        {
            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        if (onCoroutineFinished != null)
            onCoroutineFinished(timer);
    }

    void DoAfterCoroutine(float value)
    {
        Debug.Log("DoAfterCoroutine - value: " + value);
        onCoroutineFinished -= DoAfterCoroutine;
    }

    // Similar 
    UnityAction myAction;
    float myActionTimer;
    void OnEnable()
    {
        myAction += MyAction;
        myActionTimer = 0;

        if (assignableEvent != null)
            assignableEvent.Invoke();
    }

    void Update()
    {
        myActionTimer += Time.deltaTime;

        if (myActionTimer > 3f && myAction != null)
        {
            myAction.Invoke();
        }
    }

    void MyAction()
    {
        Debug.Log("MyAction");
        myAction -= MyAction;
    }

    [SerializeField]
    public MyEvent assignableEvent;
}

// assignable in the inspector!
[System.Serializable]
public class MyEvent: UnityEvent {}
