

Buffet buf1 = new Buffet();

SweetTooth sweet1 = new SweetTooth();

SpiceHound spicy1 = new SpiceHound();

Console.WriteLine("Sweet1:");

while (sweet1.IsFull != true)
{
    sweet1.Consume(buf1.Serve());
}
sweet1.Consume(buf1.Serve());

Console.WriteLine("*********************");
Console.WriteLine("Sweet1:");

while (spicy1.IsFull != true)
{
    spicy1.Consume(buf1.Serve());
}
spicy1.Consume(buf1.Serve());

