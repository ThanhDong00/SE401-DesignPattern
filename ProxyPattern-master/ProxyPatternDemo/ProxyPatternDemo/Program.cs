using System;

// Giao diện chung cho Resource và ProxyResource
public interface IResource
{
    void Access();
}

// Resource - Lớp thực hiện tài nguyên hệ thống
public class Resource : IResource
{
    private string name;

    public Resource(string name)
    {
        this.name = name;
    }

    public void Access()
    {
        Console.WriteLine("Accessing resource: " + name);
    }
}

// ProxyResource - Proxy kiểm soát truy cập và bảo mật vào tài nguyên hệ thống
public class ProxyResource : IResource
{
    private Resource resource;
    private string name;
    private string password;

    public ProxyResource(string name, string password)
    {
        this.name = name;
        this.password = password;
    }

    public void Access()
    {
        if (Authenticate())
        {
            if (resource == null)
            {
                resource = new Resource(name);
            }

            resource.Access();
        }
        else
        {
            Console.WriteLine("Access denied.");
        }
    }

    private bool Authenticate()
    {
        // Kiểm tra thông tin xác thực
        return password == "admin";
    }
}

// Lớp Client sử dụng ProxyResource để truy cập vào tài nguyên hệ thống
public class Client
{
    static void Main(string[] args)
    {
        // Tạo đối tượng ProxyResource
        IResource resource = new ProxyResource("Database", "admin");

        // Gọi phương thức Access() thông qua ProxyResource
        resource.Access();

        Console.WriteLine();

        // Truy cập sẽ bị từ chối vì mật khẩu không chính xác
        IResource invalidResource = new ProxyResource("Database", "password");
        invalidResource.Access();
    }
}