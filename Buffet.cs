class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Cereal", 100, false, true),
            new Food("Chocapic", 200, false, true),
            new Food("Zucaritas", 300, false, true),
            new Food("Manzana", 500, false, true),
            new Food("Huevo", 600, true, false),
            new Food("Chela", 100, true, false),
            new Food("Coca-cola", 600, true, false),
        };
    }
     
    public Food Serve()
    {
        Random random = new Random();
        int randomFood = random.Next(1,8);
        Food seleccion = new Food("",1,true,true);
        for (int i = 0; i < Menu.Count; i++)
        {
            if (i == randomFood)
            {
                seleccion= Menu[i];
            }
        }
        return seleccion;
    }
}