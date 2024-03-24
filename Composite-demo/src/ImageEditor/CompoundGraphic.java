package ImageEditor;

public class CompoundGraphic implements Graphic {
    Graphic[] children;

    public void add(Graphic child , int i) {
        children[i] = child;
    }

    public void remove(Graphic child) {

    }


    @Override
    public void move(int x, int y) {
        for (Graphic child : children) {
            child.move(x, y);
        }
    }

    @Override
    public void draw() {
        for (Graphic child : children) {
            child.draw();
        }
    }
}
