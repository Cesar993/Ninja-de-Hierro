class SweetTooth : Ninja
{
    // provide override for IsFull (Full at 1500 Calories)

    public override bool IsFull {
        get{
            if (calorieIntake>=1500)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
    
    public override void Consume(IConsumable item)
    {
        // provide override for Consume
        if (!IsFull)
        {   
            if (item.IsSweet ==true)
            {
                calorieIntake +=10;
            }
            calorieIntake += item.Calories;
            ConsumptionHistory.Add(item);
            Console.WriteLine(item.GetInfo());
        }
        else
        {
            Console.WriteLine("Esta lleno");
        }
        
    }
}

