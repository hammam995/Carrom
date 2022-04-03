using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ItemSelection : MonoBehaviour
{
    public Image SelectionImage;
    public List<Sprite> ItemList = new List<Sprite>();
    private int itemspot = 0;
    public void RightSelection()
    {
        if (itemspot < ItemList.Count - 1)
        {
            itemspot++;
            SelectionImage.sprite = ItemList[itemspot];
        }
    }
    public void LeftSelection()
    {
        if (itemspot > 0)
        {
            itemspot--;
            SelectionImage.sprite = ItemList[itemspot];
        }
    }
}
