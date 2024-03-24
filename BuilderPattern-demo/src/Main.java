public class Main {
    public static void main(String[] args){
        Student student = new StudentConcreteBuilder().setFirstName("Pham").setLastName("Thanh Dong").build();

        System.out.println(student);
    }
}