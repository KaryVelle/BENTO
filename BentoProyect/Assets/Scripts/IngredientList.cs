using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IngredientList : MonoBehaviour
{
    [SerializeField] private Material[] ingredients = new Material[3];
    [SerializeField] private Image show;

    private int selector;
    // Start is called before the first frame update
    void Start()
    {
        ChoseIngredients();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChoseIngredients()
    {
        selector = Random.Range(0, ingredients.Length);
        show.material = ingredients[selector];
    }
}
