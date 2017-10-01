using UnityEngine;
using System.Collections;

public class TestUIMoving : MonoBehaviour
{
    public GameObject coinPrefab = null;
    public Transform from = null;
    public Transform target = null;

	void Update ()
    {
	    if(Input.GetMouseButtonDown(0))
        {
            GameObject coin = Instantiate(coinPrefab) as GameObject;
            coin.transform.SetParent(target.parent, false);
            //coin.transform.localScale = Vector3.one;

            //coin.transform.position = Input.mousePosition;

            //coin.transform.position = from.position;
            coin.GetComponent<RectTransform>().position = from.GetComponent<RectTransform>().position;

            LeanTween.move(coin, target.position, 1.0f).setEase(LeanTweenType.easeInExpo).setOnComplete(()=> 
            {
                Destroy(coin);
            });
        }
	}
}
