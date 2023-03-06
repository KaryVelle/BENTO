using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IngredientList : MonoBehaviour
{
    [SerializeField] private GameObject[] ingredients = new GameObject[3];
    [SerializeField] private Image show;
    [SerializeField] private Image timer;
    [SerializeField] private GameObject Loose;
    [SerializeField] private float time;
    [SerializeField] private float actualTime;
    private Renderer renderer;
    

    private int selector;
    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
        ChoseIngredients();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    private void ChoseIngredients()
    {
        selector = Random.Range(0, ingredients.Length);
        renderer = ingredients[selector].GetComponent<Renderer>();
        show.tag = ingredients[selector].tag;
        show.material = renderer.material;
    }

    private void Timer()
    {
        actualTime = Time.time - time;
        if (actualTime <= 10)
        {
            float fill = actualTime / 10;
            fill = (1 - fill) + 0;  
            timer.fillAmount = fill;
        }
        else if (actualTime > 10)
        {
            Loose.SetActive(true);
            /*time = Time.time;
            actualTime = 0;*/
        }
    }
}
