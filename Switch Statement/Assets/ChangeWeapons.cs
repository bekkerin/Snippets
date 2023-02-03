using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// find png images of sword, gun, nanchuk, and bomb on the internet, drag the files into the assets folder. Convert them to sprites by changing the texture type in the inspector to "Sprite". you will be prompted to convert them. 
public class ChangeWeapons : MonoBehaviour
{
    public Image swordImage;
    public Image gunImage;
    public Image nanchukImage;
    public Image bombImage;

    enum Weapons { Sword, Gun, Nanchuk, Bomb };

    public void ChangeWeapon()
    {
        swordImage.enabled = false;
        gunImage.enabled = false;
        nanchukImage.enabled = false;
        bombImage.enabled = false;
        int num = Random.Range(1, 5);
        Debug.Log(num);
        switch(num)
        {
            case 1:
                swordImage.enabled = true;
                break;
            case 2:
                gunImage.enabled = true;
                break;
            case 3:
                nanchukImage.enabled = true;
                break;
            case 4:
                bombImage.enabled = true;
                break;
        }
    }
}
