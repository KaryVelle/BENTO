using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IngredientList : MonoBehaviour
{
    [SerializeField] private GameObject[] ingredients = new GameObject[3];
    [SerializeField] private Image show;
    private Renderer renderer;

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
        renderer = ingredients[selector].GetComponent<Renderer>();
        show.tag = ingredients[selector].tag;
        show.material = renderer.material;
    }
}
