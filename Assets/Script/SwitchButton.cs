using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButton : MonoBehaviour
{
    public int mod = 0;

    public void delay()
    {
        StartCoroutine(switched());
    }
    private IEnumerator switched()
    {
        if (Input.GetMouseButtonUp(0))
        {
            mod++;
            if (mod >= 3)
            {
                mod = 0;
            }
            yield return new WaitForSeconds(0.2f);
        }
        yield return null;
       
    }
}
