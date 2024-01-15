using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Mainmenu : MonoBehaviour
{
    public GameObject Mainmenu1, Gender, eggplant_sprite_new_1, eggplant_sprite_new_2, eggplant_sprite_new_3, priest_model_Sprite_Stage1, priest_model_Sprite_Stage2, priest_model_Sprite_Stage3, Costume_Male, Costume_Female, Male_1, female_2 ;
    public AudioSource FGO;
    public AudioClip BGM;
    // Start is called before the first frame update
    void Start()
    {
        Mainmenu1.SetActive(true);
        Gender.SetActive(false);
        Costume_Male.SetActive(false);
        Costume_Female.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        FGO.clip = BGM;
    }

    public void mainmenu()
    {
        Gender.SetActive(true);
        Mainmenu1.SetActive(false);
        
    }

    public void exit()
    {
        Application.Quit();
    }

    public void Male()
    {
        eggplant_sprite_new_1.SetActive(false);
        priest_model_Sprite_Stage1.SetActive(true);
        Costume_Male.SetActive(true);
        Costume_Female.SetActive(false);
        female_2.SetActive(false);
    }

    public void Female()
    {
        eggplant_sprite_new_1.SetActive(true);
        priest_model_Sprite_Stage1.SetActive(false);
        Costume_Female.SetActive(true);
        Costume_Male.SetActive(false);
        Male_1.SetActive(false);
    }

    public void costume_Male1() 
    {
        priest_model_Sprite_Stage1.SetActive(true);
        priest_model_Sprite_Stage2.SetActive(false);
        priest_model_Sprite_Stage3.SetActive(false);
    }

    public void costume_Male2() 
    {
        priest_model_Sprite_Stage2.SetActive(true);
        priest_model_Sprite_Stage1.SetActive(false);
        priest_model_Sprite_Stage3.SetActive(false);
    }

    public void costume_Male3() 
    {
        priest_model_Sprite_Stage3.SetActive(true);
        priest_model_Sprite_Stage2.SetActive(false);
        priest_model_Sprite_Stage1.SetActive(false);
    }

    public void costume_Female1() 
    {
        eggplant_sprite_new_1.SetActive(true);
        eggplant_sprite_new_2.SetActive(false);
        eggplant_sprite_new_3.SetActive(false);
    } 
    public void costume_Female2() 
    {
        eggplant_sprite_new_2.SetActive(true);
        eggplant_sprite_new_1.SetActive(false);
        eggplant_sprite_new_3.SetActive(false);
    }
    public void costume_Female3() 
    {
        eggplant_sprite_new_3.SetActive(true);
        eggplant_sprite_new_2.SetActive(false);
        eggplant_sprite_new_1.SetActive(false);
    }

    public void Reset()
    {
      Male_1.SetActive(true);
      female_2.SetActive(true);
      Costume_Male.SetActive(false);
      Costume_Female.SetActive(false);
      eggplant_sprite_new_1.SetActive(false);
      eggplant_sprite_new_2.SetActive(false);
      eggplant_sprite_new_3.SetActive(false);
      priest_model_Sprite_Stage1.SetActive(false);
      priest_model_Sprite_Stage2.SetActive(false);
      priest_model_Sprite_Stage3.SetActive(false);
    }

    public void return_mainmenu() 
    {
        Mainmenu1.SetActive(true);
        Gender.SetActive(false);
        Costume_Male.SetActive(false);
        Costume_Female.SetActive(false);
        priest_model_Sprite_Stage1.SetActive(false);
        priest_model_Sprite_Stage2.SetActive(false);
        priest_model_Sprite_Stage3.SetActive(false);
        eggplant_sprite_new_1.SetActive(false);
        eggplant_sprite_new_2.SetActive(false);
        eggplant_sprite_new_3.SetActive (false);
    }

}
