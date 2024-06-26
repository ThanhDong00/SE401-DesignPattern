package ImageEditor;

public class Dot implements Graphic {
    int x;
    int y;
    public Dot() {
        x = 0;
        y = 0;
    }
    public Dot(int x, int y){
        this.x = x;
        this.y = y;
    }

    @Override
    public void move(int x, int y) {
        this.x += x;
        this.y += y;
    }

    @Override
    public void draw() {
        System.out.println("Print Dot");
    }
}
