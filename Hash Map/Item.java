public class Item{
    public String key;
    public String value;
    public String printAll;
    public Item next;

    public Item(String k, String v){
        this.key = k;
        this.value = v;
        this.next = null;
    }

}