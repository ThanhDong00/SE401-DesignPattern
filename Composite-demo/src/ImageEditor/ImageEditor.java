package ImageEditor;

import java.util.Scanner;

public class ImageEditor {
    public static void main(String[] args) {
        CompoundGraphic all = new CompoundGraphic();

        Scanner in = new Scanner(System.in);
        System.out.println("Nhap so luong phan tu muon nhap: ");
        int n = in.nextInt();
        all.children = new Graphic[n];

        all.add(new Dot(1, 2), 0);
        all.add(new Circle(5, 3, 10), 1);
        all.draw();
    }
}
