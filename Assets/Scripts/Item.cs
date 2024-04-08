
public class Item 
{
    public static int TYPEFOOD = 1;
    public string name;
    public string img;
    public int type;
    public int count;
    public int price;
    public int lvlWhenUnlock;
    public float timeToGrow;

    public Item(string name, string img, int type, int count, int price, int lvlWhenUnlock, float timeToGrow)
    {
        this.name = name;
        this.img = img; 
        this.type = type;
        this.count = count; 
        this.price = price;
        this.lvlWhenUnlock = lvlWhenUnlock;
        this.timeToGrow = timeToGrow;
    }
}
