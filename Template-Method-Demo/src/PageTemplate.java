public abstract class PageTemplate {
    protected void showHeader() {
        System.out.println("Header");
    }

    protected void showNavigation() {
        System.out.println("Nav");
    }

    protected void showFooter() {
        System.out.println("Footer");
    }

    protected abstract void showBody();

    public final void showPage() {
        showHeader();
        showNavigation();
        showBody();
        showFooter();
    }
}
