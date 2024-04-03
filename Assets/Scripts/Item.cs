
public class Item 
{
    public string name;
    public string img;
    public int type;
    public int count;
    public int price;
    public int lvlWhenUnlock;

    public Item(string name, string img, int type, int count, int price, int lvlWhenUnlock)
    {
        this.name = name;
        this.img = img; 
        this.type = type;
        this.count = count; 
        this.price = price;
        this.lvlWhenUnlock = lvlWhenUnlock;
    }
}
