using Debug = UnityEngine.Debug;
public class Cultivator
{
    public int age_years { get; private set; }
    public int age_days { get; private set; }
    public int max_age { get; private set; }
    public int xp;
    public int level;
    public int knowledge; //{ get; private set; }
    public string history;
    public int requiredxp;

    // Constructor
    public Cultivator()
    {
        age_years = 0;
        age_days = 0;
        max_age = 80;
        xp = 0;
        level = 0;
        knowledge = 0;
        history = "";
        requiredxp = 100;
    }

    public void AddDays(int daysToAdd)
    {
        age_days += daysToAdd;
        NormalizeTime();
    }
    public void AddHistory(string action){
        history += action + "\n";
    }
    public void Cultivate(int days)
    {
        AddDays(days);
        xp += days * knowledge;
    }

    private void NormalizeTime()
    {
  
        if (age_days < 0)
        {
            age_days = 0;
            Debug.Log("Error in age_days");
        }
        const int daysInYear = 365;
        int overflowedYears = age_days / daysInYear;
        age_days -= overflowedYears * daysInYear;
        age_years += overflowedYears;
    }

    public override string ToString()
    {
        return $@"
    Name: Player
    Age: {age_years}/{max_age}
    Days: {age_days}/365
    Reputation: 
    Morality: 
    Cultivation Points: {xp}
    Knowledge: {knowledge}
    Realm: 练气{level}层
    Gold: 
    Health: 
    Attack: 
    Defense: 
    Mana: 
"; ;
    }
}
