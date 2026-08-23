using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;

public class Assignment : MonoBehaviour
{
    private int stage;
    private string stageName;
    private InputAction nextStageAction;
    private InputAction backStageAction;
    private InputAction startStageAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stage = 0;
        StageName();
        Debug.Log($"Stage : {stage} , {stageName}");
        Debug.Log("Press N To Go Next Stage And Press B To Go To Previous Stage");
        Debug.Log("Press Spacbar to start.");

        nextStageAction = InputSystem.actions.FindAction("NextStage");
        backStageAction = InputSystem.actions.FindAction("BackStage");
        startStageAction = InputSystem.actions.FindAction("StartStage");

        // As01_CheckNumberSign();
        // As02_GetDayName();
        // As03_ValidatePassword();
        // As04_GetGrade();
        // As05_IsLeapYear();
        // As06_Calculate();
        // As07_GetSeason();
        // As08_PurchasingSystemExample();
        // As09_RockPaperScissorsExample();
        // As10_CalculateWeaponDamage();
        // As11_DeterminePlayerRank();
    }
    void Update()
    {
        //Go Bcak to previous Stage.
        if (backStageAction.WasReleasedThisFrame() && stage > 0)
        {
            stage--;
            stage = stage % 12;
            StageName();
            Debug.Log($"Stage : {stage} , {stageName}");
            Debug.Log("Press N To Go Next Stage And Press B To Go To Previous Stage");
            Debug.Log("Press Spacbar to start.");
        }

        //Go to Next Stage.
        if (nextStageAction.WasReleasedThisFrame())
        {
            stage++;
            stage = stage % 12;
            StageName();
            Debug.Log($"Stage : {stage} , {stageName}");
            Debug.Log("Press N To Go Next Stage And Press B To Go To Previous Stage");
            Debug.Log("Press Spacbar to start.");
        }

        //Start the stage.
        if (startStageAction.WasReleasedThisFrame())
        {
            switch (stage)
            {
                case 0:
                    As01_CheckNumberSign();
                    break;
                case 1:
                    As02_GetDayName();
                    break;
                case 2:
                    As03_ValidatePassword();
                    break;
                case 3:
                    As04_GetGrade();
                    break;
                case 4:
                    As05_IsLeapYear();
                    break;
                case 5:
                    As06_Calculate();
                    if (isOp)
                    {
                        Debug.Log($"{as06Num1} {as06Op} {as06Num2} = {result}");
                    }
                    else
                    {
                        Debug.Log("Invalid Operator. Please change the operator to +, -, * or /");
                    }
                    break;
                case 6:
                    As07_GetSeason();
                    break;
                case 7:
                    As08_PurchasingSystemExample();
                    break;
                case 8:
                    As09_RockPaperScissorsExample();
                    break;
                case 9:
                    As10_CalculateWeaponDamage();
                    break;
                case 10:
                    As11_DeterminePlayerRank();
                    break;
                case 11:
                    Debug.Log("GET BACK NOW!!! \n We have only 0 - 10 states");
                    break;
            }
        }
    }

    void StageName()
    {
        switch (stage)
        {
            case 0:
                stageName = "Check Number Sign";
                break;
            case 1:
                stageName = "Get Day Name";
                break;
            case 2:
                stageName = "Validate Password";
                break;
            case 3:
                stageName = "Get Grade";
                break;
            case 4:
                stageName = "Is Leap Year";
                break;
            case 5:
                stageName = "Calculate";
                break;
            case 6:
                stageName = "Get Season";
                break;
            case 7:
                stageName = "Purchasing System";
                break;
            case 8:
                stageName = "Rock Paper Scissors";
                break;
            case 9:
                stageName = "Calculate Weapon Damage";
                break;
            case 10:
                stageName = "Determine Player Rank";
                break;
            case 11:
                stageName = "?????";
                break;
        }
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        if(as01Number > 0)
        {
            Debug.Log($"{as01Number} is Positive");
        }
        else if(as01Number < 0)
        {
            Debug.Log($"{as01Number} is Negative");
        }
        else{
            Debug.Log($"{as01Number} is Zero");
        }
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        switch(as02Day){
            case 1:
                Debug.Log($"{as02Day} is Monday");
                break;
            case 2:
                Debug.Log($"{as02Day} is Tuesday");
                break;
            case 3:
                Debug.Log($"{as02Day} is Wednesday");
                break;
            case 4:
                Debug.Log($"{as02Day} is Thursday");
                break;
            case 5:
                Debug.Log($"{as02Day} is Friday");
                break;
            case 6:
                Debug.Log($"{as02Day} is Saturday");
                break;
            case 7:
                Debug.Log($"{as02Day} is Sunday");
                break;
            default:
                Debug.Log($"{as02Day} is Invalid Day");
                break;
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        as03CorrectPassword = "113333555555";

        if(as03InputPassword == as03CorrectPassword){
            Debug.Log($"{as03InputPassword} is Correct Password. Look like you have a very good memory.");
        }
        else{
            Debug.Log($"{as03InputPassword} is Incorrect Password. Your are at limit now. Please try againg in next 99 year. (>.0)");
        }
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        if(as04Score >= 80){
            Debug.Log($"{as04Score} is Your Score. Your Grade is A. Hmm Did you cheat???");
        }
        else if(as04Score >= 70){
            Debug.Log($"{as04Score} is Your Score. Your Grade is B. You are Good but you should do better than this.");
        }
        else if(as04Score >= 60){
            Debug.Log($"{as04Score} is Your Score. Your Grade is C. It ok but It will going to bad for sure.");
        }
        else if(as04Score >= 50){
            Debug.Log($"{as04Score} is Your Score. Your Grade is D. You should to try harder.");
        }
        else{
            Debug.Log($"{as04Score} is Your Score. Your Grade is F. Drop a course and try again next year. (>.0)");
        }
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        if(as05Year % 4 == 0  && as05Year % 100 != 0 || as05Year % 400 == 0)
        {
            Debug.Log($"{as05Year} is a Leap Year");
        }
        else{
            Debug.Log($"{as05Year} is not a Leap Year");
        }
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public double result = 0.0;
    public bool isOp;
    public void As06_Calculate()
    {
        isOp = true;
        switch(as06Op)
        {
            case '+':
                result = as06Num1 + as06Num2;
                break;
            case '-':
                result = as06Num1 - as06Num2;
                break;
            case '*':
                 result = as06Num1 * as06Num2;
                 break;
            case '/':
                if(as06Num2 == 0)
                {
                    Debug.Log("Cannot divide by zero");
                    return;
                }
                result = as06Num1 / as06Num2;
                break;
            default:
                isOp = false;
                break;
        }
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        if(as07Month == 12 || as07Month == 1 || as07Month == 2)
        {
            Debug.Log($"{as07Month} is Winter");
        }
        else if(as07Month >= 3 && as07Month <= 5)
        {
            Debug.Log($"{as07Month} is Spring");
        }
        else if(as07Month >= 6 && as07Month <= 8)
        {
            Debug.Log($"{as07Month} is Summer");
        }
        else if(as07Month >= 9 && as07Month <= 11)
        {
            Debug.Log($"{as07Month} is Autumn");
        }
        else{
            Debug.Log($"{as07Month} is Invalid Month");
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        if(as08Quantity > 0)
        {
            if(as08Payment >= as08Price)
            {
                Debug.Log("You have received the product.");
                if(as08Payment > as08Price)
                {
                    int change = as08Payment - as08Price;
                    Debug.Log($"Your change is {change}");
                }
            }
            else
            {
                Debug.Log("You have not received the product. \n Please pay the full amount.");
            }
        }
        else
        {
            Debug.Log("Out of stock. \n Please try again later.");
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        as09ComputerChoice = Random.Range(0, 3);

        if(as09UserChoice < 0 || as09UserChoice > 2)
        {
            Debug.Log("Invalid choice. Please choose 0 for Rock, 1 for Paper, or 2 for Scissors.");
            return;
        }

        if(as09UserChoice == as09ComputerChoice)
        {
            Debug.Log("It's a tie!");
        }
        else if((as09UserChoice == 0 && as09ComputerChoice == 2) ||
                (as09UserChoice == 1 && as09ComputerChoice == 0) ||
                (as09UserChoice == 2 && as09ComputerChoice == 1))
        {
            Debug.Log("You win!");
        }
        else
        {
            Debug.Log("You lose!");
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        double damageMultiplier = 1.0;

        switch(as10WeaponType.ToLower())
        {
            case "sword":
                damageMultiplier = 1.3;
                break;
            case "axe":
                damageMultiplier = 1.4;
                break;
            case "bow":
                damageMultiplier = 1.2;
                break;
            case "staff":
                damageMultiplier = 1.5;
                break;
            case "dagger":
                damageMultiplier = 1.1;
                break;
            default:
                as10WeaponType = "Unknown Weapon";
                damageMultiplier = 1.0;
                break;
        }

        int totalDamage = (int)(as10BaseDamage * damageMultiplier);
        Debug.Log($"Weapon Type: {as10WeaponType}, total Damage: {totalDamage}");
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        string rank;
        int totalCoin = 0;

        if(as11Score < 0 || as11CompletionTime < 0)
        {
            Debug.Log("Invalid score or time");
            return;
        }

        if(as11Score >= 8000)
        {
            rank = "Gold";
            totalCoin += 100;
        }
        else if(as11Score >= 6000)
        {
            rank = "Silver";
            totalCoin += 75;
        }
        else if(as11Score >= 4000)
        {
            rank = "Bronze";
            totalCoin += 50;
        }
        else
        {
            rank = "Participation";
            totalCoin += 25;
        }

        if(as11CompletionTime <= 30)
        {
            totalCoin += 25;
        }
        else if(as11CompletionTime <= 60)
        {
            totalCoin += 10;
        }

        Debug.Log($"Player Rank: {rank}, Coins Awarded: {totalCoin}");
    }
}
