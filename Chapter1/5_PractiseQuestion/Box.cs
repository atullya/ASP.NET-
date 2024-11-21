class Box{
    private int length;
    private int breadth;
    private int height;

    public Box(int length, int breadth, int height){
        this.length=length;
        this.breadth=breadth;
        this.height=height;

    }
    public int getVol(){
        return length*breadth*height;
    }
}
class BoxWeight:Box{
    private int weight;
    public BoxWeight(int weight,int length,int breadth,int height):base(length,breadth,height){
        this.weight=weight;
    }
    public int getWeight(){
        return weight;
    }
}