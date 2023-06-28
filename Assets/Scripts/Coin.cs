using UnityEngine;

public class Coin : MonoBehaviour
{
    float speedIncreaseValue = 0.5f;
    float curSpeed = 0;

    private void OnMouseDown()
    {
        curSpeed += speedIncreaseValue;
        gameObject.GetComponent<Renderer>().material.color = GetRandomColor();
    }

    private void Update()
    {
        ChangeSpinSpeed();
    }

    void ChangeSpinSpeed()
    {
        if (curSpeed > 0)
        {
            gameObject.GetComponent<Animator>().SetFloat("SpinSpeed", curSpeed);
            curSpeed -= Time.deltaTime;
        }
        else
        {
            curSpeed = 0;
            gameObject.GetComponent<Animator>().SetFloat("SpinSpeed", curSpeed);
        }
    }

    private Color GetRandomColor()
    {
        return new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }
}
