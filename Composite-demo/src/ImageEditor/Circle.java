package ImageEditor;

public class Circle extends Dot {
    double radius;

    public Circle() {
        super();
        radius = 0;
    }

    public Circle(int x, int y, int r) {
        super(x, y);
        radius = r;
    }

    @Override
    public void draw() {
        System.out.println("Draw Circle");
    }
}
