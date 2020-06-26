using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int count;
    [Range(0.01f, 1)] public float speed;

    public TextMeshProUGUI counter;
    public TextMeshProUGUI plusCounter;

    private int currentCount;
    private int currentPlus;

    private bool startIncrease;
    
    private float lastCallTime;

    private void Update()
    {
        if (count > currentCount)
        {
            startIncrease = true;
            plusCounter.enabled = true;
        }
        else
        {
            startIncrease = false;
            plusCounter.enabled = false;
            currentPlus = 0;
        }

        if (startIncrease && Time.time - lastCallTime >= speed)
        {
            lastCallTime = Time.time;
            currentCount++;;
            currentPlus++;
        }

        counter.text = currentCount.ToString();
        plusCounter.text = "+" + currentPlus.ToString();
    }
}
