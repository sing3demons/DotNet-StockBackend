# สร้าง database docker

```
docker run -it --rm --name mssql -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Passw0rd1234!' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-CU10-ubuntu-20.04
```

 สร้างโปรเจค dotnet
 ```
dotnet new webapi -o StockBackend
```

```
 cd StockBackend
 ```

 ```
 code .
 ```


ติดตั้งเครื่องมือสำหรับติดต่อ database

```
dotnet add package Microsoft.EntityFrameworkCore
```

```
dotnet add package Microsoft.EntityFrameworkCore.Sqlserver
```

ไปที่ appsettings.json -->

```
 "ConnectionStrings": {
    "DefaultConnection_sql_server": "Server=localhost;database=cs_stock;user id=sa;password=Passw0rd1234!;"
  },
  ```

ไปที่ Startup.cs เพิ่มคำสั่งใน  public void ConfigureServices(IServiceCollection services)

```
 services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection_sql_server")));
```

สร้าง Models  

```
namespace StockBackend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int stock { get; set; }
         [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public double Price { get; set; }
    }

}
```
สร้าง  DbContext

```
using Microsoft.EntityFrameworkCore;
using StockBackend.Models;

namespace StockBackend.Database
{
    public class DatabaseContext : DbContext
    {
        DbSet<Product> Products { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
```
---
run command: เพื่อสร้าง table ตาม model

```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

```
dotnet tool install --global dotnet-ef
```

```
dotnet ef migrations add "Initial Migrations"
```

```
dotnet ef database update
```
