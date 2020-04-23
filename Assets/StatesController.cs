using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatesController : MonoBehaviour
{
    public GameObject imageHolder;
    public Text nameHolder;
    public Text descriptionText;
    public Text textAllPage;
    public Button button0;
    public Button button1;
    public Button button2;
    public Button button3;
    public AudioSource audioData;
    public InputField inputField;

    public Sprite[] allSprrites;

    enum StoryStates {GameOver, MainMenu,State0, State0f, State1, State2, State3,State3f, State4, State5, State6, State7, State7f, State8, State8a1,State8a2, State8b1, State8b2, State8b3, State8b4, State9, State10, State11
    ,State12,State13,State14,State15,State16,State17,State18,State19,State20,State21,State22,State23,State24,State25,State26,State27,State28,State29,State30,State31,State31a1,State31a2, State31a3,State31b1,
    State31b2,State31b3,State31b4,State31b5,State31b6,State31b7,State31b8,State31b9,State31b10, State32, State33, State34, State35, State36, State36a1, State36a2, State36a3, State36a4, State36a5, State36a5a1,
    State36a5b1, State36a5b2, State36a5c1, State36a5c2, State36a5c3, State36a5c4, State36a5c5 , State36b1, State36b2, State36b3, State36b4, State36b5, State36b6, State36b7, State36b8
    , State36b9, State36b10, State36b11, State36b12, State36b13, State36b14, State36b15, State36b16, State36b17, State36b18, State36b19, State36b20,State36b21,State36b22,State36b23,State36b24,State36b25,
    State36ab, State36ab1, State36c1, State36c2, State36c3, State36c4, State36c5, State36c6, State36c7, State36c8, State36c9, State36c10, State36c11, State36c12, State36c12a1, 
    State36c12a2,State36c12a3, State36c12a4, State36c12a5, State36c12a6, State36c12a7, State36c12a8, State36c12a9,State36c12b1, State36c12b2, State36c12b3, State36c12b4, State36c12b5, 
    State36c12b6, State36c12b7, State36c12b8, State36c12b9, State36c12b10, State36c12b11, State36c12b12, State36c12b13, State36c12b14,State37, State38, State39, State40, State41, State42, State43, State44, State45, State46,
    State47, State48, State49, State50, State50a1, State50a2, State50b1, State50b2, State50b3, State50b4, State50b5, State51, State52, State52a1, State52a2,State52a3,
    State52a4,State52a5,State52a6,State52b1,State52b2,State52c1,State52c2,State52c3, State53, State53a1, State53a2, State53a3, State53a4, State53a5, State53b1, State53b2, State54, State55, State56, State57, State58, State59,
    State60, State61, State62, State63, State63a1, State63a2, State63a3, State63a4, State63a5, State63a6, State63a7, State63a8, State63a9, State63b1, State63b2, State63b3,
    State63b4, State63b5, State63b6, State63b7, State63b8, State63b9, State64, State65, State65a1, State65a2, State65a3, State65a4, State65a5, State65a6, State65a7
    , State65a8, State65a9, State65b1, State65b2, State65b3, State65b4, State65b5, State65b6, State65b7, State65b8, State65b9, State65b10, State65b11,State65c1, State65c1a1,
     State65c1a2, State65c1a3, State65c1a4, State65c1a5, State65c1a6, State65c1a7, State65c1a8, State65c1a9, State65c1a10, State65c1a11, State66 ,State65c1b1, State65c1b2
     , State65c1b3, State65c1b4, State65c1b4a1, State65c1b4a2
     , State65c1b4a3, State65c1b4b1, State65c1b4b2, State65c1b4b3, State65c1b4b4, State65c1b4b5, State65c1b4c1, State65c1b4c2, State65c1b4c3, State65c1b4c4, State65c1b4c5
     , State65c1b4c6, State65c1b4c7 , State67, State68, State69, State70, State71, State72,State73,State74,State75,State76,State76a1,State76a2,State76a3,State76a4
     ,State76a5,State76a6, State76b1, State76b2, State76b3,State76b4, State76b5, State76b6, State76b7, State76b8, State76b9};
    StoryStates currentState;
    
    int nights = 0;
    bool money = false;
    bool injured = false; 
    bool nights_increased = false;
    bool troll_alive = true;
    bool puzzle_solved = false;
    bool christofor = false;
    bool leshy = false;

    // Start is called before the first frame update
    void Start() {
        currentState = StoryStates.MainMenu;
        textAllPage.text = "";
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 99999999;
    }

    // Update is called once per frame
    void Update() {
        switch (currentState) {
            case StoryStates.GameOver:
                GameOver();
                break;
            case StoryStates.MainMenu:
                MainMenu();
                break;
            case StoryStates.State0:
                State0();
                break;
            case StoryStates.State0f:
                State0f();
                break;
            case StoryStates.State1:
                State1();
                break;
            case StoryStates.State2:
                State2();
                break;
            case StoryStates.State3:
                State3();
                break;
            case StoryStates.State3f:
                State3f();
                break;
            case StoryStates.State4:
                State4();
                break;
            case StoryStates.State5:
                State5();
                break;
            case StoryStates.State6:
                State6();
                break;
            case StoryStates.State7:
                State7();
                break;
            case StoryStates.State7f:
                State7f();
                break;
            case StoryStates.State8:
                State8();
                break;
            case StoryStates.State8a1:
                State8a1();
                break;
            case StoryStates.State8a2:
                State8a2();
                break;
            case StoryStates.State8b1:
                State8b1();
                break;
            case StoryStates.State8b2:
                State8b2();
                break;
            case StoryStates.State8b3:
                State8b3();
                break;
            case StoryStates.State8b4:
                State8b4();
                break;
            case StoryStates.State9:
                State9();
                break;
            case StoryStates.State10:
                State10();
                break;
            case StoryStates.State11:
                State11();
                break;
            case StoryStates.State12:
                State12();
                break;
                case StoryStates.State13:
                State13();
                break;
                case StoryStates.State14:
                State14();
                break;
                case StoryStates.State15:
                State15();
                break;
                case StoryStates.State16:
                State16();
                break;
                case StoryStates.State17:
                State17();
                break;
                case StoryStates.State18:
                State18();
                break;
                case StoryStates.State19:
                State19();
                break;
                case StoryStates.State20:
                State20();
                break;
                case StoryStates.State21:
                State21();
                break;
                case StoryStates.State22:
                State22();
                break;
                case StoryStates.State23:
                State23();
                break;
                case StoryStates.State24:
                State24();
                break;
                case StoryStates.State25:
                State25();
                break;
                case StoryStates.State26:
                State26();
                break;
                case StoryStates.State27:
                State27();
                break;
                case StoryStates.State28:
                State28();
                break;
                case StoryStates.State29:
                State29();
                break;
                case StoryStates.State30:
                State30();
                break;
                case StoryStates.State31:
                State31();
                break;
                case StoryStates.State31a1:
                State31a1();
                break;
                case StoryStates.State31a2:
                State31a2();
                break;
                case StoryStates.State31a3:
                State31a3();
                break;
                case StoryStates.State31b1:
                State31b1();
                break;
                case StoryStates.State31b2:
                State31b2();
                break;
                case StoryStates.State31b3:
                State31b3();
                break;
                case StoryStates.State31b4:
                State31b4();
                break;
                case StoryStates.State31b5:
                State31b5();
                break;
                case StoryStates.State31b6:
                State31b6();
                break;
                case StoryStates.State31b7:
                State31b7();
                break;
                case StoryStates.State31b8:
                State31b8();
                break;
                case StoryStates.State31b9:
                State31b9();
                break;
                case StoryStates.State31b10:
                State31b10();
                break;
                case StoryStates.State32:
                State32();
                break;
                case StoryStates.State33:
                State33();
                break;
                case StoryStates.State34:
                State34();
                break;
                case StoryStates.State35:
                State35();
                break;
                case StoryStates.State36:
                State36();
                break;
                case StoryStates.State36a1:
                State36a1();
                break;
                case StoryStates.State36a2:
                State36a2();
                break;
                case StoryStates.State36a3:
                State36a3();
                break;
                case StoryStates.State36a4:
                State36a4();
                break;
                case StoryStates.State36a5:
                State36a5();
                break;
                case StoryStates.State36a5a1:
                State36a5a1();
                break;
                case StoryStates.State36a5b1:
                State36a5b1();
                break;
                case StoryStates.State36a5b2:
                State36a5b2();
                break;
                case StoryStates.State36a5c1:
                State36a5c1();
                break;
                case StoryStates.State36a5c2:
                State36a5c2();
                break;
                case StoryStates.State36a5c3:
                State36a5c3();
                break;
                case StoryStates.State36a5c4:
                State36a5c4();
                break;
                case StoryStates.State36a5c5:
                State36a5c5();
                break;
                case StoryStates.State36b1:
                State36b1();
                break;
                case StoryStates.State36b2:
                State36b2();
                break;
                 case StoryStates.State36b3:
                State36b3();
                break;
                 case StoryStates.State36b4:
                State36b4();
                break;
                 case StoryStates.State36b5:
                State36b5();
                break;
                 case StoryStates.State36b6:
                State36b6();
                break;
                 case StoryStates.State36b7:
                State36b7();
                break;
                 case StoryStates.State36b8:
                State36b8();
                break;
                 case StoryStates.State36b9:
                State36b9();
                break;
                 case StoryStates.State36b10:
                State36b10();
                break;
                 case StoryStates.State36b11:
                State36b11();
                break;
                 case StoryStates.State36b12:
                State36b12();
                break;
                 case StoryStates.State36b13:
                State36b13();
                break;
                 case StoryStates.State36b14:
                State36b14();
                break;
                 case StoryStates.State36b15:
                State36b15();
                break;
                 case StoryStates.State36b16:
                State36b16();
                break;
                 case StoryStates.State36b17:
                State36b17();
                break;
                 case StoryStates.State36b18:
                State36b18();
                break;
                 case StoryStates.State36b19:
                State36b19();
                break;
                 case StoryStates.State36b20:
                State36b20();
                break;
                case StoryStates.State36b21:
                State36b21();
                break;
                case StoryStates.State36b22:
                State36b22();
                break;
                case StoryStates.State36b23:
                State36b23();
                break;
                case StoryStates.State36b24:
                State36b24();
                break;
                case StoryStates.State36b25:
                State36b25();
                break;
                case StoryStates.State36ab:
                State36ab();
                break;
                case StoryStates.State36ab1:
                State36ab1();
                break;
                case StoryStates.State36c1:
                State36c1();
                break;
                case StoryStates.State36c2:
                State36c2();
                break;
                case StoryStates.State36c3:
                State36c3();
                break;
                case StoryStates.State36c4:
                State36c4();
                break;
                case StoryStates.State36c5:
                State36c5();
                break;
                case StoryStates.State36c6:
                State36c6();
                break;
                case StoryStates.State36c7:
                State36c7();
                break;
                case StoryStates.State36c8:
                State36c8();
                break;
                case StoryStates.State36c9:
                State36c9();
                break;
                case StoryStates.State36c10:
                State36c10();
                break;
                case StoryStates.State36c11:
                State36c11();
                break;
                case StoryStates.State36c12:
                State36c12();
                break;
                case StoryStates.State36c12a1:
                State36c12a1();
                break;
                case StoryStates.State36c12a2:
                State36c12a2();
                break;
                case StoryStates.State36c12a3:
                State36c12a3();
                break;
                case StoryStates.State36c12a4:
                State36c12a4();
                break;
                case StoryStates.State36c12a5:
                State36c12a5();
                break;
                case StoryStates.State36c12a6:
                State36c12a6();
                break;          
                case StoryStates.State36c12a7:
                State36c12a7();
                break;
                case StoryStates.State36c12a8:
                State36c12a8();
                break;
                case StoryStates.State36c12a9:
                State36c12a9();
                break;                
                case StoryStates.State36c12b1:
                State36c12b1();
                break;
                case StoryStates.State36c12b2:
                State36c12b2();
                break;
                case StoryStates.State36c12b3:
                State36c12b3();
                break;
                case StoryStates.State36c12b4:
                State36c12b4();
                break;
                case StoryStates.State36c12b5:
                State36c12b5();
                break;                
                case StoryStates.State36c12b6:
                State36c12b6();
                break;
                case StoryStates.State36c12b7:
                State36c12b7();
                break;
                case StoryStates.State36c12b8:
                State36c12b8();
                break;
                case StoryStates.State36c12b9:
                State36c12b9();
                break;
                case StoryStates.State36c12b10:
                State36c12b10();
                break;
                case StoryStates.State36c12b11:
                State36c12b11();
                break;
                case StoryStates.State36c12b12:
                State36c12b12();
                break;                
                case StoryStates.State36c12b13:
                State36c12b13();
                break;
                case StoryStates.State36c12b14:
                State36c12b14();
                break;
                case StoryStates.State37:
                State37();
                break;                
                case StoryStates.State38:
                State38();
                break;
                case StoryStates.State39:
                State39();
                break;
                case StoryStates.State40:
                State40();
                break;
                case StoryStates.State41:
                State41();
                break;
                case StoryStates.State42:
                State42();
                break;
                case StoryStates.State43:
                State43();
                break;
                case StoryStates.State44:
                State44();
                break;                
                case StoryStates.State45:
                State45();
                break;
                case StoryStates.State46:
                State46();
                break;
                case StoryStates.State47:
                State47();
                break;
                case StoryStates.State48:
                State48();
                break;
                case StoryStates.State49:
                State49();
                break;    
                case StoryStates.State50:
                State50();
                break;
                case StoryStates.State50a1:
                State50a1();
                break;    
                case StoryStates.State50a2:
                State50a2();
                break;                
                case StoryStates.State50b1:
                State50b1();
                break;
                case StoryStates.State50b2:
                State50b2();
                break;                   
                case StoryStates.State50b3:
                State50b3();
                break;                   
                case StoryStates.State50b4:
                State50b4();
                break;                   
                case StoryStates.State50b5:
                State50b5();
                break;
                case StoryStates.State51:
                State51();
                break;          
                case StoryStates.State52:
                State52();
                break;                       
                case StoryStates.State52a1:
                State52a1();
                break;  
                case StoryStates.State52a2:
                State52a2();
                break;
                case StoryStates.State52a3:
                State52a3();
                break; 
                case StoryStates.State52a4:
                State52a4();
                break;
                case StoryStates.State52a5:
                State52a5();
                break;
                case StoryStates.State52b1:
                State52b1();
                break;
                case StoryStates.State52b2:
                State52b2();
                break;
                case StoryStates.State52c1:
                State52c1();
                break;
                case StoryStates.State52c2:
                State52c2();
                break;
                case StoryStates.State52c3:
                State52c3();
                break;
                case StoryStates.State53:
                State53();
                break;
                case StoryStates.State53a1:
                State53a1();
                break;
                case StoryStates.State53a2:
                State53a2();
                break;
                case StoryStates.State53a3:
                State53a3();
                break;
                case StoryStates.State53a4:
                State53a4();
                break;
                case StoryStates.State53a5:
                State53a5();
                break;
                case StoryStates.State53b1:
                State53b1();
                break;
                case StoryStates.State53b2:
                State53b2();
                break;
                case StoryStates.State54:
                State54();
                break;
                case StoryStates.State55:
                State55();
                break;
                case StoryStates.State56:
                State56();
                break;
                case StoryStates.State57:
                State57();
                break;
                case StoryStates.State58:
                State58();
                break;
                case StoryStates.State59:
                State59();
                break;
                case StoryStates.State60:
                State60();
                break;
                case StoryStates.State61:
                State61();
                break;
                case StoryStates.State62:
                State62();
                break;
                case StoryStates.State63:
                State63();
                break;
                case StoryStates.State63a1:
                State63a1();
                break;
                case StoryStates.State63a2:
                State63a2();
                break;
                case StoryStates.State63a3:
                State63a3();
                break;
                case StoryStates.State63a4:
                State63a4();
                break;
                case StoryStates.State63a5:
                State63a5();
                break;
                case StoryStates.State63a6:
                State63a6();
                break;
                case StoryStates.State63a7:
                State63a7();
                break;
                case StoryStates.State63a8:
                State63a8();
                break;
                case StoryStates.State63a9:
                State63a9();
                break;
                case StoryStates.State63b1:
                State63b1();
                break;
                case StoryStates.State63b2:
                State63b2();
                break;
                case StoryStates.State63b3:
                State63b3();
                break;
                case StoryStates.State63b4:
                State63b4();
                break;
                case StoryStates.State63b5:
                State63b5();
                break;
                case StoryStates.State63b6:
                State63b6();
                break;
                case StoryStates.State63b7:
                State63b7();
                break;
                case StoryStates.State64:
                State64();
                break;
                case StoryStates.State65:
                State65();
                break;
                case StoryStates.State65a1:
                State65a1();
                break;
                case StoryStates.State65a2:
                State65a2();
                break;
                case StoryStates.State65a3:
                State65a3();
                break;
                case StoryStates.State65a4:
                State65a4();
                break;
                case StoryStates.State65a5:
                State65a5();
                break;
                case StoryStates.State65a6:
                State65a6();
                break;
                case StoryStates.State65a7:
                State65a7();
                break;
                case StoryStates.State65a8:
                State65a8();
                break;
                case StoryStates.State65a9:
                State65a9();
                break;
                case StoryStates.State65b1:
                State65b1();
                break;
                case StoryStates.State65b2:
                State65b2();
                break;
                case StoryStates.State65b3:
                State65b3();
                break;
                case StoryStates.State65b4:
                State65b4();
                break;
                case StoryStates.State65b5:
                State65b5();
                break;
                case StoryStates.State65b6:
                State65b6();
                break;
                case StoryStates.State65b7:
                State65b7();
                break;
                case StoryStates.State65b8:
                State65b8();
                break;
                case StoryStates.State65b9:
                State65b9();
                break;
                case StoryStates.State65b10:
                State65b10();
                break;
                case StoryStates.State65b11:
                State65b11();
                break;
                case StoryStates.State65c1:
                State65c1();
                break;
                case StoryStates.State65c1a1:
                State65c1a1();
                break;
                case StoryStates.State65c1a2:
                State65c1a2();
                break;
                case StoryStates.State65c1a3:
                State65c1a3();
                break;
                case StoryStates.State65c1a4:
                State65c1a4();
                break;
                case StoryStates.State65c1a5:
                State65c1a5();
                break;
                case StoryStates.State65c1a6:
                State65c1a6();
                break;
                case StoryStates.State65c1a7:
                State65c1a7();
                break;
                case StoryStates.State65c1a8:
                State65c1a8();
                break;
                case StoryStates.State65c1a9:
                State65c1a9();
                break;
                case StoryStates.State65c1a10:
                State65c1a10();
                break;
                case StoryStates.State65c1a11:
                State65c1a11();
                break;
                case StoryStates.State65c1b1:
                State65c1b1();
                break;
                case StoryStates.State65c1b2:
                State65c1b2();
                break;
                case StoryStates.State65c1b3:
                State65c1b3();
                break;
                case StoryStates.State65c1b4:
                State65c1b4();
                break;
                case StoryStates.State65c1b4a1:
                State65c1b4a1();
                break;
                case StoryStates.State65c1b4a2:
                State65c1b4a2();
                break;
                case StoryStates.State65c1b4a3:
                State65c1b4a3();
                break;
                case StoryStates.State65c1b4b1:
                State65c1b4b1();
                break;
                case StoryStates.State65c1b4b2:
                State65c1b4b2();
                break;
                case StoryStates.State65c1b4b3:
                State65c1b4b3();
                break;
                case StoryStates.State65c1b4b4:
                State65c1b4b4();
                break;
                case StoryStates.State65c1b4b5:
                State65c1b4b5();
                break;
                case StoryStates.State65c1b4c1:
                State65c1b4c1();
                break;
                case StoryStates.State65c1b4c2:
                State65c1b4c2();
                break;
                case StoryStates.State65c1b4c3:
                State65c1b4c3();
                break;
                case StoryStates.State65c1b4c4:
                State65c1b4c4();
                break;
                case StoryStates.State65c1b4c5:
                State65c1b4c5();
                break;
                case StoryStates.State65c1b4c6:
                State65c1b4c6();
                break;
                case StoryStates.State65c1b4c7:
                State65c1b4c7();
                break;
                case StoryStates.State66:
                State66();
                break;
                case StoryStates.State67:
                State67();
                break;
                case StoryStates.State68:
                State68();
                break;
                case StoryStates.State69:
                State69();
                break;
                case StoryStates.State70:
                State70();
                break;
                case StoryStates.State71:
                State71();
                break;
                case StoryStates.State72:
                State72();
                break;
                case StoryStates.State73:
                State73();
                break;
                case StoryStates.State74:
                State74();
                break;
                case StoryStates.State75:
                State75();
                break;
                case StoryStates.State76:
                State76();
                break;
                case StoryStates.State76a1:
                State76a1();
                break;
                case StoryStates.State76a2:
                State76a2();
                break;
                case StoryStates.State76a3:
                State76a3();
                break;
                case StoryStates.State76a4:
                State76a4();
                break;
                case StoryStates.State76a5:
                State76a5();
                break;
                case StoryStates.State76a6:
                State76a6();
                break;
                case StoryStates.State76b1:
                State76b1();
                break;
                case StoryStates.State76b2:
                State76b2();
                break;
                case StoryStates.State76b3:
                State76b3();
                break;
                case StoryStates.State76b4:
                State76b4();
                break;
                case StoryStates.State76b5:
                State76b5();
                break;
                case StoryStates.State76b6:
                State76b6();
                break;
                case StoryStates.State76b7:
                State76b7();
                break;
                case StoryStates.State76b8:
                State76b8();
                break;
                case StoryStates.State76b9:
                State76b9();
                break;
        }
    }

   void GameOver() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        descriptionText.text = "You died because you are stoopid";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(true);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);
         btn0.GetComponentInChildren<Text>().text = "Back to the start";
         btn0.onClick.AddListener(() => {currentState = StoryStates.MainMenu;});
        
    }

    void MainMenu() {
        currentState = StoryStates.MainMenu;
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[25];
        nameHolder.text = "";
        descriptionText.text = "The story of Algnir the Dwarf"; 
        InputField input = inputField.GetComponent<InputField>();
        input.gameObject.SetActive(false);
        textAllPage.text = "";

        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(true);

        btn3.GetComponentInChildren<Text>().text = "Click to start the game";
        audioData = GetComponent<AudioSource>();
      
        btn3.onClick.AddListener(() => {currentState = StoryStates.State0;});
        audioData.Play(0);
     
    }

    void State0() {

        currentState = StoryStates.State0;
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[0];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "*Evening, 3 mercenaries approach a tavern laughing and talking*"; 
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State0f;
        } 
    }

    
    void State0f() {

        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[1];
        nameHolder.text = "Mercenary1";
        descriptionText.text = "Here it is lads, finally, the famous Gwen."; 
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State1;
        } 
    }

      void State1() {

        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[2];
        nameHolder.text = "Mercenary2";
        descriptionText.text = "The ale you were talking about, better it to be as good as you described it."; 
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State2;
        }
        
        
    }

     void State2() {

        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[3];
        nameHolder.text = "Mercenary3";
        descriptionText.text = "I ain’t gonna make no step more on this damn road, without pouring some good ale down my throat."; 
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State3;
        }
        
        
    }

     void State3() {

        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[1];
        nameHolder.text = "Mercenary1";
        descriptionText.text = "I tell ya, lads - the finest ale in a hundred miles around. First round’s on me."; 
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State3f;
        }
        
        
    }

    void State3f() {

        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[4];
        nameHolder.text = "";
        descriptionText.text = "*The mercenaries enter the tavern*"; 
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State4;
        }
        
        
    }


      void State4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[4];
        nameHolder.text = "";
        descriptionText.text = "*Mercenary1 holds the door for the other two to enter, they see a table with only one person*"; 
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State5;
        }
        
    }

    void State5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[5];
        nameHolder.text = "Mercenary2";
        descriptionText.text = "Move it, old goat!"; 
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State6;
        }
        
    }

    void State6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[6];
        nameHolder.text = "";
        descriptionText.text = "*Mercenary2 pushes the old man from his stool, the other two men sit at the table*\n";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State7;
        }
        
    }

    void State7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[7];
        nameHolder.text = "Mercenary3";
        descriptionText.text = "These people nowadays have no respect for the soldiers *smirks and spits*.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State7f;
        }
    }

    void State7f() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[6];
        nameHolder.text = "";
        descriptionText.text = "*A ginger haired dwarf with blue eyes in innkeeper clothes looks at them from the distance judgeful*";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State8;
        }
    }

    void State8() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[8];
        nameHolder.text = "Mercenary2";
        descriptionText.text = "Innkeeper, bring us some of that famous ale, and better be swift! We have a long road ahead of us!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(true);
        btn1.gameObject.SetActive(true);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        btn0.GetComponentInChildren<Text>().text = "*Stay quiet and bring the ale* (Be silent)";
        btn1.GetComponentInChildren<Text>().text = "Now-now behave yourself, we’ve no need of troublemakers here";

        btn0.onClick.AddListener(() => {currentState = StoryStates.State8a1;});
        btn1.onClick.AddListener(() => {currentState = StoryStates.State8b1;});        
    }


    void State8a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[7];
        nameHolder.text = "Mercenary3";
        descriptionText.text = "Oi! The drink is on the way. What’d you say lads, maybe a round of cards?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State8a2;
        }
        
    }

        void State8a2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[6];
        nameHolder.text = "";
        descriptionText.text = "*Algnir goes to bring the Ale to the 3 travelers. Goes to the counter to fill them up*";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State9;
        }
        
    }

        void State8b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[5];
        nameHolder.text = "Mercenary2";
        descriptionText.text = "And who’s going to kick us out? Everyone who knows to hold a sword has gone to get slain bySonoria, so no proper man here!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State8b2;
        }
        
    }

    void State8b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[6];
        nameHolder.text = "";
        descriptionText.text = "*The other comrades are laughing*";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);
        
        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State8b3;
        }
    }

    void State8b3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[5];
        nameHolder.text = "Mercenary2";
        descriptionText.text = "Know your place, dwarf and bring us something to eat, now, or the <frontline> won’t be the only battlefield!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);
        
        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State8b4;
        }
    }

    void State8b4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[6];
        nameHolder.text = "";
        descriptionText.text = "*Algnir visually irritated decides not to cover his walls in their blood*";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);
        
        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State9;
        }
    }

    void State9() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[6];
        nameHolder.text = "";
        descriptionText.text = "*so Algnir goes brings the Ale to the 3 travelers. Goes to the counter to fill the another cups*";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);
        
        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State10;
        }
    }

    void State10() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[7];
        nameHolder.text = "";
        descriptionText.text = "*The Old man is also at the counter*";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);
        
        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State11;
        }
    }


    void State11() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[6];
        nameHolder.text = "Old man";
        descriptionText.text = "These fools, they have no idea of the hard life we’re living. Those mercenaries are no men, the real men are fighting now on the front like Groham.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State12;
        }
        
    }

      void State12() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[6];
        nameHolder.text = "Algnir";
        descriptionText.text = "Then my place should be there too.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State13;
        }
        
    }

      void State13() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[33];
        nameHolder.text = "Old man";
        descriptionText.text = "It will be more use of you here. Your good ale is the only thing that cheers up this ";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State14;
        }
        
    }

      void State14() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[33];
        nameHolder.text = "Old man";
        descriptionText.text = "It will be more use of you here. Your good ale is the only thing that cheers up this Aldun forsaken village. Besides, you know too well that you shouldn *[gets interrupted]*";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State15;
        }
        
    }

     void State15() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[6];
        nameHolder.text = "";
        descriptionText.text = "*Mercenary2 shouts from the other side of the room Dwarf* ";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State16;
        }
        
    }

    void State16() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[5];
        nameHolder.text = "Mercenary2";
        descriptionText.text = "Hey where is that ale?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State17;
        }
        
    }

    void State17() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[6];
        nameHolder.text = "";
        descriptionText.text = "*Algnir finishes filling the cups with Ale and as he approaches the table he heard their talk about the war*";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State18;
        }
        
    }

    
    void State18() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[6];
        nameHolder.text = "Mercenary1";
        descriptionText.text = "[...] and that’s it. The poor bastards will be surrounded with no chance to stand against us coming from the dead of the night.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State19;
        }
        
    }

    
    void State19() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[7];
        nameHolder.text = "Mercenary3";
        descriptionText.text = "Easiest coin I’ve had in my life.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State20;
        }
        
    }

     void State20() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[6];
        nameHolder.text = "";
        descriptionText.text = "*Algnir’s face changes to worried*";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State21;
        }
        
    }

    void State21() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[32];
        nameHolder.text = "Local1: *Strong independent looking woman by the name of Martha*";
        descriptionText.text = "How dare you, my son is fighting for yours and ours land and you dare talk this crap here, shame on you, you’ve no balls behind these leather plates.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State22;
        }
        
    }

    void State22() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[37];
        nameHolder.text = "";
        descriptionText.text = "Mercenary2 *Stands up draws his sword* *Mercenary3 stops him*";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State23;
        }
        
    }

    void State23() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[34];
        nameHolder.text = "Mercenary3";
        descriptionText.text = "Wait, Img’hur, Is that really how you want to claim you freshly forged sword? By slaining some helpless scum?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State24;
        }
        
    }

    void State24() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[37];
        nameHolder.text = "Mercenary2 *Scheathes his sword*";
        descriptionText.text = "Be thankful for the few days you have left, when Sonoria comes here, I’ll make sure to be in the first lines, to cut your filthy tongue off!.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State25;
        }
        
    }

    void State25() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[38];
        nameHolder.text = "";
        descriptionText.text = "*Algnir turns to the counter*";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State26;
        }
        
    }

    
    void State26() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[32];
        nameHolder.text = "Martha";
        descriptionText.text = "*With the female tenderness and care to calm the man’s heart* : Algnir, that can’t be true. Why would anybody talk so freely about an ambush?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State27;
        }
        
    }

    void State27() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[35];
        nameHolder.text = "Algnir";
        descriptionText.text = "Well they are mercenaries. On top of that, they are drunk. Why would THEY willingly go to the frontline? So I need to get to my brother Groham, he’s the only family I have, I need to make sure he’ll be alright, those stupid <Brother’s forces> made a mistake for not taking me. Either we overcome the battle, or die together, in a battle, as brothers should. ";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State28;
        }
        
    }

    
    void State28() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[33];
        nameHolder.text = "Old man";
        descriptionText.text = "Are you sure? How about your leg? ";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State29;
        }
        
    }

    
    void State29() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[35];
        nameHolder.text = "Algnir";
        descriptionText.text = "Nothing but a scratch to me. All my life I fought alongside my brother, it was a mistake from the beginning. I could take on these 3 fouls and not get a single cut and you know that!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State30;
        }
        
    }

    void State30() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[33];
        nameHolder.text = "Old man";
        descriptionText.text = "Yes. You could, but not anymore. But think of the village. We’ve few arms left to help us around. Are you going to go to the front-line because of some rumours?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State31;
        }
        
    }

    void State31() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[35];
        nameHolder.text = "";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(true);
        btn1.gameObject.SetActive(true);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        btn0.GetComponentInChildren<Text>().text = "*Start the journey*";
        btn1.GetComponentInChildren<Text>().text = "*Remain in the village*";

        btn0.onClick.AddListener(() => {currentState = StoryStates.State31a1;});
        btn1.onClick.AddListener(() => {currentState = StoryStates.State31b1;});
    }

    void State31a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[36];
        nameHolder.text = "Algnir";
        descriptionText.text = "Can you take care of the Inn until I come back with my brother?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

           if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State31a2;
        }
        
    }

    void State31a2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[32];
        nameHolder.text = "Martha";
        descriptionText.text = "And if you don’t come back?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

          if (Input.GetKeyDown(KeyCode.Space)){
           currentState = StoryStates.State31a3;
       }
        
    }

    void State31a3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[36];
        nameHolder.text = "Algnir";
        descriptionText.text = "(with a small hint of smile): In such a case, there is no finer death for a dwar than falling in a battle alongside his brother.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

          if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State32;
        }
        
    }

    
      void State31b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[36];
        nameHolder.text = "Algnir";
        descriptionText.text = " You are right. Maybe I should think with my mind clear. As the rule has it, rumours tend to be not so truthy...";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

           if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State31b2;
        }
        
    }

     void State31b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[32];
        nameHolder.text = "Martha";
        descriptionText.text = "That’s better. Now go sleep. I’ll take care of the guests for this night. Don’t look at me like that. It’s fine. I can handle them.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

           if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State31b3;
        }
        
    }

     void State31b3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[33];
        nameHolder.text = "";
        descriptionText.text = "Tired, Algnir goes home to take some good rest.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

           if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State31b4;
        }
        
    }

     void State31b4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        if (!nights_increased) {
            nights += 1;
            nights_increased = true;
        } 
        descriptionText.text = "";
        textAllPage.text = "You slept for one night.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

           if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State31b5;
        }
        
    }

    void State31b5() {
        nights_increased = false;
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[36];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "At the next morning, when cleaning up in the tavern, Algnir meets Martha again";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

           if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State31b6;
        }
        
    }

    void State31b6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[32];
        nameHolder.text = "Martha";
        descriptionText.text = "(worried):Algnir, there is something funny about those mercenaries from yesterday. One of them had this thing peeking out of his pocket, and it has Sonoria sign on it. Looks like they are going to trade their land for a few bloody crones.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

           if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State31b7;
        }
        
    }

    void State31b7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[36];
        nameHolder.text = "Algnir";
        descriptionText.text = "(Taking the note): pickpocketing again, eh?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

           if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State31b8;
        }
        
    }

    void State31b8() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        textAllPage.text = "The note has the content:";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

           if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State31b9;
        }
        
    }

     void State31b9() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[13];
        nameHolder.text = "";
        descriptionText.text = "";
        textAllPage.text = "By the name of King Brahn, Sonoria is searching for volunteers to bring the only light of truth to all lands of Moreya, by sword. The willing to participate should come near the frontline till the third solstice. The king will generously repay any braveman.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

           if (Input.GetKeyDown(KeyCode.Space)){
            currentState = StoryStates.State31b10;
        }
        
    }

    void State31b10() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[35];
        nameHolder.text = "Algnir";
        descriptionText.text = "So it is true. The ambush IS going to happen.Then I should go warn my brother… And all the army altogether.";
        textAllPage.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

          if (Input.GetKeyDown(KeyCode.Space)){
           currentState = StoryStates.State32;
        }
    }

     void State32() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[48];
        nameHolder.text = "";
        descriptionText.text = "*Algnir is leaving the tavern place, with a bag on his back, visually seen that he is headed to a mountain.*";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

          if (Input.GetKeyDown(KeyCode.Space)){
           currentState = StoryStates.State33;
        }
        
    }

     void State33() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[48];
        nameHolder.text = "";
        descriptionText.text = "Algnir has packed all his necessary tools and has embarked on a journey to save his brother";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

          if (Input.GetKeyDown(KeyCode.Space)){
           currentState = StoryStates.State34;
        }
        
    }

     void State34() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[48];
        nameHolder.text = "";
        descriptionText.text = "Algnir has packed all his necessary tools and has embarked on a journey to save his brother";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

          if (Input.GetKeyDown(KeyCode.Space)){
           currentState = StoryStates.State35;
        }
        
    }

     void State35() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[11];
        nameHolder.text = "Algnir";
        descriptionText.text = "So here we are at the mountain of Ald’rog. It has been ages since I have seen it so close. Nearly forgot how huge it really is. Seems that going to the other side of it could take some time…";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

          if (Input.GetKeyDown(KeyCode.Space)){
           currentState = StoryStates.State36;
        }
        
    }

     void State36() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[25];
        nameHolder.text = "Algnir";
        descriptionText.text = "So I think i will";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(true);
        btn1.gameObject.SetActive(true);
        btn2.gameObject.SetActive(true);
        btn3.gameObject.SetActive(false);

        btn0.GetComponentInChildren<Text>().text = "Go over the mountain. It seems to have the fastest road";
        btn1.GetComponentInChildren<Text>().text = "Go around the mountain. Seems to be safer, since I won’t have to climb anything";
        btn2.GetComponentInChildren<Text>().text = "Go through the cave. A pretty known route.";

        btn0.onClick.AddListener(() => {currentState = StoryStates.State36a1;});
        btn1.onClick.AddListener(() => {currentState = StoryStates.State36b1;});
        btn2.onClick.AddListener(() => {currentState = StoryStates.State36c1;});
        
    }

// //choice deam
     void State36a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[10];
        nameHolder.text = "";
        descriptionText.text = "Algnir is climbing the steep stairs cut directly in mountain by the first men to pass over the mountain. The old injury on leg is starting to remind of its existence, but he bravely keeps moving his feet one step at a time.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36a2;
        }
        
    }

    void State36a2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[10];
        nameHolder.text = "";
        descriptionText.text = "As he approaches to the top, he is starting to hear the wind howling more and more. So that the sound of his panting is getting lost in this choir of stones being cut by wind.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36a3;
        }
        
    }

    void State36a3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[10];
        nameHolder.text = "";
        descriptionText.text = "Once Algnir steps up over another big rock, he sees a giant figure covered with fur, slowly rising at every deep breath that it takes. Now it is clear, that the noise in his ears all this time was not as much of the wind, as it was the sound of heavy breathing mountain troll, which is sleeping just near the pass to the bridge.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36a4;
        }
        
    }

    void State36a4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[39];
        nameHolder.text = "Algnir";
        descriptionText.text = "The troll is blocking the way, but I still have to move forward. Passing near him without getting unnoticed wouldn’t work - he will catch me in a breath and there will be nothing left of me, besides my boots. So better I deal with him before he deals with me.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36a5;
        }
        
    }

    void State36a5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[39];
        nameHolder.text = "";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(true);
        btn1.gameObject.SetActive(true);
        btn2.gameObject.SetActive(true);
        btn3.gameObject.SetActive(false);

        btn0.GetComponentInChildren<Text>().text = "Rush at the troll with the mace";
        btn1.GetComponentInChildren<Text>().text = "Sneak behind the troll and try to attack";
        btn2.GetComponentInChildren<Text>().text = "Take time to set a trap with flammable compound";

        btn0.onClick.AddListener(() => {currentState = StoryStates.State36a5a1;});
        btn1.onClick.AddListener(() => {currentState = StoryStates.State36a5b1;});
        btn2.onClick.AddListener(() => {currentState = StoryStates.State36a5c1;});
        
    }
//rush with the mace
    void State36a5a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        descriptionText.text = "Algnir draws his mace, brings it up high, and runs to the troll, in a furious battle cry. The troll notices the warrior, so he very inertly reaches for the nearest boulder he can find, grabs it with two hands, holds up above his head, and with a bones-shivering roar throws the boulder at Algnir. It seems to be a bad luck, as he was ready to fall in a battle for his brother, but didn’t he expect to get slain by a giant troll.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
            currentState = StoryStates.GameOver;
     }
        
    }

        void State36a5b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[39];
        nameHolder.text = "";
        descriptionText.text = "Algnir starts walking sideways, carefully watching the troll’s eyes, whether he can spot him or not. Hiding behind the bushes, and boulders that are all around the place, he manages to get to the back of the troll and strike him, disorienting the troll.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36a5b2;
        }
        
    }
//end of sneak behind
    void State36a5b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[39];
        nameHolder.text = "";
        troll_alive = false;
        injured = true;
        descriptionText.text = "Before the gnome manages to charge the third strike, the troll charges his left arm, so that it hits Algnir, throwing him away for a few meters. Laying down on the ground, Algnir sees the troll approaching him, so realizing that there are not many chances of survival, he ignites one of his brews and throws it at the troll. The beast is defeated, but at what cost: the body still hurts after a hard fall, and the fire got a bit of the dwarf too.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36ab1;
        }
        
    }

    void State36a5c1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[10];
        nameHolder.text = "";
        descriptionText.text = "Algnir gets out his small brewing toolkit and starts preparing a flammable compound. The process is cumbersome, as at every step, he is risking revealing himself with a small bang sound of explosion.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36a5c2;
        }
        
    }

    void State36a5c2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[10];
        nameHolder.text = "Algnir";
        descriptionText.text = "Should be good now. Just need to give it some time to chill.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36a5c3;
        }

    }

    void State36a5c3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        if(!nights_increased) {
          nights += 1;
          nights_increased = true;
        }
        descriptionText.text = "";
        textAllPage.text="As Algnir is waiting, a night passes before the compound is ready for use.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
           nights_increased = false;
           currentState = StoryStates.State36a5c4;
        }

    }

    void State36a5c4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[40];
        nameHolder.text = "";
        textAllPage.text="";
        descriptionText.text = "At the dawn, he sneaks out to the tight trail between two rocks, and sets his compound there, as a trap for the troll. Once he assures that everything is set well, he shouts once very loud, from the top of his lungs, so that troll comes running to him. The next thing he hears, hidden behind a rock, is a loud bang, followed by heavy, earth-shaking “boom”.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36a5c5;
        }

    }

    void State36a5c5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[40];
        nameHolder.text = "Algnir";
        troll_alive = false;
        descriptionText.text = "Good. Now the troll will not be a danger anymore.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
            currentState = StoryStates.State36ab;
         }
    }

      void State36ab() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        if(!nights_increased) {
          nights_increased = true;
          nights += 1;
        }
        textAllPage.text="He goes to sleep, as the fight with the troll was so tiring. He hadn’t had a proper fight since so long";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
            nights_increased = false;
            textAllPage.text="";
            currentState = StoryStates.State36ab1;
         }

    }

         void State36ab1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[17];
        nameHolder.text = "";
        descriptionText.text = "As algnir comes down from the mountain, he sees a large patch of pines, with some of them leaned to form an arch. He figures out that this should be the correct way to get to the frontline near the Davenvalle.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Space)) {
            currentState = StoryStates.State37;
         }

    }


     

        void State36b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[17];
        nameHolder.text = "";
        descriptionText.text = "Algnir takes the trail that seems to lead a little bit away from the mountain, but for sure, will get him to the other side. As he walks by the giant static mountain, it starts feeling like this walk is taking him ages. Looking backwards he sees that the road covered is very long, but looking back to the mountain, it seems like the scenery hasn’t changed a bit.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b2 ;
         }
        }

          void State36b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[41];
        nameHolder.text = "";
        descriptionText.text = "Looking at the mountain once again, Algnir sees that the clear blue summer sky is starting to fade into a gradient between sun-lit orange and midnight blue, and the sun is inching towards the mountain peak. It is soon time to have a good rest and continue the road the day after. He sets up a camp, and falls asleep under the stars, soothed by the easy breeze of the mountain.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b3;
         }



    }

      void State36b3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[17];
        nameHolder.text = "";
        descriptionText.text = "Early in the morning, Algnir unwraps one of the loaves of bread and recharges his forces for a new long day full of adventures and hits the road.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b4;
         }

    }

      void State36b4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[42];
        nameHolder.text = "";
        descriptionText.text = "At midday, the mountain’s scenery begins to change, as it has more steep regions. As he takes another look to the mountain, he notices a figure going down from the hilltop, toward the trail he is walking.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b5;
         }

    }

        void State36b5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[19];
        nameHolder.text = "";
        descriptionText.text = "As Algnir is moving forwards, he realizes that the figure has seen him too, as it started moving to meet him at the trail. The figure is not alone. In fact, it is assisted by a bunch of smaller figures, which made Algnir conclude that it is nothing but a shepherd with his herd.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b6;
         }

    }

    void State36b6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[19];
        nameHolder.text = "";
        descriptionText.text = "(the shepherd is lightly dressed, without any fight protection, doesn’t seem to have any weapons either).";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b7;
         }

    }

    void State36b7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[21];
        nameHolder.text = "Shepherd";
        descriptionText.text = "Greetings, good traveller. Do you need any help? Did you get lost?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b8;
         }

    }

    
    void State36b8() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[21];
        nameHolder.text = "Shepherd";
        descriptionText.text = " Well, if you follow the trail, you will get to the forest behind the mountain. Not so many brave men choose such a path, and if they do, they surely go through the mountain cave, because it is a day faster, or so.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b9;
         }

    }

      void State36b9() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[22];
        nameHolder.text = "Algnir";
        descriptionText.text = "But isn’t the cave more dangerous?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b10;
         }

    }

         void State36b10() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[21];
        nameHolder.text = "Shepherd";
        descriptionText.text = "Not at all. The suglians have put their soldiers to take care of their caravans. Well, this road ain’t dangerous too.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b11;
         }

    }

      void State36b11() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[22];
        nameHolder.text = "Algnir";
        descriptionText.text = "Well how do you know that? Because here I am, dressed in my leather chestplate, and with my mace right at my hand’s reach.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b12;
         }

    }

     void State36b12() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[21];
        nameHolder.text = "Shepherd";
        descriptionText.text = "But that doesn’t make you a bad person, does it? After all, there are no bad people, there are only ones to whom unhappy things have happened.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b13;
         }

    }

    
     void State36b13() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[22];
        nameHolder.text = "Algnir";
        descriptionText.text = "A very clever way of thinking. What is you name?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b14;
         }

    }

    
     void State36b14() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[22];
        nameHolder.text = "Algnir";
        descriptionText.text = "A very clever way of thinking. What is you name?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b15;
         }

    }

        void State36b15() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[21];
        nameHolder.text = "Shepherd";
        descriptionText.text = "It’s Christoph.";
        christofor = true;
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b16;
         }

    }

        void State36b16() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[22];
        nameHolder.text = "Algnir";
        descriptionText.text = "Thank you, Christoph. Now can you help me? I am headed to the frontline near Davenvalle. Am I taking the right road?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b17;
         }

    }

        void State36b17() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[21];
        nameHolder.text = "Cristoph";
        descriptionText.text = "Well as I said, this road will lead you behind the mountain, which is not the fastest, but quite a good road, if you want to get to Davenvalle. After this, you will get to a forest. This will clearly be the fastest route - there is an old trail. If you follow it, you will get to your destination in no time. I am headed the same direction, by the way. We could walk that way together. But we will split up near the forest. I will have to go to Resigdale.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b18;
         }

    }

          void State36b18() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[22];
        nameHolder.text = "Algnir";
        descriptionText.text = " A company of a wise man would be the best one I could wish for!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b19;
         }

    }

       void State36b19() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[43];
        nameHolder.text = "";
        descriptionText.text = "Algnir and Cristoph are headed further their route together. They discuss various topics, from the fate of the stars, to the falls of the kings, and so they find out that a stranger on the road, might really be a good friend.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b20;
         }

    }

      void State36b20() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[41];
        nameHolder.text = "";
        if (!nights_increased) {
          nights += 1;
          nights_increased = true;
        }
        descriptionText.text = "Another evening is coming, covering the whole sky in a flaming red color. This time, the camp for the night is much brighter: was it the new friendship that lit it up so bright? So Algnir is falling asleep to the soothing sounds of Christoph’s flute. It reminds him of his sweet childhood.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           nights_increased = false;
           currentState = StoryStates.State36b21;
         }

    }

      void State36b21() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[41];
        nameHolder.text = "";
        descriptionText.text = "The next morning, Algnir shares one of his loaves of bread with Christoph, after he tries Christoph’s best cheese he has.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b22;
         }

    }

      void State36b22() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[41];
        nameHolder.text = "";
        descriptionText.text = "They pack everything in their bags and go on trail, to the back of the mountain.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b23;
         }

    }

      void State36b23() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[44];
        nameHolder.text = "";
        descriptionText.text = "Just after midday, the wanderers start seeing the tips of the pines behind a hill. Once they get to the top of it, it seems like the trail is split in multiple parts";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b24;
         }

    }

      void State36b24() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[70];
        nameHolder.text = "Cristoph";
        descriptionText.text = "So this is the moment we split. You will have to enter the forest through that arch formed by leaned pines. From there on, you want to strictly follow that trail. You will get to Davenvalle in a day or so. I will be there in two days, I think. So make sure to meet me there, if you have a long stay - will provide you with my best cheese to have something to eat on road. There is no finer journey than the one meant to save one’s brother.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36b25;
         }

    }

        void State36b25() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[71];
        nameHolder.text = "";
        textAllPage.text="Christoph goes on his trail, leaving no choice for Algnir, but to approach the arch of leaned pines.";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           textAllPage.text="";
           currentState = StoryStates.State37;
         }

    }

         void State36c1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[27];
        nameHolder.text = "";
        descriptionText.text = "Algnir enters the cave. He would have thought that he should light up a torch, because the outside light doesn’t help too much in illuminating a cave, but it seems that this work has already been done before him: the cave is somehow illuminated with some kind of pots filled";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c2;
         }

    }
    
      void State36c2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[45];
        nameHolder.text = "";
        descriptionText.text = "with charcoal. There are a few dark spots, but Algnir is thankful with what he has: it does not happen quite often to see an illuminated cave.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c3;
         }

    }

     void State36c3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[46];
        nameHolder.text = "";
        descriptionText.text = "As he follows the trail, the echoing of his footsteps start to strangely multiply. But as the sounds gets louder, it becomes clear that the echo comes not from the footsteps of Algnir at all. ";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c4;
         }

    }

      void State36c4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[46];
        nameHolder.text = "";
        descriptionText.text = "Looking back, he sees the source of the sounds: A carriage pulled by two horses is approaching Algnir from behind.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c5;
         }

    }

          void State36c5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[46];
        nameHolder.text = "";
        descriptionText.text = "He thinks that he could stop the carriage and ask the coachman for a spare seat in the carriage, so he could get out of the mountain faster. So he starts walking in the direction of the carriage.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c6;
         }

    }

        void State36c6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[31];
        nameHolder.text = "Algnir";
        descriptionText.text = "Halt!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c7;
         }

    }

    
        void State36c7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[47];
        nameHolder.text = "";
        descriptionText.text = "Algnir approaches the carriage, and as he gets closer to it, he hears the shaky breathing of the coachman";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c8;
         }

    }

        void State36c8() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[50];
        nameHolder.text = "Coachman";
        descriptionText.text = "Please! leave me be! I can give you anything, but please make no harm to me! Me wife is waiting for me at home.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c9;
         }

    }

        void State36c9() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[49];
        nameHolder.text = "Algnir";
        descriptionText.text = "What are you talking about? I only wanted to ask you for a ride to the end of the tunnel.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c10;
         }

    }

        void State36c10() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[50];
        nameHolder.text = "Coachman";
        descriptionText.text = "Oh, thank Aldun! I have taken you for one of the deserters terrorising this merchant route. The thing is, my guard didn’t make it to the cave, so I am risking my life now to get to the other end all by myself.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c11;
         }

    }

        void State36c11() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[50];
        nameHolder.text = "Coachman";
        descriptionText.text = "You see, I would want to get out of this cave alive, and judging by your looks, you could be someone to rely on for protection. I am selling freshly forged armor for the warriors of Sonoria, so the coin is not a trouble at all. So will you answer my plea?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12;
         }

    }

        void State36c12() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[31];
        nameHolder.text = "";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(true);
        btn1.gameObject.SetActive(true);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        btn0.GetComponentInChildren<Text>().text = "I will go by myself. I have no wish to travel with a provider of sonoria";
        btn1.GetComponentInChildren<Text>().text = "Well, if your horses are swift enough to get us out of here, I guess I could help you";      

        btn0.onClick.AddListener(() => {currentState = StoryStates.State36c12a1;});
        btn1.onClick.AddListener(() => {currentState = StoryStates.State36c12b1;});


    }

    void State36c12a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[50];
        nameHolder.text = "Coachman";
        descriptionText.text = "The times are hard. One will do anything to get his coin.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12a2;
         }

    }


    void State36c12a2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[51];
        nameHolder.text = "";
        descriptionText.text = "Algnir continues with his road through the cave by himself, watching the cage appear and disappear in the corridor of lights. He went so far that he couldn't see the light of the entrance, but still, the exit is not to be seen either.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12a3;
         }

    }

        void State36c12a3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[51];
        nameHolder.text = "";
        descriptionText.text = "The walk is very tiresome: the fire has burnt a good part of the air in this cave, and only a rare breeze once in a while keeps Algnir’s spirit to get out of the cave soon.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12a4;
         }

    }

         void State36c12a4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[51];
        nameHolder.text = "";
        descriptionText.text = "He has lost track of the time of how long he has wandered";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12a5;
         }

    }

         void State36c12a5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[52];
        nameHolder.text = "";
        descriptionText.text = "As he continues walking, a new hope arises. The echoes of his footsteps get covered by the sound of the wind howling just at the exit of the cave. As he rushes more, filled with hope for a fresh breath of air, he gets to see that point of bluish light. There it is, the exit.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12a6;
         }

    }

        void State36c12a6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[52];
        nameHolder.text = "";
        descriptionText.text = "Very tired, he gets to the exit of the cave. The light coming from the sky is not blue anymore. It is starting to be filled with a shade of ruby, as it is darkening more and more. The dusk has come.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12a7;
         }

    }

        void State36c12a7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[52];
        nameHolder.text = "";
        descriptionText.text = "When he exits the cave, although exhausted, he decides not to fall to the temptation to rest just at the exit: the cave bandits might still get back, and he could be tied up in his sleep, or get all his bags stolen";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12a8;
         }

    }

        void State36c12a8() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[41];
        nameHolder.text = "";
        descriptionText.text = "He walks a little bit more, and sees a beautiful sunset over the pines behind a hill. That is where the trail leads, so he will get enough time to admire the beauty of it.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12a9;
         }

    }

        void State36c12a9() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[41];
        nameHolder.text = "";
        if (!nights_increased) {
          nights += 1;
          nights_increased = true;
        }
        descriptionText.text = "For now, he sets up a campfire, leans his bags against a near standing oak at the begining of a forest and falls asleep, amazed by the beautiful dance of flame, enjoying every breath of fresh air that he can.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           nights_increased = false;
           currentState = StoryStates.State37;
         }

    }

    void State36c12b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[50];
        nameHolder.text = "Merchant";
        descriptionText.text = "Good choice. I have traveled this cave without a carriage once and nearly lost my breath. All the fresh air here is burned by these torches. But it is the price we pay for our safety - at least to see what is ahead of you.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12b2;
         }

    }

       void State36c12b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[50];
        nameHolder.text = "";
        descriptionText.text = "The horses come to be really swift, just as the merchant has said, so it makes Algnir quite happy that he will get out of this cave as soon as possible. He did not want to help providing sonorians with armor, but this is his price to pay for a faster route to save his brother.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12b3;
         }

    }

    void State36c12b3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[52];
        nameHolder.text = "";
        descriptionText.text = "As they are riding through the cave, just when the shimmering light of the exit is starting to be seen, the sound of wooden wheels and galop of the horses is overshout by an echo";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12b4;
         }

    }

        void State36c12b4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[56];
        nameHolder.text = "voice";
        descriptionText.text = "Oi! stop!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12b5;
         }

    }

       void State36c12b5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[55];
        nameHolder.text = "[merchant](whisper)";
        descriptionText.text = "I knew it.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12b6;
         }

    }

       void State36c12b6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[55];
        nameHolder.text = "Bandit";
        descriptionText.text = "Give me your goods, and I will do no harm to you.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12b7;
         }

    }

    
       void State36c12b7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[54];
        nameHolder.text = "Algnir";
        descriptionText.text = "Wrong carriage you have chosen to rob. Leave this man be, or otherwise, you will get to know what real pain is.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12b8;
         }

    }

    
       void State36c12b8() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[55];
        nameHolder.text = "Bandit";
        descriptionText.text = "And what will you do, you midget? headbang my knee?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12b9;
         }

    }

     void State36c12b9() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[31];
        nameHolder.text = "Algnir";
        descriptionText.text = "Oh, you asked for it!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12b10;
         }

    }

         void State36c12b10() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[57];
        nameHolder.text = "";
        descriptionText.text = "The bandit seemed to be more a talker than a fighter, as Algnir managed to shut his mouth quite easily.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12b11;
         }

    }

        void State36c12b11() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[55];
        nameHolder.text = "Merchant";
        descriptionText.text = "Ah, thank Aldun, for the luck I’ve had to meet you here. I’d be robbed to the last coin and possessions at best! Now you truly deserve the coin I promised you. ";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State36c12b12;
         }

    }

        void State36c12b12() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        money = true;
        textAllPage.text="You were rewarded a bag of coins";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           textAllPage.text="";
           currentState = StoryStates.State36c12b13;
         }

    }

    
           void State36c12b13() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        money = true;
        textAllPage.text="You were rewarded a bag of coins";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           textAllPage.text="";
           currentState = StoryStates.State36c12b14;
         }

    }

          void State36c12b14() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[17];
        nameHolder.text = "";
        descriptionText.text = "At this point, Algnir sees the forest to which he has been going through this cave. The top of the pines are overlooking behind a hill, so he approaches them to see a small trail denoted by some lean pines which form an arch over it. ";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State37;
         }

    }



    



        void State37() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[71];
        nameHolder.text = "";
        descriptionText.text = "Just at the moment when Algnir enters the forest, he notices that looking afar, one can see nothing but trees - not even a hope of a lake, or town illuminations, or sky, as seen from the other side.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State38;
         }

    }

      void State38() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[71];
        nameHolder.text = "";
        descriptionText.text = "He steps on the trail and and the muffed sound of fallen needles seems to be one of the few sounds he hears in this forest, while walking. The trails is hard to see, as needles have covered it, mostly.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State39;
         }

    }

      void State39() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[71];
        nameHolder.text = "";
        descriptionText.text = "Following the slightly more pressed needles, that make the hint of the trail, he wanders to see the beauties of the forest.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State40;
         }

    }

      void State40() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[71];
        nameHolder.text = "";
        descriptionText.text = "The pines are calm, slowly shaking in the wind, the falling needles seem to cover a fallen, dried out pine log, and by the sound one could guess that there is something moving… Might be a rabbit which just ran off, scared by a stranger.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State41;
         }

    }

      void State41() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[71];
        nameHolder.text = "";
        descriptionText.text = "Still, the trail is hard to see and follow. Once Algnir decides to take a rest, he realized that the fallen pine log he is leaning aginst - he has seen it. He thinks to himself that he must have missed a split, or just walked of the trail, and got back to it out of pure luck.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State42;
         }

    }

      void State42() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[58];
        nameHolder.text = "";

        descriptionText.text = "An old log starts to move. When Algnir looks at it, he understands that it is not a simple tree, but A tall human-like figure. Veins start to grow around Algnir’s legs, tying him to the place he stays on.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State43;
         }

    }

          void State43() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[58];
        nameHolder.text = "Leshy";
        descriptionText.text = "Why are you disturbing the peace of the forest?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State44;
         }

    }

          void State44() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[58];
        nameHolder.text = "Algnir";
        descriptionText.text = " I want to get to the other side of the forest.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State45;
         }

    }

          void State45() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[58];
        nameHolder.text = "Leshy";
        descriptionText.text = "And how do I know you are not lying, and are here only to hunt my precious animals?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State46;
         }

    }

          void State46() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[58];
        nameHolder.text = "Algnir";
        descriptionText.text = " I will not hurt them. I am on my journey only to help!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State47;
         }

    }

      void State47() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[58];
        nameHolder.text = "Leshy";
        descriptionText.text = "In such a case, kind traveller, help me lift my curse. The people from the village nearby have my forest by killing animals and cutting down trees. Now there, to lift my curse, there is still one tree to cut, and I do not know which. Would you help me? I will lead your way after.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State48;
         }

    }

      void State48() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[58];
        nameHolder.text = "Algnir";
        descriptionText.text = "Sure!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State49;
         }

    }

      void State49() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[58];
        nameHolder.text = "Leshy";
        descriptionText.text = "So it goes like this:";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
        InputField input = inputField.GetComponent<InputField>();
        inputField.gameObject.SetActive(false);
        input.text = "";

           currentState = StoryStates.State50;
         }

    }

      void State50() {
        InputField input = inputField.GetComponent<InputField>();
        inputField.gameObject.SetActive(true);
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[14];
        textAllPage.text = "Trees lie before you, of number six, you see,\nFive of them destroy you, if cutten to the knee,\nOne of them is savior - will lift your curse up free.\nWhich one to lay your axe on, decide will have to thee.\nSame of kind are growing at one of either ends.\nOther side has savior among the cursed, instead.\nFour of kind are neighbors, so grow in a close herd.\nThe savior is surrounded and grows at one’s right hand.";
        nameHolder.text = "";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(true);

         btn3.GetComponentInChildren<Text>().text = "Submit";
         btn3.onClick.AddListener(() => {
           textAllPage.text = "";
          inputField.gameObject.SetActive(false);
            if (input.text == "5") {
              leshy = true;
              currentState = StoryStates.State50b1;
            } else {
              currentState = StoryStates.State50a1;
            }
          });
    }

      void State50a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[58];
        nameHolder.text = "";
        descriptionText.text = "The ancient spirit lights up with a sunlight glow, and just when the light becomes unbearable to look at, the light shuts down quickly, leaving behind itself nothing more than a mist, quickly spreading through the forest, then clearing itself.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State50a2;
         }

    }

      void State50a2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[17];
        nameHolder.text = "";
        descriptionText.text = "The trails are still tangled, so Algnir has to wander two more days around the forest to find the exit.";
        if (!nights_increased) {
          nights += 2;
          nights_increased = true;
        }
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           nights_increased = false;
           currentState = StoryStates.State51;
         }

    }

      void State50b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[59];
        nameHolder.text = "";
        descriptionText.text = "The ancient spirit shrinks down in size, all the wood rehydrates again, untill it becomes a kid-like creature, with full mouth smile.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State50b2;
         }

    }

          void State50b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[59];
        nameHolder.text = "Leshy";
        descriptionText.text = "Thank you traveller! Let me open the correct trail to you then.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State50b3;
         }

    }

      void State50b3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[59];
        nameHolder.text = "";
        descriptionText.text = "Leshy points his finger somewhere in the dark. Algnir looks there, his face becomes enlightened. Now in the place where there was a bunch of bushes, a wide and clean trail, without any leaves or needles, has appeared, and it opens a doorway to the forest’s exit.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State50b4;
         }

    }

      void State50b4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[59];
        nameHolder.text = "Algnir";
        descriptionText.text = "Thank you very much. Now i will get to my brother in no time!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State50b5;
         }

    }

      void State50b5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[60];
        nameHolder.text = "";
        descriptionText.text = "Algnir walks away, towards the city";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State51;
         }

    }

    void State51() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[61];
        nameHolder.text = "";
        descriptionText.text = "Once Algnir arrives to Davenvalle, the night is coming to its reign. The locals are eating together in families, either playing their soothink folk.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State52;
         }

    }

      void State52() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[62];
        nameHolder.text = "";
        descriptionText.text = "Once Algnir arrives to Davenvalle, the night is coming to its reign. The locals are eating together in families, either playing their soothink folk.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           if(christofor){
             currentState = StoryStates.State52a1;
           }

           else if (money){
            currentState = StoryStates.State52b1;
          }

          else {
            currentState = StoryStates.State52c1;
          }

         }

    }

        void State52a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[62];
        nameHolder.text = "";
        descriptionText.text = "He remembers that Christoph has invited him over just once he gets to the village. So he decides to ask people for him. It seems that Christoph is quite a kind man indeed, as everyone is talking highly about him, so it did not cost much time to find his house.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State52a2;
         }

    }

        void State52a2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[63];
        nameHolder.text = "";
        descriptionText.text = "Just after he knocks on the dor, the shepherd opens it hastily, with a wide smile, being happy to have new guests over.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State52a3;
         }

    }

       void State52a3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[63];
        nameHolder.text = "Christoph";
        descriptionText.text = "So you made it, Algnir!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State52a4;
         }

    }

        void State52a4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[63];
        nameHolder.text = "Algnir";
        descriptionText.text = "I did, but you wouldn’t believe through what I have been.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State52a5;
         }

    }

    void State52a5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        if (!nights_increased) {
            nights += 1;
            nights_increased = true;
        } 
textAllPage.text="After Algnir finishes his story about his journey in the forest, with a pint of local ale, they both go to sleep.";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State53;
           nights_increased = false;
           textAllPage.text="";
         }

    }

   void State52b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[62];
        nameHolder.text = "";
        descriptionText.text = "Algnir goes searching for an inn: he is completely tired after such a long day of wandering around.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State52b2;
         }
    }

     void State52b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[62];
        nameHolder.text = "";
        if (!nights_increased) {
            nights += 1;
            nights_increased = true;
        } 
        descriptionText.text = "After asking people around, he finds an inn named “Salamander”. It is not quite as good as the one from the homeland, but for an overnight stay. He buys some food for his further quest, goes to his rent room, and just falls right onto bed, falling asleep immediately.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State53;
           nights_increased = false;
         }
    }

        void State52c1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[62];
        nameHolder.text = "";
        descriptionText.text = "Algnir goes searching for an inn in: he is completely tired after such a long day of wandering around. But once he asks about a room, he realizes that he does not have the coin for that.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State52c2;
         }
    }

     void State52c2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[62];
        nameHolder.text = "";
        descriptionText.text = "He starts thinking that these days, some innkeepers have gone mad with their prices. He himself does not charge this much. Maybe he should.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State52c3;
         }
    }

    void State52c3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        if (!nights_increased) {
            nights += 1;
            nights_increased = true;
        } 
        textAllPage.text="He decides that he will once again use his bags as an improvized pillow, and fall asleep under a near standing tree, being warmed by a campfire.";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State53;
           nights_increased = false;
           textAllPage.text="";
         }
    }

     void State53() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
         textAllPage.text="He decides that he will once again use his bags as an improvized pillow, and fall asleep under a near standing tree, being warmed by a campfire.";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           if (nights <= 4) {
             textAllPage.text="";
            currentState = StoryStates.State53a1;
           }
           else  {
             textAllPage.text="";
            currentState = StoryStates.State53b1;
           }
         }
    }

        void State53a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[64];
        nameHolder.text = "";
        descriptionText.text = "On the next morning, as Algnir wakes up, after he asks the people around how to get to the frontline, he is headed to find his brother. As he approaches  the final place, he starts hearing more and more distinct voices shouting, sounds of swords hitting each other and various thunder-likes strikes.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State53a2;
         }
    }

            void State53a2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[65];
        nameHolder.text = "";
        descriptionText.text = "A man in Drakeland armors runs just the opposite direction.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State53a3;
         }
    }

            void State53a3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[65];
        nameHolder.text = "The warrior";
        descriptionText.text = "Run for your life. We have been surrounded it was all a an ambush!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State53a4;
         }
    }

            void State53a4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[65];
        nameHolder.text = "";
        descriptionText.text = "The whole world turned and his heart felt like skipping a beat: Did Groham survive?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State53a5;
         }
    }

      void State53a5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[65];
        nameHolder.text = "";
        descriptionText.text = "Desperately, he starts running to the place frontline. Getting closer, he hears a very well known roar. One that he has been hearing for years at his side, at each battle he has been in. This is definitely Groham!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State54;
         }
    }

      void State53b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[65];
        nameHolder.text = "";
        descriptionText.text = "Algnir is woken up from his sleep by screams in the village. As he gets to the epicenter of it, he finds out that the sonorians have pushed the frontline till the heart of the Davenvalle. The whole world turned and his heart felt like skipping a beat: It means that the sonorians have succeeded in their ambush planning.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State53b2;
         }
    }

      void State53b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[65];
        nameHolder.text = "";
        descriptionText.text = "Desperately, he starts running to the place that should have been the frontline, fighting off the attacking sonorians. Then he hears a very well known roar. One that he has been hearing for years at his side, at each battle he has been in. This is definitely Groham!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State54;
         }
    }

      void State54() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[65];
        nameHolder.text = "";
        descriptionText.text = "As he runs to him, he finds him fighting three sonorians at a time. Algnur runs to give a helping hand.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State55;
         }
    }

          void State55() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[66];
        nameHolder.text = "Algnir";
        descriptionText.text = "Groham! Brother! I thought that I would not see you again.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State56;
         }
    }

              void State56() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[66];
        nameHolder.text = "Groham";
        descriptionText.text = "Algnir, you fool! WHAT are you doing here? You are NOT supposed to fight anymore. How did you even get here, with your leg? I should have tied you up to the tavern!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State57;
         }
    }
//sar
              void State57() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[66];
        nameHolder.text = "Algnir";
        descriptionText.text = "I learned that you are going to be in trouble, so I couldnt let you die so egoistically, without me!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State60;
         }
    }

                  void State58() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[7];
        nameHolder.text = "";
        descriptionText.text = "They fight off the solarians and manage to run closer to the forest. Catching their breath, they discuss panting";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State59;
         }
    }

      void State59() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[7];
        nameHolder.text = "Algnir";
        descriptionText.text = "You say what you want, but what kind of brother would I have been if I let you die just like that?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State60;
         }
    }

      void State60() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[66];
        nameHolder.text = "Groham";
        descriptionText.text = "Enough of that. We have no time. If you want to be a hero so much - here is your chance. The Sonorians are headed to the Lakeshore, so better save everyone that is dear to you there.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State61;
         }
    }

    void State61() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[66];
        nameHolder.text = "Algnir";
        descriptionText.text = "In such a case, we had our rest! Let’s move on! I am done living my life as a simple man. I want them to chant legends about us!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State62;
         }
    }

        void State62() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[66];
        nameHolder.text = "Groham";
        descriptionText.text = "So we will have to find a way to fight them back";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63;
         }
    }

    void State63() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[66];
        nameHolder.text = "Algnir";
        descriptionText.text = "Then I have a plan";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           if (leshy) {
                        currentState = StoryStates.State63a1;
           } else {
                        currentState = StoryStates.State63b1;

           }
         }
    }

        void State63a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "";
        descriptionText.text = "The brothers run towards the fine trail at the forest, that Leshy has created. As they run, Algnir is telling his brother";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63a2;
         }
        }

        void State63a2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "Algnir";
        descriptionText.text = "Go here. I helped the forest’s spirit, so now we will have a fast way through. He created this trail for us.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63a3;
         }
    }
  
      void State63a3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "";
        descriptionText.text = "Groham is amazed of his little brother. He did not think that Algnir could be able to handle such a mission on his own. Not after the last battle they had together.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63a4;
         }
    }

     void State63a4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "";
        descriptionText.text = "As they are running through the forest, they hear how the branches move back to cover the trail after them. The sonorians have no chance to get a fast way to the mountain.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63a5;
         }
    }

         void State63a5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "";
        descriptionText.text = "Running a few more meters, they see bears and elks running against their direction.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63a6;
         }
    }

             void State63a6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "Algnir";
        descriptionText.text = "Hah. I think it is the work of Leshy. He is helping us!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63a7;
         }
    }

             void State63a7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "Groham";
        descriptionText.text = "But how did you...";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63a8;
         }
    }

             void State63a8() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "Algnir";
        descriptionText.text = "No time! We still have to go defend Lakeshore.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63a9;
         }
    }

             void State63a9() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "";
        descriptionText.text = "They get out of the forest in the evening, and for sure they are now far ahead the sonorians";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State64;
         }
    }

     void State63b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "";
        descriptionText.text = "The brothers run towards the forest, and it looks like groham is slowing down.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63b2;
         }
    }

    void State63b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "Groham";
        descriptionText.text = "So that is your plan? a forest without trails?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63b3;
         }
    }

    void State63b3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "Algnir";
        descriptionText.text = " I have walked the hell of this forest for you. I know most of its trails now. Just trust me.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63b4;
         }
    }

    void State63b4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "";
        descriptionText.text = "Groham is surprised by the things his younger brother did for him. In fact, he seems to not have lost his temper and bravery of the warrior he was.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63b5;
         }
    }

      void State63b5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "Groham";
        descriptionText.text = "Alright. We will go together, brother.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63b6;
         }
    }

    void State63b6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "";
        descriptionText.text = "They run through the tangled routes of the forest, pushing the limits each time they hear the sonorians approach them.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State63b7;
         }
    }

      void State63b7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[67];
        nameHolder.text = "";
        descriptionText.text = "They manage to get out of the forest just at the next morning. Tired as hell, they decided to sleep just a little bit, one at a time, the other, delegated to watch if the solorians approach them.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State64;
         }
    }



        void State64() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        descriptionText.text = "As the brothers approach to mountain, they have to decide which way they choose to go";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65;
         }
    }

    void State65() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(true);
        btn1.gameObject.SetActive(true);
        btn2.gameObject.SetActive(true);
        btn3.gameObject.SetActive(false);

        btn0.GetComponentInChildren<Text>().text = "Go around";
        btn0.onClick.AddListener(() => {currentState = StoryStates.State65a1;});
        btn1.GetComponentInChildren<Text>().text = "Go through";
        btn1.onClick.AddListener(() => {currentState = StoryStates.State65b1;});
        btn2.GetComponentInChildren<Text>().text = "Go over";
        btn2.onClick.AddListener(() => {currentState = StoryStates.State65c1;});
    }

     void State65a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        descriptionText.text = "They take safest path which they have. As they go, they see that the road is long, that it seems like they still stay on the same side of the mountain, and never got around it an inch.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65a2;
         }
    }

    void State65a2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        descriptionText.text = "Groham looks back. Algnir recognizes the movement with the side of his eye, so instinctively, he looks back too. The sonorian cavalry is approaching. Now there is no chance the brothers could get to the village faster than them.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65a3;
         }
    }

    void State65a3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        descriptionText.text = "Soon enough they discover themselves surrounded by tall men on horses.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65a4;
         }
    }

    void State65a4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Sonorian";
        descriptionText.text = "Well these ones survived quite well. Could be good warriors later. Tie them up.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65a5;
         }
    }

    void State65a5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        descriptionText.text = "No matter how hard they try, they cannot handle such a big amount of soldiers. They end up put at the end of the horses’ backs.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65a6;
         }
    }

    void State65a6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        descriptionText.text = "It hurt seeing the village that was like a home to Algnir become just ash and coal…";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65a7;
         }
    }

    void State65a7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Algnir";
        descriptionText.text = " I’m sorry brother. I guess my sense of honour has blinded me this time. I wanted to die in a fine battle, like a hero. Now we will die like traitors instead.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65a8;
         }
    }

    void State65a8() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Groham";
        descriptionText.text = "At least, we will stil go to the end. Together.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65a9;
         }
    }

     void State65a9() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        textAllPage.text = "You and your brother died.";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.MainMenu;
           textAllPage.text = "";
         }
    }

    void State65b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "The cave should be the fastest way. I know for sure now.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65b2;
         }
    }

     void State65b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Groham";
        textAllPage.text = "";
        descriptionText.text = "Well it is decided then!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65b3;
         }
    }

     void State65b3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "They enter the cave in a hurry.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65b4;
         }
    }

     void State65b4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "Wait. I have got an idea.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65b5;
         }
    }

     void State65b5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Algnir hastily starts searching in his bag. He finds his small box with combustion powder, mixes it with the Rayilean crystals and puts the box at the entrance. He takes then one of the torches on the wall, goes to his brother, and from there, throws the torch to light up the box";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65b6;
         }
    }

     void State65b6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Right at this moment the cave fills with the powerful echo of an explosion, leaving a small hint hissing noise in the ears.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65b7;
         }
    }

     void State65b7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Algnir looks at the entrance to assure that the plan had worked";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65b8;
         }
    }

     void State65b8() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "The path is now blocked. The sonorians will have to take a longer route.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65b9;
         }
    }

     void State65b9() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "The dwards can now be sure that the army will still not get to them, so they should have plenty of time to get back to the village.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65b10;
         }
    }

     void State65b10() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Just when the brothers start to feel dizzy beacuse of the closed air of the cave, they see the daylight, shining afar. There is not much left to go";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65b11;
         }
    }

     void State65b11() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "So here they are, at the other end of the mountain.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State66;
         }
    }

    void State65c1() {
        

         if (!troll_alive) {
           currentState = StoryStates.State65c1a1;
         }
         else {
           currentState = StoryStates.State65c1b1;
         }
    }

 void State65c1a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "We can go over the mountain. It is safe there, for sure. There was a troll, I had to get rid of it with a bit of combustion powder. Seemed like the mountains are quite responsive to powerful echoes. If we use enough of this powder, we can start an avalanche over them.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1a2;
         }
    }

    void State65c1a2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Groham";
        textAllPage.text = "";
        descriptionText.text = "That means that…";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1a3;
         }
    }

      void State65c1a3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "Right. The village will be safe out of battles, for now.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1a4;
         }
    }

    void State65c1a4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Brother… I was wrong. We were ALL wrong. We needed you at war. You have proven yourself to be the man none of us were";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1a5;
         }
    }

      void State65c1a5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "The brothers go up the mountain. The scenery opens a view worthy of a true win. Algnir takes all his combustion powder, puts it under a fairly chosen rock, traces a long wick, so to make sure he and his brother are at a safe distance and lights it up.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1a6;
         }
    }

      void State65c1a6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "With every second, every meter the wick is burning, the tension in their hearts were rising. What if there is not enough powder to make it work? what if the explosion would unexpectedly hit them instead? What if…";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1a7;
         }
    }

      void State65c1a7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "This train of thought was interrupted by an earthshaking explosion. The brothers look at each other. They run very fast to the other edge to check the avalanche has indeed started.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1a8;
         }
    }

      void State65c1a8() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "It is a win. They have won this battle: two brothers against a whole army.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1a9;
         }
    }

      void State65c1a9() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Now Algnir has proven to himself and to his brother, that he is still worthy to fight a battle.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1a10;
         }
    }

      void State65c1a10() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Once they get back to the village, Algnir feels out of this place. He cannot stay in his tavern all day long, while others fight at the war. Now it is decided. This time, he will fight along with his brother, no matter what.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1a11;
         }
    }

    void State65c1a11() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        textAllPage.text = "You saved your brother and the village.";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.MainMenu;
         }
    }

     void State65c1b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "Let’s go over the mountains. It should be fast enough. There is no way the sonorians on their horses will be quicker than us, on such a steep slide.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b2;
         }
    }

     void State65c1b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Once the brothers step up over another big rock, they see a giant figure covered with fur, slowly rising at every deep breath that it takes. Now it is clear, that the noise in his ears all this time was not as much of the wind, as it was the sound of heavy breathing mountain troll, which is sleeping just near the pass to the bridge.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b3;
         }
    }

     void State65c1b3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "The troll is blocking the way, but we can’t go back. Passing near him without getting unnoticed wouldn’t work - he will catch us in a breath and there will be nothing left of us. So better we deal with him before he deals with us.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4;
         }
    }


        void State65c1b4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(true);
        btn1.gameObject.SetActive(true);
        btn2.gameObject.SetActive(true);
        btn3.gameObject.SetActive(false);

        btn0.GetComponentInChildren<Text>().text = "Rush at the troll with the maces.";
        btn0.onClick.AddListener(() => {currentState = StoryStates.State65c1b4a1;});
        btn1.GetComponentInChildren<Text>().text = "Sneak behind the troll and try to attack";
        btn1.onClick.AddListener(() => {currentState = StoryStates.State65c1b4b1;});
        btn2.GetComponentInChildren<Text>().text = "Take time to set a trap with flammable compound";
        btn2.onClick.AddListener(() => {currentState = StoryStates.State65c1b4c1;});
    }

    

    void State65c1b4a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Algnir draws his mace, brings it up high, and runs to the troll, while Groham, quite surpriesed, follows his lead. The troll notices the two warriors, so he very inertly reaches for the nearest boulder he can find, grabs it with two hands, holds up above his head, and with a bones-shivering roar throws the boulder at Algnir, and another at Groham";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4a2;
         }
    }

     void State65c1b4a2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "It seems to be a bad luck, as he was ready to fall in a battle with his brother, but didn’t it to happen it so soon.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4a3;
         }
    }

     void State65c1b4a3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        textAllPage.text = "You and your brother died";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.MainMenu;
         }
    }

    void State65c1b4b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Algnir starts walking sideways, carefully watching the troll’s eyes, whether he can spot him or not. Hiding behind the bushes, and boulders that are all around the place, he manages to get to the back of the troll and strike him, disorienting the troll. Groham gets to strike the second hit.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4b2;
         }
    }

    void State65c1b4b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Before the gnome manages to charge the third strike, the troll charges his left arm, so that it hits Algnir, throwing him away for a few meters. Groham is too far to distract the troll, so laying down on the ground, Algnir sees the troll approaching him.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4b3;
         }
    }

    void State65c1b4b3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "He then ignites one of his brews and throws it at the troll. The beast is defeated, but at what cost: the body still hurts after a hard fall, and the fire got a bit of the dwarf too.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4b4;
         }
    }

    void State65c1b4b4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "Groham";
        textAllPage.text = "";
        descriptionText.text = "Are you alright?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4b5;
         }
    }

    void State65c1b4b5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "I am good. now let’s go to the village. We have not that much time.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State66;
         }
    }

    void State65c1b4c1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "These beasts.. They don’t quite like fire. I guess this will be the best way to fight them.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4c2;
         }
    }

    void State65c1b4c2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "Groham";
        textAllPage.text = "";
        descriptionText.text = "As you say, brother. Do you still remember how to make those flaming bombs?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4c3;
         }
    }

    void State65c1b4c3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "I surely do.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4c4;
         }
    }

    void State65c1b4c4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Algnir gets out his small brewing toolkit and starts preparing a flammable compound. The process is cumbersome, as at every step, he is risking revealing himself with a small bang sound of explosion";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4c5;
         }
    }

    void State65c1b4c5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[23];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "Should be good now.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4c6;
         }
    }

    void State65c1b4c6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[24];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Algnir he sneaks out to the tight trail between two rocks, and sets his compound there, as a trap for the troll. Once he assures that everything is set well, he shouts once very loud, from the top of his lungs, so that troll comes running to him. The next thing he hears, hidden behind a rock, is a loud bang, followed by heavy, earth-shaking “boom”";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State65c1b4c7;
         }
    }

    void State65c1b4c7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "Alright, now we are safe to go";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State66;
         }
    }


    void State66() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "As the brothers are descending the mountains, Algnir starts to look a little bit out of the mood";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State67;
         }
    }

    void State67() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = " What kind of a brother you are?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State68;
         }
    }

    void State68() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[68];
        nameHolder.text = "Groham";
        textAllPage.text = "";
        descriptionText.text = "What do you mean?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State69;
         }
    }

    void State69() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "You went to the war, left me in this Aldun’s forsaken land, where my chemistry skills are valued for nothing more than just fine brewery.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State70;
         }
    }

    void State70() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "Groham";
        textAllPage.text = "";
        descriptionText.text = "I wanted safety for you.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State71;
         }
    }

    void State71() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = " I don’t want safety. I want to live a life like a man, and have a death a real man deserves";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State72;
         }
    }

    void State72() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "Groham";
        textAllPage.text = "";
        descriptionText.text = "Well, what would I do? Take a man with his bad leg to suffer war? By the way, how doesn’t your leg hurt you?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State73;
         }
    }

    void State73() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "That is the thing. It always does. And the calm life makes it worse. You see, when calm, the pain is the only thing you feel, and it hurts like hell. But when your head is always distracted, you have no time to notice it. So I would rather die in a fight, than live a calm life of pain.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State74;
         }
    }

    void State74() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "They get to the village. This is the time, the time to prepare for the final battle.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State75;
         }
    }

    void State75() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "Groham";
        textAllPage.text = "";
        descriptionText.text = "So what is your plan now?";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76;
         }
    }

     void State76() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(true);
        btn1.gameObject.SetActive(true);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

        btn0.GetComponentInChildren<Text>().text = "Call to arms";
        btn0.onClick.AddListener(() => {currentState = StoryStates.State76a1;});
        btn1.GetComponentInChildren<Text>().text = "Sarcrifice the Tavern";
        btn1.onClick.AddListener(() => {currentState = StoryStates.State76b1;});

    }

        void State76a1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Algnir and Groham go to every house they can reach and call for every man there is. They get a pack of villagers, dressed up as heavy as they can, and armed as hard as they can. Among the fully armored warriors, there are loosely protected novices, with parts of their clothes made of hardened leather.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76a2;
         }
    }

    void State76a2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "All the men of the village have gotten out, with swords, maces, bows and arrows and even pitchforks - There is no one unwanted on this fight.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76a3;
         }
    }

    void State76a3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "All they stand tall and proud to defend their village, and the honour of Drakeland. Once the sonorians break through, it becomes clear that there are not so many chances for a good outcome. They are clearly outnumbered. Sonorians surround the village, and as the end has become clear, these are the last words the Algnir said to his brother";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76a4;
         }
    }

    void State76a4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "At last, the end of my pain. It has been an honour, brother.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76a5;
         }
    }

    void State76a5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "Groham";
        textAllPage.text = "";
        descriptionText.text = "It has been an honour.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76a6;
         }
    }

      void State76a6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        textAllPage.text = "You and you brother died honorably";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.MainMenu;
         }
    }

    void State76b1() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Algnir takes his time to prepare an ambush himself this time, if that is how the sonorians like to deal with things.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76b2;
         }
    }

    void State76b2() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "He goes to his tavern and takes all the flammable he has stored till now, and a good dose of combustion powder that he has left back in his chest.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76b3;
         }
    }

    void State76b3() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "With the help of his brother, they put the combustion powder in small patches just at the entrance of the village.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76b4;
         }
    }

    void State76b4() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Algnir puts his ear to the ground.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76b5;
         }
    }

    void State76b5() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "Do you hear it? the galloping… They are coming";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76b6;
         }
    }

    void State76b6() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "Algnir";
        textAllPage.text = "";
        descriptionText.text = "All to the safe positions, they are coming!";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76b7;
         }
    }

    void State76b7() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "As he said that, all the people of the village packed up as far as they could from the entrance from the mountain side.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76b8;
         }
    }

    void State76b8() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[69];
        nameHolder.text = "";
        textAllPage.text = "";
        descriptionText.text = "Algnir hears them coming, so he lights up the rope. The fire is getting all the way down, over the entrance and far to the base of the mountain, where all the possesions of Algnir are packed. Once the fire gets it, A giant explosion happesn, which starts an avalanche, to cover the entire army.";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.State76b9;
         }
    }

    void State76b9() {
        imageHolder.GetComponent<SpriteRenderer>().sprite = allSprrites[12];
        nameHolder.text = "";
        textAllPage.text = "From then on, Algnir and Groham are considered the heroes of the village, but have never been seen there since, as they are gone now, to seek for other adventures.";
        descriptionText.text = "";
        Button btn0 = button0.GetComponent<Button>();
        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        
        btn0.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
        btn3.gameObject.SetActive(false);

         if (Input.GetKeyDown(KeyCode.Space)) {
           currentState = StoryStates.MainMenu;
         }
    }

}


