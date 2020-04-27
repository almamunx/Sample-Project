**ASP.NET Core 3.1 DB First Project using MySQL Database with CRUD operation**

**To create connection with MySQL server**

1. In the Browse tab of **Nuget package manager**, search for package **Pomelo.EntityFrameworkCore.MySQL**

2. Add services at **Startup.cs**
```
services.AddCors();
services.AddDbContext<SampleDBContext>(options => options.UseMySql(Configuration.GetConnectionString("SampleDB")));
```

3. change connection string at **appsettings.json**
```
 "ConnectionStrings": {
    "SampleDB": "server=localhost;port=3306;database=sampledb-cf;user=root;password="
  }
```
4. Run these commads at **Package Manager Console**   for data migration

   `Add-Migration InitialCreate`
   
   `Update-Database`
