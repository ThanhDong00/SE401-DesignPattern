public class Client {
    public static void main(String[] args) {
        ShopFacade.getInstance().buyProductByCashWithFreeShipping("freeShip@gmail.com");
        ShopFacade.getInstance().buyProductByPaypalWithStandardShipping("Test@gmail.com", "0988.999.999");
    }
}
