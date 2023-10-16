class SpiceHound : Ninja
{
    // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull {
        get{
            if (calorieIntake>=1200)
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
            if (item.IsSpicy ==true)
            {
                calorieIntake -=5;
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

