using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyFunctions : MonoBehaviour {
    public GameObject MrPerson;
    public bool AreYouMrDark;
    public GameObject Gameplay;
    public GameObject MrPersonGameObject;
    public GameObject MrPersonMusic;
    public GameObject GameOverScreen;
    public GameObject GameOverMusic;
    public GameObject Dvic1, Dvic2, Dvic3, Dvic4, Lvic1, Lvic2, Lvic3, Lvic4, UltEnding;
    public GameObject VictoryMusic;
    public GameObject UltEndingMusic;
    public GameObject LeftButtonPress;
    public GameObject RightButtonPress;
    public GameObject Left1, Left2, Left3;
    public GameObject Right1, Right2, Right3;
    private int Damage = 8;
    private int MinorDamage = 1;
    public Text Instruction;
    public Text ShipHealth;
    public int SHealth = 1000;
    public Text EnemyHealth;
    private int EHealth = 1000;
    private bool Shields = true;
    public bool PressedButton = true;
    public Text ShieldStatus;
    public bool BabyMode = false;
    public bool Easy = true;
    public bool Medium = false;
    public bool Excruciatinglyhard = false;
    public bool UFB = false;

    void Start()
    {
        if(BabyMode == true)
        {
            Instruction = GameObject.Find("InstructionTextBabyMode").GetComponent<Text>();
        }
        else
        {
            Instruction = GameObject.Find("InstructionTextNormalMode").GetComponent<Text>();
        }
        ShipHealth.text = SHealth.ToString();
        EnemyHealth.text = EHealth.ToString();
        ShieldStatus.text = "ON";
    }
	
	// Update is called once per frame
	void Update () {

        if(SHealth <= 0)
        {
            Gameplay.SetActive(false);
            MrPersonGameObject.SetActive(false);
            MrPersonMusic.SetActive(false);
            GameOverScreen.SetActive(true);
            GameOverMusic.SetActive(true);
            if (UFB == true)
            {
                SHealth = 1000;
                ShipHealth.text = SHealth.ToString();
                EHealth = 1200;
                EnemyHealth.text = EHealth.ToString();
            } else if(BabyMode == true)
            {
                SHealth = 1000;
                ShipHealth.text = SHealth.ToString();
                EHealth = 200;
                EnemyHealth.text = EHealth.ToString();
            } else
            {
                SHealth = 1000;
                ShipHealth.text = SHealth.ToString();
                EHealth = 1000;
                EnemyHealth.text = EHealth.ToString();
            }
        }

        if(EHealth <= 0)
        {
            if(BabyMode == true)
            {
                if(AreYouMrDark == true)
                {
                    Gameplay.SetActive(false);
                    MrPersonGameObject.SetActive(false);
                    MrPersonMusic.SetActive(false);
                    Dvic1.SetActive(true);
                    VictoryMusic.SetActive(true);
                    SHealth = 1000;
                    ShipHealth.text = SHealth.ToString();
                    EHealth = 200;
                    EnemyHealth.text = EHealth.ToString();
                }
                else if(AreYouMrDark == false)
                {
                    Gameplay.SetActive(false);
                    MrPersonGameObject.SetActive(false);
                    MrPersonMusic.SetActive(false);
                    Lvic1.SetActive(true);
                    VictoryMusic.SetActive(true);
                    SHealth = 1000;
                    ShipHealth.text = SHealth.ToString();
                    EHealth = 200;
                    EnemyHealth.text = EHealth.ToString();
                }    
            }
            else if (Easy == true)
            {
                if (AreYouMrDark == true)
                {
                    Gameplay.SetActive(false);
                    MrPersonGameObject.SetActive(false);
                    MrPersonMusic.SetActive(false);
                    Dvic2.SetActive(true);
                    VictoryMusic.SetActive(true);
                    SHealth = 1000;
                    ShipHealth.text = SHealth.ToString();
                    EHealth = 1000;
                    EnemyHealth.text = EHealth.ToString();
                }
                else if (AreYouMrDark == false)
                {
                    Gameplay.SetActive(false);
                    MrPersonGameObject.SetActive(false);
                    MrPersonMusic.SetActive(false);
                    Lvic2.SetActive(true);
                    VictoryMusic.SetActive(true);
                    SHealth = 1000;
                    ShipHealth.text = SHealth.ToString();
                    EHealth = 1000;
                    EnemyHealth.text = EHealth.ToString();
                }
            }
            else if (Medium == true)
            {
                if (AreYouMrDark == true)
                {
                    Gameplay.SetActive(false);
                    MrPersonGameObject.SetActive(false);
                    MrPersonMusic.SetActive(false);
                    Dvic3.SetActive(true);
                    VictoryMusic.SetActive(true);
                    SHealth = 1000;
                    ShipHealth.text = SHealth.ToString();
                    EHealth = 1000;
                    EnemyHealth.text = EHealth.ToString();
                }
                else if (AreYouMrDark == false)
                {
                    Gameplay.SetActive(false);
                    MrPersonGameObject.SetActive(false);
                    MrPersonMusic.SetActive(false);
                    Lvic3.SetActive(true);
                    VictoryMusic.SetActive(true);
                    SHealth = 1000;
                    ShipHealth.text = SHealth.ToString();
                    EHealth = 1000;
                    EnemyHealth.text = EHealth.ToString();
                }
            }
            else if (Excruciatinglyhard == true)
            {
                if (AreYouMrDark == true)
                {
                    Gameplay.SetActive(false);
                    MrPersonGameObject.SetActive(false);
                    MrPersonMusic.SetActive(false);
                    Dvic4.SetActive(true);
                    VictoryMusic.SetActive(true);
                    SHealth = 1000;
                    ShipHealth.text = SHealth.ToString();
                    EHealth = 1000;
                    EnemyHealth.text = EHealth.ToString();
                }
                else if (AreYouMrDark == false)
                {
                    Gameplay.SetActive(false);
                    MrPersonGameObject.SetActive(false);
                    MrPersonMusic.SetActive(false);
                    Lvic4.SetActive(true);
                    VictoryMusic.SetActive(true);
                    SHealth = 1000;
                    ShipHealth.text = SHealth.ToString();
                    EHealth = 1000;
                    EnemyHealth.text = EHealth.ToString();
                }
            }
            else if (UFB == true)
            {
                Gameplay.SetActive(false);
                MrPersonGameObject.SetActive(false);
                MrPersonMusic.SetActive(false);
                UltEnding.SetActive(true);
                UltEndingMusic.SetActive(true);
                SHealth = 1000;
                ShipHealth.text = SHealth.ToString();
                EHealth = 1200;
                EnemyHealth.text = EHealth.ToString();
            }
        }

 
        if (Input.GetKeyDown(KeyCode.W)) //Attack
        {
            PressedButton = true;
            MrPerson.SetActive(false);
            LeftButtonPress.SetActive(false);
            RightButtonPress.SetActive(false);
            Left1.SetActive(false);
            Left2.SetActive(true);
            Left3.SetActive(false);
            Right1.SetActive(false);
            Right2.SetActive(false);
            Right3.SetActive(false);

            if(Instruction.text == "Attack" || Instruction.text == "W Attack")
            {
                EHealth -= Damage;
                EnemyHealth.text = EHealth.ToString();
            }
            else
            {
                if(Shields == true)
                {
                    Shields = false;
                    ShieldStatus.text = "OFF";
                }
                else
                {
                    SHealth -= Damage;
                    ShipHealth.text = SHealth.ToString();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.A)) //Move Left
        {
            PressedButton = true;
            MrPerson.SetActive(false);
            LeftButtonPress.SetActive(true);
            RightButtonPress.SetActive(false);
            Left1.SetActive(false);
            Left2.SetActive(false);
            Left3.SetActive(false);
            Right1.SetActive(false);
            Right2.SetActive(false);
            Right3.SetActive(false);

            if (Instruction.text == "Turn Left" || Instruction.text == "A Turn Left")
            {
                if (Shields == true)
                {
                    Shields = false;
                    ShieldStatus.text = "OFF";
                }
                else
                {
                    SHealth -= MinorDamage;
                    ShipHealth.text = SHealth.ToString();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.S)) //Shields
        {
            PressedButton = true;
            MrPerson.SetActive(false);
            LeftButtonPress.SetActive(false);
            RightButtonPress.SetActive(false);
            Left1.SetActive(false);
            Left2.SetActive(false);
            Left3.SetActive(false);
            Right1.SetActive(false);
            Right2.SetActive(true);
            Right3.SetActive(false);

            if (Instruction.text == "Sheilds" || Instruction.text == "S Sheilds")
            {
                Shields = true;
                ShieldStatus.text = "ON";
            }
            else
            {
                if (Shields == true)
                {
                    Shields = false;
                }
                else
                {
                    SHealth -= MinorDamage;
                    ShipHealth.text = SHealth.ToString();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.D)) //MoveRight
        {
            PressedButton = true;
            MrPerson.SetActive(false);
            LeftButtonPress.SetActive(false);
            RightButtonPress.SetActive(true);
            Left1.SetActive(false);
            Left2.SetActive(false);
            Left3.SetActive(false);
            Right1.SetActive(false);
            Right2.SetActive(false);
            Right3.SetActive(false);

            if (Instruction.text == "Turn Right" || Instruction.text == "D Turn Right")
            {

                if (Shields == true)
                {
                    Shields = false;
                    ShieldStatus.text = "OFF";
                }
                else
                {
                    SHealth -= MinorDamage;
                    ShipHealth.text = SHealth.ToString();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)) //Restore Health
        {
            PressedButton = true;
            MrPerson.SetActive(false);
            LeftButtonPress.SetActive(false);
            RightButtonPress.SetActive(false);
            Left1.SetActive(false);
            Left2.SetActive(false);
            Left3.SetActive(true);
            Right1.SetActive(false);
            Right2.SetActive(false);
            Right3.SetActive(false);

            if (Instruction.text == "Health" || Instruction.text == "Space Health")
            {
                if (SHealth + 8 < 1000)
                {
                    SHealth += 8;
                    ShipHealth.text = SHealth.ToString();
                } else
                {
                    SHealth = 1000;
                    ShipHealth.text = SHealth.ToString();
                }
            }
            else
            {
                if (Shields == true)
                {
                    Shields = false;
                    ShieldStatus.text = "OFF";
                }
                else
                {
                    SHealth -= MinorDamage;
                    ShipHealth.text = SHealth.ToString();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Q)) //Recharge Oxygen
        {
            PressedButton = true;
            MrPerson.SetActive(false);
            LeftButtonPress.SetActive(false);
            RightButtonPress.SetActive(false);
            Left1.SetActive(false);
            Left2.SetActive(false);
            Left3.SetActive(false);
            Right1.SetActive(true);
            Right2.SetActive(false);
            Right3.SetActive(false);

            if (Instruction.text == "Oxygen" || Instruction.text == "Q Oxygen")
            {
                if (SHealth + 4 < 1000)
                {
                    SHealth += 4;
                    ShipHealth.text = SHealth.ToString();
                }
                else
                {
                    SHealth = 1000;
                    ShipHealth.text = SHealth.ToString();
                }
            }
            else
            {
                if (Shields == true)
                {
                    Shields = false;
                    ShieldStatus.text = "OFF";
                }
                else
                {
                    SHealth -= MinorDamage;
                    ShipHealth.text = SHealth.ToString();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.E)) //Hyperspace Jump
        {
            PressedButton = true;
            MrPerson.SetActive(false);
            LeftButtonPress.SetActive(false);
            RightButtonPress.SetActive(false);
            Left1.SetActive(false);
            Left2.SetActive(false);
            Left3.SetActive(false);
            Right1.SetActive(false);
            Right2.SetActive(false);
            Right3.SetActive(true);

            if (Instruction.text == "Jump To Hyperspace" || Instruction.text == "E Jump To Hyperspace")
            {
                if (Shields == true)
                {
                    Shields = false;
                    ShieldStatus.text = "OFF";
                }
                else
                {
                    SHealth -= MinorDamage;
                    ShipHealth.text = SHealth.ToString();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.R)) //Big Red Button
        {
            PressedButton = true;
            MrPerson.SetActive(false);
            LeftButtonPress.SetActive(false);
            RightButtonPress.SetActive(false);
            Left1.SetActive(true);
            Left2.SetActive(false);
            Left3.SetActive(false);
            Right1.SetActive(false);
            Right2.SetActive(false);
            Right3.SetActive(false);

            if (Instruction.text == "Big Red Button" || Instruction.text == "R Big Red Button")
            {
                EHealth -= Damage * 2;
                EnemyHealth.text = EHealth.ToString();
            }
            else
            {
                if (Shields == true)
                {
                    Shields = false;
                    ShieldStatus.text = "OFF";
                }
                else
                {
                    SHealth -= Damage * 2;
                    ShipHealth.text = SHealth.ToString();
                }
            }
        }


    }

    public void BabyModez()
    {
        Damage = 50;
        EHealth = 200;
        EnemyHealth.text = EHealth.ToString();
        MinorDamage = 1;
        BabyMode = true;
        Easy = false;
        Medium = false;
        Excruciatinglyhard = false;
        UFB = false;
    }

    public void EasyLevel()
    {
        Damage = 8;
        MinorDamage = 1;
        BabyMode = false;
        Easy = true;
        Medium = false;
        Excruciatinglyhard = false;
        UFB = false;
    }

    public void MediumLevel()
    {
        Damage = 12;
        MinorDamage = 3;
        BabyMode = false;
        Easy = false;
        Medium = true;
        Excruciatinglyhard = false;
        UFB = false;
    }

    public void HardLevel()
    {
        Damage = 16;
        MinorDamage = 6;
        BabyMode = false;
        Easy = false;
        Medium = false;
        Excruciatinglyhard = true;
        UFB = false;
    }

    public void UFBB()
    {
        EHealth = 1200;
        Damage = 35;
        MinorDamage = 20;
        BabyMode = false;
        Easy = false;
        Medium = false;
        Excruciatinglyhard = false;
        UFB = true;
    }
}
